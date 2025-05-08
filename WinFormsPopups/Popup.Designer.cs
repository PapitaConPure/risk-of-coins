
namespace WinFormsPopups {
	partial class Popup {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.pnlContent = new System.Windows.Forms.Panel();
			this.pnlText = new System.Windows.Forms.Panel();
			this.lblMessage = new System.Windows.Forms.Label();
			this.pnlMessageLeftPadding = new System.Windows.Forms.Panel();
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlMessageBottomPadding = new System.Windows.Forms.Panel();
			this.pnlIcon = new System.Windows.Forms.Panel();
			this.tlpIcon = new System.Windows.Forms.TableLayoutPanel();
			this.pbIcon = new System.Windows.Forms.PictureBox();
			this.pnlAccentBorder = new System.Windows.Forms.Panel();
			this.pnlSweep = new System.Windows.Forms.Panel();
			this.pnlContent.SuspendLayout();
			this.pnlText.SuspendLayout();
			this.pnlTitle.SuspendLayout();
			this.pnlIcon.SuspendLayout();
			this.tlpIcon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlContent
			// 
			this.pnlContent.Controls.Add(this.pnlText);
			this.pnlContent.Controls.Add(this.pnlIcon);
			this.pnlContent.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContent.Location = new System.Drawing.Point(6, 0);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Padding = new System.Windows.Forms.Padding(10);
			this.pnlContent.Size = new System.Drawing.Size(554, 129);
			this.pnlContent.TabIndex = 1;
			// 
			// pnlText
			// 
			this.pnlText.Controls.Add(this.lblMessage);
			this.pnlText.Controls.Add(this.pnlMessageLeftPadding);
			this.pnlText.Controls.Add(this.pnlTitle);
			this.pnlText.Controls.Add(this.pnlMessageBottomPadding);
			this.pnlText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlText.Location = new System.Drawing.Point(68, 10);
			this.pnlText.Name = "pnlText";
			this.pnlText.Size = new System.Drawing.Size(476, 109);
			this.pnlText.TabIndex = 1;
			// 
			// lblMessage
			// 
			this.lblMessage.AutoEllipsis = true;
			this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMessage.Location = new System.Drawing.Point(5, 55);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(471, 46);
			this.lblMessage.TabIndex = 2;
			this.lblMessage.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque ullamcorper ultr" +
    "ices augue, eget egestas leo tincidunt nec.";
			// 
			// pnlMessageLeftPadding
			// 
			this.pnlMessageLeftPadding.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlMessageLeftPadding.Location = new System.Drawing.Point(0, 55);
			this.pnlMessageLeftPadding.Name = "pnlMessageLeftPadding";
			this.pnlMessageLeftPadding.Size = new System.Drawing.Size(5, 46);
			this.pnlMessageLeftPadding.TabIndex = 3;
			// 
			// pnlTitle
			// 
			this.pnlTitle.AutoSize = true;
			this.pnlTitle.Controls.Add(this.lblTitle);
			this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.pnlTitle.Size = new System.Drawing.Size(476, 55);
			this.pnlTitle.TabIndex = 4;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTitle.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(222, 45);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "Lorem Ipsum";
			// 
			// pnlMessageBottomPadding
			// 
			this.pnlMessageBottomPadding.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlMessageBottomPadding.Location = new System.Drawing.Point(0, 101);
			this.pnlMessageBottomPadding.Name = "pnlMessageBottomPadding";
			this.pnlMessageBottomPadding.Size = new System.Drawing.Size(476, 8);
			this.pnlMessageBottomPadding.TabIndex = 5;
			// 
			// pnlIcon
			// 
			this.pnlIcon.AutoSize = true;
			this.pnlIcon.Controls.Add(this.tlpIcon);
			this.pnlIcon.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlIcon.Location = new System.Drawing.Point(10, 10);
			this.pnlIcon.Name = "pnlIcon";
			this.pnlIcon.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.pnlIcon.Size = new System.Drawing.Size(58, 109);
			this.pnlIcon.TabIndex = 4;
			// 
			// tlpIcon
			// 
			this.tlpIcon.AutoSize = true;
			this.tlpIcon.ColumnCount = 1;
			this.tlpIcon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpIcon.Controls.Add(this.pbIcon, 0, 1);
			this.tlpIcon.Dock = System.Windows.Forms.DockStyle.Left;
			this.tlpIcon.Location = new System.Drawing.Point(0, 0);
			this.tlpIcon.Margin = new System.Windows.Forms.Padding(0);
			this.tlpIcon.Name = "tlpIcon";
			this.tlpIcon.RowCount = 3;
			this.tlpIcon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpIcon.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpIcon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpIcon.Size = new System.Drawing.Size(48, 109);
			this.tlpIcon.TabIndex = 3;
			// 
			// pbIcon
			// 
			this.pbIcon.InitialImage = null;
			this.pbIcon.Location = new System.Drawing.Point(0, 30);
			this.pbIcon.Margin = new System.Windows.Forms.Padding(0);
			this.pbIcon.Name = "pbIcon";
			this.pbIcon.Size = new System.Drawing.Size(48, 48);
			this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbIcon.TabIndex = 0;
			this.pbIcon.TabStop = false;
			// 
			// pnlAccentBorder
			// 
			this.pnlAccentBorder.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlAccentBorder.Location = new System.Drawing.Point(0, 0);
			this.pnlAccentBorder.Name = "pnlAccentBorder";
			this.pnlAccentBorder.Size = new System.Drawing.Size(6, 129);
			this.pnlAccentBorder.TabIndex = 5;
			// 
			// pnlSweep
			// 
			this.pnlSweep.Location = new System.Drawing.Point(524, 82);
			this.pnlSweep.Name = "pnlSweep";
			this.pnlSweep.Size = new System.Drawing.Size(36, 37);
			this.pnlSweep.TabIndex = 6;
			// 
			// Popup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 129);
			this.ControlBox = false;
			this.Controls.Add(this.pnlSweep);
			this.Controls.Add(this.pnlContent);
			this.Controls.Add(this.pnlAccentBorder);
			this.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(560, 320);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(560, 50);
			this.Name = "Popup";
			this.Opacity = 0D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FEmergente";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Popup_FormClosed);
			this.Shown += new System.EventHandler(this.Popup_Shown);
			this.pnlContent.ResumeLayout(false);
			this.pnlContent.PerformLayout();
			this.pnlText.ResumeLayout(false);
			this.pnlText.PerformLayout();
			this.pnlTitle.ResumeLayout(false);
			this.pnlTitle.PerformLayout();
			this.pnlIcon.ResumeLayout(false);
			this.pnlIcon.PerformLayout();
			this.tlpIcon.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlContent;
		private System.Windows.Forms.Panel pnlText;
		private System.Windows.Forms.Panel pnlMessageLeftPadding;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlIcon;
		private System.Windows.Forms.Panel pnlAccentBorder;
		private System.Windows.Forms.TableLayoutPanel tlpIcon;
		private System.Windows.Forms.PictureBox pbIcon;
		private System.Windows.Forms.Panel pnlSweep;
		private System.Windows.Forms.Panel pnlMessageBottomPadding;
	}
}