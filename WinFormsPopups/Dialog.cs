using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsPopups {
	public partial class Dialog: Form {
		/// <summary>
		/// How many ticks per second the window animations will run at.
		/// </summary>
		private const double TICKS_PER_SECOND = 60;

		/// <summary>
		/// Mapping of the <see cref="DialogButtons"/> enum to their respective, required button properties.
		/// </summary>
		private static readonly Dictionary<DialogButtons, ButtonProps[]> buttonsIndex = new Dictionary<DialogButtons, ButtonProps[]> {
			{ DialogButtons.OK, new ButtonProps[] {
				new ButtonProps(DialogResult.OK, "Aceptar", PrimaryColor, Color.White),
			} },
			{ DialogButtons.OKCancel, new ButtonProps[] {
				new ButtonProps(DialogResult.OK, "Aceptar", PrimaryColor, Color.White),
				new ButtonProps(DialogResult.Cancel, "Cancelar", SecondaryColor, Color.Black),
			} },
			{ DialogButtons.AbortRetryIgnore, new ButtonProps[] {
				new ButtonProps(DialogResult.Abort, "Abortar", StyleIndex.Error.Color, Color.White),
				new ButtonProps(DialogResult.Retry, "Reintentar", PrimaryColor, Color.White),
				new ButtonProps(DialogResult.Ignore, "Ignorar", SecondaryColor, Color.Black),
			} },
			{ DialogButtons.YesNoCancel, new ButtonProps[] {
				new ButtonProps(DialogResult.Yes, "Sí", StyleIndex.Success.Color, Color.White),
				new ButtonProps(DialogResult.No, "No", StyleIndex.Error.Color, Color.White),
				new ButtonProps(DialogResult.Cancel, "Cancelar", SecondaryColor, Color.Black),
			} },
			{ DialogButtons.YesNo, new ButtonProps[] {
				new ButtonProps(DialogResult.Yes, "Sí", StyleIndex.Success.Color, Color.White),
				new ButtonProps(DialogResult.No, "No", StyleIndex.Error.Color, Color.White),
			} },
			{ DialogButtons.RetryCancel, new ButtonProps[] {
				new ButtonProps(DialogResult.Retry, "Reintentar", PrimaryColor, Color.White),
				new ButtonProps(DialogResult.Cancel, "Cancelar", SecondaryColor, Color.Black),
			} },
		};
		/// <summary>
		/// Interval (in milliseconds) between each animation tick.
		/// </summary>
		private static readonly int fadeInterval = (int)Math.Round(1000 / (2 * TICKS_PER_SECOND));
		/// <summary>
		/// Timer that constantly updates the animation of dialog windows.
		/// </summary>
		private static readonly Timer tickTimer = new Timer() {
			Interval = fadeInterval,
		};

		/// <summary>
		/// Buttons that will be shown in this dialog window.
		/// </summary>
		private readonly Button[] buttons;
		/// <summary>
		/// Stopwatch that tracks the time elapsed since a fade begun for this dialog window.
		/// </summary>
		private readonly Stopwatch fadeStopwatch;
		/// <summary>
		/// Animation driver that controls the fade in, hold, and fade out of this dialog window.
		/// </summary>
		private readonly Anim animation;

		/// <summary>
		/// Whether the dialog window is currently being transitioned to a shown state.
		/// </summary>
		private bool showing;
		/// <summary>
		/// Whether the dialog window is currently being transitioned to a closed state.
		/// </summary>
		private bool closing;
		/// <summary>
		/// Whether the dialog window can be closed.
		/// </summary>
		private bool canCloseCompletely;
		/// <summary>
		/// The result of the dialog window that will be returned when the fade out animation is finished.
		/// </summary>
		private DialogResult pendingDialogResult;

		/// <summary>
		/// Constructor required by the designer
		/// </summary>
		private Dialog() {
			this.InitializeComponent();
		}

		/// <summary>
		/// Main constructor for the popup.
		/// </summary>
		/// <param name="message">Message that the dialog window shows. Allowed to be <see langword="null"/>.</param>
		/// <param name="title">Brief, big title to show above the message. Allowed to be <see langword="null"/>.</param>
		/// <param name="style">Key visuals to use.</param>
		/// <param name="animation">Animation driver to apply for this window's lifetime.</param>
		public Dialog(string message, string title, DialogButtons buttons, Style style, Anim animation)
		: this() {
			message = message?.Trim();
			title = title?.Trim();

			this.Mensaje = message;
			this.Title = title;
			this.animation = animation;
			this.showing = true;
			this.closing = false;
			this.canCloseCompletely = false;

			//Components
			this.UsesTitle = !string.IsNullOrWhiteSpace(title);
			if(this.UsesTitle)
				this.lblTitle.Text = title;
			else
				this.pnlTitle.Visible = false;

			this.UsesMessage = !string.IsNullOrWhiteSpace(message);
			if(this.UsesMessage)
				this.lblMessage.Text = message;

			//Commit buttons
			this.buttons = new Button[] {
				this.btn3,
				this.btn2,
				this.btn1,
			};
			buttonsIndex.TryGetValue(buttons, out ButtonProps[] buttonsProps);

			Button button;
			ButtonProps buttonProps;
			int buttonCount = buttonsProps.Length;
			for(int i = 0; i < buttonCount; i++) {
				button = this.buttons[i];
				buttonProps = buttonsProps[buttonCount - i - 1];
				button.DialogResult = buttonProps.DialogResult;
				button.Text = buttonProps.Text;
				button.ForeColor = buttonProps.ForeColor;
				button.BackColor = buttonProps.BackColor;
			}
			for(int i = buttonCount; i < 3; i++) {
				this.buttons[i].Visible = false;
			}
			this.AcceptButton = this.buttons[buttonCount - 1];
			this.CancelButton = this.buttons[0];

			//Style
			this.UsesStyle = StyleIndex.TryGet(style, out StyleProps styleProps);
			Image icon = styleProps.Icon;
			Color color = styleProps.Color;
			if(this.UsesStyle) {
				this.pbIcon.Image = icon;

				this.pnlLeftBorder.BackColor = color;
				this.pnlSweep.BackColor = color;
				this.pnlSweep.Location = new Point(0, -this.Height / 2);
				this.pnlSweep.Size = new Size(this.Width, this.Height * 2);
			} else {
				this.Width -= this.pnlLeftBorder.Width + this.pnlIcon.Width;
				this.pnlLeftBorder.Visible = false;
				this.pnlIcon.Visible = false;
				this.pnlSweep.Visible = false;
			}

			if(!this.UsesMessage || (!this.UsesStyle && !this.UsesTitle))
				this.pnlMessageBottomPadding.Visible = false;

			if(this.UsesTitle)
				this.lblTitle.ForeColor = color;

			//Animation
			this.fadeStopwatch = new Stopwatch();
		}

		/// <summary>
		/// Primary and call-to-action buttons color
		/// </summary>
		public static Color PrimaryColor { get; set; } = Color.FromArgb(7, 84, 151);

		/// <summary>
		/// Secondary buttons color
		/// </summary>
		private static Color SecondaryColor { get; set; } = Color.FromArgb(179, 183, 194);

		/// <summary>
		/// Message that the dialog window shows.
		/// </summary>
		public string Mensaje { get; }

		/// <summary>
		/// Title that the popup window shows.
		/// </summary>
		public string Title { get; }

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
		private void Dialog_Shown(object sender, EventArgs e) {
			Size hLimit = new Size(
				this.pnlText.Width - this.pnlMessageLeftPadding.Width,
				int.MaxValue);

			int stackedHeight =
				(this.UsesTitle ? this.pnlTitle.Height : 0)
				+ (this.UsesMessage ? this.lblMessage.GetPreferredSize(hLimit).Height : 0)
				+ (this.UsesMessage ? this.lblMessage.Padding.Vertical : 0)
				+ (this.pnlMessageBottomPadding.Visible ? this.pnlMessageBottomPadding.Height : 0)
				+ this.pnlCommitButtons.Height
				+ this.pnlContent.Padding.Vertical;

			this.ClientSize = new Size(
				this.ClientSize.Width,
				stackedHeight
			);

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

			if(this.UsesStyle) {
				int ww = (int)(this.Width * Math.Pow(1 - y, 3));
				if(ww > 0)
					this.pnlSweep.Width = this.pnlLeftBorder.Width + ww;
				else
					this.pnlSweep.Visible = false;
			}

			if(timeMs >= this.animation.TimeIn) {
				tickTimer.Tick -= this.FadeInTick;
				this.showing = false;
			}
		}

		private void CommitButton_Click(object sender, EventArgs e) {
			if(!(sender is Button button))
				return;

			this.DialogResult = DialogResult.None;
			this.BeginFadeOut(button.DialogResult);
		}

		private void BeginFadeOut(DialogResult result) {
			if(this.closing || this.canCloseCompletely)
				return;

			if(this.showing) {
				tickTimer.Tick -= this.FadeInTick;
				this.showing = false;
			}

			this.closing = true;
			this.pendingDialogResult = result;
			this.fadeStopwatch.Restart();
			tickTimer.Tick += this.FadeOutTick;
		}

		private void FadeOutTick(object sender, EventArgs e) {
			long timeMs = this.fadeStopwatch.ElapsedMilliseconds;
			double y = this.animation.ValueOut(timeMs);

			this.Opacity = 1 - y;

			if(timeMs >= this.animation.TimeOut) {
				tickTimer.Tick -= this.FadeOutTick;
				this.closing = false;
				this.canCloseCompletely = true;
				this.DialogResult = this.pendingDialogResult;
			}
		}

		private void Dialog_FormClosing(object sender, FormClosingEventArgs e) {
			if(this.canCloseCompletely)
				return;

			this.BeginFadeOut(DialogResult.Cancel);
			this.DialogResult = DialogResult.None;
			e.Cancel = true;
		}

		private void Dialog_FormClosed(object sender, FormClosedEventArgs e) {
			this.Dispose();
		}
		#endregion

		#region Constructor Overloads
		private Dialog(string message, string title, DialogButtons buttons, Style style)
		: this(message, title, buttons, style, new Anim()) { }

		private Dialog(string message, string title, DialogButtons buttons, Anim animation)
		: this(message, title, buttons, Style.Neutral, animation) { }

		private Dialog(string message, string title, DialogButtons buttons)
		: this(message, title, buttons, new Anim()) { }

		private Dialog(string message, string title, Style style, Anim animation)
		: this(message, title, DialogButtons.OK, style, animation) { }

		private Dialog(string message, string title, Style style)
		: this(message, title, style, new Anim()) { }

		private Dialog(string message, string title, Anim animation)
		: this(message, title, DialogButtons.OK, Style.Neutral, animation) { }

		private Dialog(string message, string title)
		: this(message, title, new Anim()) { }

		private Dialog(string message, DialogButtons buttons, Anim animation)
		: this(message, null, buttons, animation) { }

		private Dialog(string message, DialogButtons buttons)
		: this(message, buttons, new Anim()) { }

		private Dialog(string message, Style style, Anim animation)
		: this(message, null, style, animation) { }

		private Dialog(string message, Style style)
		: this(message, style, new Anim()) { }

		private Dialog(string message, Anim animation)
		: this(message, null, DialogButtons.OK, Style.Neutral, animation) { }

		private Dialog(string message)
		: this(message, new Anim()) { }
		#endregion

		#region ShowDialog(...)
		public static DialogResult ShowDialog(string message, string title, DialogButtons buttons, Style style, Anim animation) {
			Dialog f = new Dialog(message, title, buttons, style, animation);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, string title, DialogButtons buttons, Style style, int durationMs) {
			Dialog f = new Dialog(message, title, buttons, style, (Anim)durationMs);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, string title, DialogButtons buttons, Style style) {
			Dialog f = new Dialog(message, title, buttons, style);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, string title, DialogButtons buttons, Anim animation) {
			Dialog f = new Dialog(message, title, buttons, animation);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, string title, DialogButtons buttons, int durationMs) {
			Dialog f = new Dialog(message, title, buttons, (Anim)durationMs);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, string title, DialogButtons buttons) {
			Dialog f = new Dialog(message, title, buttons);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, string title, Style style, Anim animation) {
			Dialog f = new Dialog(message, title, style, animation);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, string title, Style style, int durationMs) {
			Dialog f = new Dialog(message, title, style, (Anim)durationMs);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, string title, Style style) {
			Dialog f = new Dialog(message, title, style);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, string title, Anim animation) {
			Dialog f = new Dialog(message, title, animation);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, string title, int durationMs) {
			Dialog f = new Dialog(message, title, (Anim)durationMs);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, string title) {
			Dialog f = new Dialog(message, title);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, DialogButtons buttons, Anim animation) {
			Dialog f = new Dialog(message, buttons, animation);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, DialogButtons buttons, int durationMs) {
			Dialog f = new Dialog(message, buttons, (Anim)durationMs);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, DialogButtons buttons) {
			Dialog f = new Dialog(message, buttons);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, Style style, Anim animation) {
			Dialog f = new Dialog(message, style, animation);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, Style style, int durationMs) {
			Dialog f = new Dialog(message, style, (Anim)durationMs);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, Style style) {
			Dialog f = new Dialog(message, style);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, Anim animation) {
			Dialog f = new Dialog(message, animation);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message, int durationMs) {
			Dialog f = new Dialog(message, (Anim)durationMs);
			return f.ShowDialog();
		}

		public static DialogResult ShowDialog(string message) {
			Dialog f = new Dialog(message);
			return f.ShowDialog();
		}
		#endregion
	}
}
