using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsPopups {
	/// <summary>
	/// Popup window that reports information to the user within a certain time window.
	/// </summary>
	public partial class Popup: Form {
		/// <summary>
		/// How many ticks per second the window animations will run at.
		/// </summary>
		private const double TICKS_PER_SECOND = 60;
		/// <summary>
		/// Vertical margin between stacked popup windows.
		/// </summary>
		private const int WINDOW_VERTICAL_MARGIN = 8;

		/// <summary>
		/// Interval (in milliseconds) between each animation tick.
		/// </summary>
		private static readonly int fadeInterval = (int)Math.Round(1000 / (2 * TICKS_PER_SECOND));
		/// <summary>
		/// Timer that constantly updates the animation of popup windows.
		/// </summary>
		private static readonly Timer tickTimer = new Timer() {
			Interval = fadeInterval,
		};
		/// <summary>
		/// Head of the doubly linked list of popup windows.
		/// </summary>
		private static Popup headWindow = null;
		/// <summary>
		/// Tail of the doubly linked list of popup windows.
		/// </summary>
		private static Popup tailWindow = null;

		/// <summary>
		/// Timer that tracks the time elapsed since this popup window finished fading in and entered the hold state.
		/// </summary>
		private readonly Timer holdTimer;
		/// <summary>
		/// Stopwatch that tracks the time elapsed since a fade fade begun for this popup window.
		/// </summary>
		private readonly Stopwatch fadeStopwatch;
		/// <summary>
		/// Animation driver that controls the fade in, hold, and fade out of this popup window.
		/// </summary>
		private readonly Anim animation;

		/// <summary>
		/// Previous popup window in the doubly linked list.
		/// </summary>
		private Popup previous;
		/// <summary>
		/// Next popup window in the doubly linked list.
		/// </summary>
		private Popup next;

		/// <summary>
		/// Constructor required by the designer.
		/// </summary>
		private Popup() {
			this.InitializeComponent();
		}

		/// <summary>
		/// Main constructor for the popup.
		/// </summary>
		/// <param name="message">Message that the popup window shows. Allowed to be <see langword="null"/>.</param>
		/// <param name="title">Brief, big title to show above the message. Allowed to be <see langword="null"/>.</param>
		/// <param name="style">Key visuals to use.</param>
		/// <param name="animation">Animation driver to apply for this window's lifetime.</param>
		private Popup(string message, string title, Style style, Anim animation)
		: this() {
			message = message?.Trim();
			title = title?.Trim();

			this.Message = message;
			this.Title = title;
			this.animation = animation;

			//Components
			this.UsesTitle = !string.IsNullOrWhiteSpace(title);
			if(this.UsesTitle)
				this.lblTitle.Text = title;
			else
				this.pnlTitle.Visible = false;

			this.UsesMessage = !string.IsNullOrWhiteSpace(message);
			if(this.UsesMessage)
				this.lblMessage.Text = message;

			//Style
			this.UsesStyle = StyleIndex.TryGet(style, out StyleProps styleProps);
			Image icon = styleProps.Icon;
			Color color = styleProps.Color;
			if(this.UsesStyle) {
				this.pbIcon.Image = icon;

				this.pnlAccentBorder.BackColor = color;
				this.pnlSweep.BackColor = color;
				this.pnlSweep.Location = new Point(0, -this.Height / 2);
				this.pnlSweep.Size = new Size(this.Width, this.Height * 2);
			} else {
				this.Width -= this.pnlAccentBorder.Width + this.pnlIcon.Width;
				this.pnlAccentBorder.Visible = false;
				this.pnlIcon.Visible = false;
				this.pnlSweep.Visible = false;
			}

			if(!this.UsesMessage || (!this.UsesStyle && !this.UsesTitle))
				this.pnlMessageBottomPadding.Visible = false;

			if(this.UsesTitle)
				this.lblTitle.ForeColor = color;

			//Animation
			this.fadeStopwatch = new Stopwatch();
			this.holdTimer = new Timer() {
				Interval = (int)animation.TimeHold,
			};
			this.holdTimer.Tick += this.BeginClosePopup;

			//Doubly linked list behavior
			this.Stacked = 0;
			if(headWindow is null) {
				headWindow = this;
				tailWindow = this;
				this.previous = null;
				this.next = null;
			} else {
				tailWindow.next = this;
				this.previous = tailWindow;
				this.Stacked = tailWindow.Stacked + tailWindow.Height + WINDOW_VERTICAL_MARGIN;
				tailWindow = this;
			}
		}

		/// <summary>
		/// Message that the popup window shows.
		/// </summary>
		public string Message { get; }

		/// <summary>
		/// Title that the popup window shows.
		/// </summary>
		public string Title { get; }

		/// <summary>
		/// Vertical stacking of this popup window.
		/// </summary>
		public int Stacked { get; private set; }

		/// <summary>
		/// Whether the popup window has a title or not.
		/// </summary>
		private bool UsesTitle { get; }

		/// <summary>
		/// Whether the popup window has a message or not.
		/// </summary>
		private bool UsesMessage { get; }

		/// <summary>
		/// Whether the popup window has a key style assigned or not.
		/// </summary>
		private bool UsesStyle { get; }

		#region Life Cycle (ordered)
		private void Popup_Shown(object sender, EventArgs e) {
			Size hLimit = new Size(
				this.pnlText.Width - this.pnlMessageLeftPadding.Width,
				int.MaxValue);

			int titleMessageStackedHeight =
				(this.UsesTitle ? this.pnlTitle.Height : 0)
				+ (this.UsesMessage ? this.lblMessage.GetPreferredSize(hLimit).Height : 0)
				+ (this.UsesMessage ? this.lblMessage.Padding.Vertical : 0)
				+ (this.pnlMessageBottomPadding.Visible ? this.pnlMessageBottomPadding.Height : 0)
				+ this.pnlContent.Padding.Vertical;

			int iconStackedHeight = this.UsesStyle
				? (this.pbIcon.Height
					+ this.pnlContent.Padding.Vertical
					+ 2)
				: 0;

			this.Height = Math.Max(
				titleMessageStackedHeight,
				iconStackedHeight);

			//Recalcular Apilado
			this.Stacked = (this.previous is Popup)
				? this.previous.Stacked + this.previous.Height + WINDOW_VERTICAL_MARGIN
				: 0;

			Screen screen = Screen.FromControl(this);
			this.Location = new Point(
				screen.WorkingArea.Width - this.Width,
				screen.WorkingArea.Height - this.Stacked);

			this.BeginAnimation();
		}

		private void BeginAnimation() {
			tickTimer.Tick += this.FadeInTick;
			this.fadeStopwatch.Start();
			tickTimer.Start();
		}

		private void FadeInTick(object sender, EventArgs e) {
			long timeMs = this.fadeStopwatch.ElapsedMilliseconds;
			double y = this.animation.ValueIn(timeMs);

			this.Opacity = y;

			Screen screen = Screen.FromControl(this);
			this.Location = new Point(
				screen.WorkingArea.Width - this.Width,
				screen.WorkingArea.Height - (int)Math.Ceiling(this.Height * 0.7) - (int)Math.Floor(this.Height * y * 0.3) - this.Stacked);

			if(this.UsesStyle) {
				int ww = (int)(this.Width * Math.Pow(1 - y, 3));
				if(ww > 0)
					this.pnlSweep.Width = this.pnlAccentBorder.Width + ww;
				else
					this.pnlSweep.Visible = false;
			}

			if(timeMs >= this.animation.TimeIn) {
				tickTimer.Tick -= this.FadeInTick;
				tickTimer.Tick += this.HoldTick;
				this.holdTimer.Start();
			}
		}

		private void HoldTick(object sender, EventArgs e) {
			Screen screen = Screen.FromControl(this);
			this.Location = new Point(
				screen.WorkingArea.Width - this.Width,
				screen.WorkingArea.Height - this.Height - this.Stacked);
		}

		private void BeginClosePopup(object sender, EventArgs e) {
			this.holdTimer.Stop();
			this.fadeStopwatch.Restart();
			tickTimer.Tick -= this.HoldTick;
			tickTimer.Tick += this.FadeOutTick;
		}

		private void FadeOutTick(object sender, EventArgs e) {
			long tiempoMs = this.fadeStopwatch.ElapsedMilliseconds;
			double y = this.animation.ValueOut(tiempoMs);

			this.Opacity = 1 - y;

			Screen screen = Screen.FromControl(this);
			this.Location = new Point(
				screen.WorkingArea.Width - this.Width + (int)(this.Width * 0.5 * y),
				screen.WorkingArea.Height - this.Height - this.Stacked);

			if(tiempoMs >= this.animation.TimeOut) {
				tickTimer.Tick -= this.FadeOutTick;
				this.Close();
			}
		}

		private void Popup_FormClosed(object sender, FormClosedEventArgs e) {
			if(headWindow == this)
				headWindow = this.next;

			if(tailWindow == this)
				tailWindow = this.previous;

			if(this.previous is Popup)
				this.previous.next = this.next;

			if(this.next is Popup)
				this.next.previous = this.previous;

			Popup actual = this.next;
			while(actual is Popup) {
				actual.Stacked = (actual.previous is Popup)
					? actual.previous.Stacked + actual.previous.Height + WINDOW_VERTICAL_MARGIN
					: 0;
				actual = actual.next;
			}

			this.Dispose();
		}
		#endregion

		#region Constructor Overloads
		private Popup(string message, string title, Style style)
		: this(message, title, style, new Anim()) { }

		private Popup(string message, string title)
		: this(message, title, Style.Neutral) { }

		private Popup(string message)
		: this(message, null as string) { }

		private Popup(string message, Style style, Anim animation)
		: this(message, null, style, animation) { }

		private Popup(string message, Style style)
		: this(message, null, style) { }

		private Popup(string message, string title, Anim animation)
		: this(message, title, Style.Neutral, animation) { }

		private Popup(string message, Anim animation)
		: this(message, null, animation) { }
		#endregion

		#region Show(...)
		public static void Show(string message) {
			Popup f = new Popup(message);
			f.Show();
		}

		public static void Show(string message, string title) {
			Popup f = new Popup(message, title);
			f.Show();
		}

		public static void Show(string message, Style style) {
			Popup f = new Popup(message, style);
			f.Show();
		}

		public static void Show(string message, int durationMs) {
			Popup f = new Popup(message, (Anim)durationMs);
			f.Show();
		}

		public static void Show(string message, Anim animation) {
			Popup f = new Popup(message, animation);
			f.Show();
		}

		public static void Show(string message, string title, Style style) {
			Popup f = new Popup(message, title, style);
			f.Show();
		}

		public static void Show(string message, string title, int durationMs) {
			Popup f = new Popup(message, title, (Anim)durationMs);
			f.Show();
		}

		public static void Show(string message, string title, Anim animation) {
			Popup f = new Popup(message, title, animation);
			f.Show();
		}

		public static void Show(string message, string title, Style style, int durationMs) {
			Popup f = new Popup(message, title, style, (Anim)durationMs);
			f.Show();
		}

		public static void Show(string message, string title, Style style, Anim animation) {
			Popup f = new Popup(message, title, style, animation);
			f.Show();
		}

		public static void Show(string message, Style style, int durationMs) {
			Popup f = new Popup(message, style, (Anim)durationMs);
			f.Show();
		}

		public static void Show(string message, Style style, Anim animation) {
			Popup f = new Popup(message, style, animation);
			f.Show();
		}
		#endregion
	}
}
