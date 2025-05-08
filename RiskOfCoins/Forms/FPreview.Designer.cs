
namespace RiskOfCoins {
	partial class FPreview {
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
			this.btnClose = new ControLib.SleekButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbPreview = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.btnClose.BorderRadius = 8F;
			this.btnClose.BorderSize = 2F;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnClose.Location = new System.Drawing.Point(10, 679);
			this.btnClose.Name = "btnClose";
			this.btnClose.PercentualRadius = false;
			this.btnClose.Size = new System.Drawing.Size(1330, 40);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tbPreview);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10);
			this.panel1.Size = new System.Drawing.Size(1350, 729);
			this.panel1.TabIndex = 1;
			// 
			// tbPreview
			// 
			this.tbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbPreview.Location = new System.Drawing.Point(10, 10);
			this.tbPreview.MinimumSize = new System.Drawing.Size(4, 60);
			this.tbPreview.Multiline = true;
			this.tbPreview.Name = "tbPreview";
			this.tbPreview.ReadOnly = true;
			this.tbPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbPreview.Size = new System.Drawing.Size(1330, 659);
			this.tbPreview.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(10, 669);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1330, 10);
			this.panel2.TabIndex = 2;
			// 
			// FPreview
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(1350, 729);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FPreview";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Profile";
			this.TopMost = true;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ControLib.SleekButton btnClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbPreview;
		private System.Windows.Forms.Panel panel2;
	}
}