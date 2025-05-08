namespace WinFormsPopups {
	partial class Dialog {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog));
			this.pnlLeftBorder = new System.Windows.Forms.Panel();
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
			this.pnlCommitButtons = new System.Windows.Forms.Panel();
			this.tlpCommitButtons = new System.Windows.Forms.TableLayoutPanel();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.pnlSweep = new System.Windows.Forms.Panel();
			this.pnlContent.SuspendLayout();
			this.pnlText.SuspendLayout();
			this.pnlTitle.SuspendLayout();
			this.pnlIcon.SuspendLayout();
			this.tlpIcon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
			this.pnlCommitButtons.SuspendLayout();
			this.tlpCommitButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlBordeIzquierdo
			// 
			this.pnlLeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLeftBorder.Location = new System.Drawing.Point(0, 0);
			this.pnlLeftBorder.Name = "pnlBordeIzquierdo";
			this.pnlLeftBorder.Size = new System.Drawing.Size(6, 208);
			this.pnlLeftBorder.TabIndex = 8;
			// 
			// pnlContent
			// 
			this.pnlContent.Controls.Add(this.pnlText);
			this.pnlContent.Controls.Add(this.pnlIcon);
			this.pnlContent.Controls.Add(this.pnlCommitButtons);
			this.pnlContent.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContent.Location = new System.Drawing.Point(6, 0);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Padding = new System.Windows.Forms.Padding(10);
			this.pnlContent.Size = new System.Drawing.Size(615, 208);
			this.pnlContent.TabIndex = 0;
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
			this.pnlText.Size = new System.Drawing.Size(537, 146);
			this.pnlText.TabIndex = 1;
			// 
			// lblMessage
			// 
			this.lblMessage.AutoEllipsis = true;
			this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMessage.Location = new System.Drawing.Point(5, 55);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(532, 67);
			this.lblMessage.TabIndex = 2;
			this.lblMessage.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque ullamcorper ultr" +
    "ices augue, eget egestas leo tincidunt nec.";
			// 
			// pnlMessageLeftPadding
			// 
			this.pnlMessageLeftPadding.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlMessageLeftPadding.Location = new System.Drawing.Point(0, 55);
			this.pnlMessageLeftPadding.Name = "pnlMessageLeftPadding";
			this.pnlMessageLeftPadding.Size = new System.Drawing.Size(5, 67);
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
			this.pnlTitle.Size = new System.Drawing.Size(537, 55);
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
			this.pnlMessageBottomPadding.Location = new System.Drawing.Point(0, 122);
			this.pnlMessageBottomPadding.Name = "pnlMessageBottomPadding";
			this.pnlMessageBottomPadding.Size = new System.Drawing.Size(537, 24);
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
			this.pnlIcon.Size = new System.Drawing.Size(58, 146);
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
			this.tlpIcon.Size = new System.Drawing.Size(48, 146);
			this.tlpIcon.TabIndex = 3;
			// 
			// pbIcon
			// 
			this.pbIcon.InitialImage = null;
			this.pbIcon.Location = new System.Drawing.Point(0, 49);
			this.pbIcon.Margin = new System.Windows.Forms.Padding(0);
			this.pbIcon.Name = "pbIcon";
			this.pbIcon.Size = new System.Drawing.Size(48, 48);
			this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbIcon.TabIndex = 0;
			this.pbIcon.TabStop = false;
			// 
			// pnlCommitButtons
			// 
			this.pnlCommitButtons.Controls.Add(this.tlpCommitButtons);
			this.pnlCommitButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlCommitButtons.Location = new System.Drawing.Point(10, 156);
			this.pnlCommitButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pnlCommitButtons.Name = "pnlCommitButtons";
			this.pnlCommitButtons.Size = new System.Drawing.Size(595, 42);
			this.pnlCommitButtons.TabIndex = 13;
			// 
			// tlpCommitButtons
			// 
			this.tlpCommitButtons.ColumnCount = 3;
			this.tlpCommitButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.35595F));
			this.tlpCommitButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.4221F));
			this.tlpCommitButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.22196F));
			this.tlpCommitButtons.Controls.Add(this.btn2, 1, 0);
			this.tlpCommitButtons.Controls.Add(this.btn3, 2, 0);
			this.tlpCommitButtons.Controls.Add(this.btn1, 0, 0);
			this.tlpCommitButtons.Dock = System.Windows.Forms.DockStyle.Right;
			this.tlpCommitButtons.Location = new System.Drawing.Point(202, 0);
			this.tlpCommitButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tlpCommitButtons.Name = "tlpCommitButtons";
			this.tlpCommitButtons.RowCount = 1;
			this.tlpCommitButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpCommitButtons.Size = new System.Drawing.Size(393, 42);
			this.tlpCommitButtons.TabIndex = 1;
			// 
			// btn2
			// 
			this.btn2.BackColor = System.Drawing.Color.Black;
			this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn2.FlatAppearance.BorderSize = 0;
			this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btn2.ForeColor = System.Drawing.Color.White;
			this.btn2.Location = new System.Drawing.Point(137, 0);
			this.btn2.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(125, 42);
			this.btn2.TabIndex = 1;
			this.btn2.Text = "B";
			this.btn2.UseVisualStyleBackColor = false;
			this.btn2.Click += new System.EventHandler(this.CommitButton_Click);
			// 
			// btn3
			// 
			this.btn3.BackColor = System.Drawing.Color.Black;
			this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn3.FlatAppearance.BorderSize = 0;
			this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btn3.ForeColor = System.Drawing.Color.White;
			this.btn3.Location = new System.Drawing.Point(268, 0);
			this.btn3.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(125, 42);
			this.btn3.TabIndex = 2;
			this.btn3.Text = "C";
			this.btn3.UseVisualStyleBackColor = false;
			this.btn3.Click += new System.EventHandler(this.CommitButton_Click);
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.Color.Black;
			this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn1.FlatAppearance.BorderSize = 0;
			this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btn1.ForeColor = System.Drawing.Color.White;
			this.btn1.Location = new System.Drawing.Point(6, 0);
			this.btn1.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(125, 42);
			this.btn1.TabIndex = 0;
			this.btn1.Text = "A";
			this.btn1.UseVisualStyleBackColor = false;
			this.btn1.Click += new System.EventHandler(this.CommitButton_Click);
			// 
			// pnlSweep
			// 
			this.pnlSweep.Location = new System.Drawing.Point(542, 108);
			this.pnlSweep.Name = "pnlSweep";
			this.pnlSweep.Size = new System.Drawing.Size(37, 37);
			this.pnlSweep.TabIndex = 9;
			// 
			// Dialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 208);
			this.Controls.Add(this.pnlSweep);
			this.Controls.Add(this.pnlContent);
			this.Controls.Add(this.pnlLeftBorder);
			this.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Dialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dialog_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dialog_FormClosed);
			this.Shown += new System.EventHandler(this.Dialog_Shown);
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
			this.pnlCommitButtons.ResumeLayout(false);
			this.tlpCommitButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlLeftBorder;
		private System.Windows.Forms.Panel pnlContent;
		private System.Windows.Forms.Panel pnlText;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Panel pnlMessageLeftPadding;
		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlMessageBottomPadding;
		private System.Windows.Forms.Panel pnlIcon;
		private System.Windows.Forms.TableLayoutPanel tlpIcon;
		private System.Windows.Forms.PictureBox pbIcon;
		private System.Windows.Forms.Panel pnlCommitButtons;
		private System.Windows.Forms.TableLayoutPanel tlpCommitButtons;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Panel pnlSweep;
	}
}