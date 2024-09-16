
namespace RiskOfCoins {
	partial class FMain {
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
			this.tbPath = new ControLib.SleekTextBox();
			this.btnPath = new ControLib.SleekButton();
			this.pnlRowInputPath = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.cmbUser = new ControLib.SleekComboBox();
			this.tlpCenter = new System.Windows.Forms.TableLayoutPanel();
			this.pnlForm = new System.Windows.Forms.Panel();
			this.pnlRowInputQuit = new System.Windows.Forms.Panel();
			this.btnQuit = new ControLib.SleekButton();
			this.pnlRowSplit3 = new System.Windows.Forms.Panel();
			this.pnlRowInputLunarCoins = new System.Windows.Forms.Panel();
			this.tbLunarCoins = new ControLib.SleekTextBox();
			this.lblLunarCoins = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnApplyCoins = new ControLib.SleekButton();
			this.pnlRowSplit2 = new System.Windows.Forms.Panel();
			this.pnlRowInputProfiles = new System.Windows.Forms.Panel();
			this.tlpProfiles = new System.Windows.Forms.TableLayoutPanel();
			this.btnLoadProfiles = new ControLib.SleekButton();
			this.btnSaveProfiles = new ControLib.SleekButton();
			this.pnlRowLabelProfiles = new System.Windows.Forms.Panel();
			this.lblProfiles = new System.Windows.Forms.Label();
			this.pnlRowSplit1 = new System.Windows.Forms.Panel();
			this.pnlRowLabelPath = new System.Windows.Forms.Panel();
			this.lblPath = new System.Windows.Forms.Label();
			this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
			this.pnlRowInputPath.SuspendLayout();
			this.tlpCenter.SuspendLayout();
			this.pnlForm.SuspendLayout();
			this.pnlRowInputQuit.SuspendLayout();
			this.pnlRowInputLunarCoins.SuspendLayout();
			this.pnlRowInputProfiles.SuspendLayout();
			this.tlpProfiles.SuspendLayout();
			this.pnlRowLabelProfiles.SuspendLayout();
			this.pnlRowLabelPath.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbPath
			// 
			this.tbPath.BackColor = System.Drawing.SystemColors.Window;
			this.tbPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.tbPath.BorderRadius = 40F;
			this.tbPath.BorderSize = 3F;
			this.tbPath.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbPath.FocusColor = System.Drawing.Color.Empty;
			this.tbPath.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tbPath.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbPath.InputColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.tbPath.InputText = "";
			this.tbPath.Location = new System.Drawing.Point(8, 8);
			this.tbPath.MinimumSize = new System.Drawing.Size(20, 20);
			this.tbPath.Multiline = false;
			this.tbPath.Name = "tbPath";
			this.tbPath.PasswordChar = '\0';
			this.tbPath.PercentualRadius = true;
			this.tbPath.PlaceHolder = "Steam \"userdata\" path";
			this.tbPath.PlaceHolderColor = System.Drawing.Color.DimGray;
			this.tbPath.ReadOnly = false;
			this.tbPath.SelectAllOnClick = true;
			this.tbPath.Size = new System.Drawing.Size(220, 40);
			this.tbPath.Style = ControLib.SleekTextBox.TextBoxStyle.RoundRect;
			this.tbPath.TabIndex = 0;
			this.tbPath.TabStop = false;
			this.tbPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.tbPath.WordWrap = true;
			// 
			// btnPath
			// 
			this.btnPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.btnPath.BorderRadius = 40F;
			this.btnPath.BorderSize = 3F;
			this.btnPath.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnPath.FlatAppearance.BorderSize = 0;
			this.btnPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPath.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnPath.Location = new System.Drawing.Point(228, 8);
			this.btnPath.Name = "btnPath";
			this.btnPath.PercentualRadius = true;
			this.btnPath.Size = new System.Drawing.Size(42, 40);
			this.btnPath.TabIndex = 1;
			this.btnPath.Text = "...";
			this.btnPath.UseVisualStyleBackColor = false;
			this.btnPath.Click += new System.EventHandler(this.BtnPath_Click);
			// 
			// pnlRowInputPath
			// 
			this.pnlRowInputPath.Controls.Add(this.tbPath);
			this.pnlRowInputPath.Controls.Add(this.btnPath);
			this.pnlRowInputPath.Controls.Add(this.panel6);
			this.pnlRowInputPath.Controls.Add(this.cmbUser);
			this.pnlRowInputPath.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRowInputPath.Location = new System.Drawing.Point(2, 30);
			this.pnlRowInputPath.Name = "pnlRowInputPath";
			this.pnlRowInputPath.Padding = new System.Windows.Forms.Padding(8);
			this.pnlRowInputPath.Size = new System.Drawing.Size(534, 56);
			this.pnlRowInputPath.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel6.Location = new System.Drawing.Point(270, 8);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(20, 40);
			this.panel6.TabIndex = 6;
			// 
			// cmbUser
			// 
			this.cmbUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbUser.BackColor = System.Drawing.Color.WhiteSmoke;
			this.cmbUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.cmbUser.BorderRadius = 40F;
			this.cmbUser.BorderSize = 3;
			this.cmbUser.DisplayText = "Choose a Steam User...";
			this.cmbUser.Dock = System.Windows.Forms.DockStyle.Right;
			this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUser.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.cmbUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.cmbUser.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.cmbUser.ListTextColor = System.Drawing.Color.WhiteSmoke;
			this.cmbUser.Location = new System.Drawing.Point(290, 8);
			this.cmbUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmbUser.MinimumSize = new System.Drawing.Size(128, 20);
			this.cmbUser.Name = "cmbUser";
			this.cmbUser.PercentualRadius = true;
			this.cmbUser.Size = new System.Drawing.Size(236, 40);
			this.cmbUser.TabIndex = 7;
			this.cmbUser.OnSelectedIndexChanged += new System.EventHandler(this.CmbUser_OnSelectedIndexChanged);
			// 
			// tlpCenter
			// 
			this.tlpCenter.ColumnCount = 1;
			this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpCenter.Controls.Add(this.pnlForm, 0, 1);
			this.tlpCenter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpCenter.Location = new System.Drawing.Point(0, 0);
			this.tlpCenter.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.tlpCenter.Name = "tlpCenter";
			this.tlpCenter.RowCount = 3;
			this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCenter.Size = new System.Drawing.Size(544, 400);
			this.tlpCenter.TabIndex = 3;
			// 
			// pnlForm
			// 
			this.pnlForm.AutoSize = true;
			this.pnlForm.Controls.Add(this.pnlRowInputQuit);
			this.pnlForm.Controls.Add(this.pnlRowSplit3);
			this.pnlForm.Controls.Add(this.pnlRowInputLunarCoins);
			this.pnlForm.Controls.Add(this.pnlRowSplit2);
			this.pnlForm.Controls.Add(this.pnlRowInputProfiles);
			this.pnlForm.Controls.Add(this.pnlRowLabelProfiles);
			this.pnlForm.Controls.Add(this.pnlRowSplit1);
			this.pnlForm.Controls.Add(this.pnlRowInputPath);
			this.pnlForm.Controls.Add(this.pnlRowLabelPath);
			this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlForm.Location = new System.Drawing.Point(3, 16);
			this.pnlForm.Name = "pnlForm";
			this.pnlForm.Padding = new System.Windows.Forms.Padding(2);
			this.pnlForm.Size = new System.Drawing.Size(538, 368);
			this.pnlForm.TabIndex = 3;
			// 
			// pnlRowInputQuit
			// 
			this.pnlRowInputQuit.Controls.Add(this.btnQuit);
			this.pnlRowInputQuit.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRowInputQuit.Location = new System.Drawing.Point(2, 310);
			this.pnlRowInputQuit.Name = "pnlRowInputQuit";
			this.pnlRowInputQuit.Padding = new System.Windows.Forms.Padding(8);
			this.pnlRowInputQuit.Size = new System.Drawing.Size(534, 56);
			this.pnlRowInputQuit.TabIndex = 8;
			// 
			// btnQuit
			// 
			this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnQuit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.btnQuit.BorderRadius = 40F;
			this.btnQuit.BorderSize = 3F;
			this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnQuit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnQuit.FlatAppearance.BorderSize = 0;
			this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuit.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnQuit.Location = new System.Drawing.Point(8, 8);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.PercentualRadius = true;
			this.btnQuit.Size = new System.Drawing.Size(518, 40);
			this.btnQuit.TabIndex = 0;
			this.btnQuit.Text = "Quit";
			this.btnQuit.UseVisualStyleBackColor = false;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
			// 
			// pnlRowSplit3
			// 
			this.pnlRowSplit3.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRowSplit3.Location = new System.Drawing.Point(2, 282);
			this.pnlRowSplit3.Name = "pnlRowSplit3";
			this.pnlRowSplit3.Padding = new System.Windows.Forms.Padding(8, 8, 8, 6);
			this.pnlRowSplit3.Size = new System.Drawing.Size(534, 28);
			this.pnlRowSplit3.TabIndex = 7;
			// 
			// pnlRowInputLunarCoins
			// 
			this.pnlRowInputLunarCoins.Controls.Add(this.tbLunarCoins);
			this.pnlRowInputLunarCoins.Controls.Add(this.lblLunarCoins);
			this.pnlRowInputLunarCoins.Controls.Add(this.panel1);
			this.pnlRowInputLunarCoins.Controls.Add(this.btnApplyCoins);
			this.pnlRowInputLunarCoins.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRowInputLunarCoins.Enabled = false;
			this.pnlRowInputLunarCoins.Location = new System.Drawing.Point(2, 226);
			this.pnlRowInputLunarCoins.Name = "pnlRowInputLunarCoins";
			this.pnlRowInputLunarCoins.Padding = new System.Windows.Forms.Padding(8);
			this.pnlRowInputLunarCoins.Size = new System.Drawing.Size(534, 56);
			this.pnlRowInputLunarCoins.TabIndex = 6;
			// 
			// tbLunarCoins
			// 
			this.tbLunarCoins.BackColor = System.Drawing.SystemColors.Window;
			this.tbLunarCoins.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.tbLunarCoins.BorderRadius = 40F;
			this.tbLunarCoins.BorderSize = 3F;
			this.tbLunarCoins.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbLunarCoins.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbLunarCoins.FocusColor = System.Drawing.Color.Empty;
			this.tbLunarCoins.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tbLunarCoins.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbLunarCoins.InputColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.tbLunarCoins.InputText = "";
			this.tbLunarCoins.Location = new System.Drawing.Point(8, 8);
			this.tbLunarCoins.MinimumSize = new System.Drawing.Size(20, 20);
			this.tbLunarCoins.Multiline = false;
			this.tbLunarCoins.Name = "tbLunarCoins";
			this.tbLunarCoins.PasswordChar = '\0';
			this.tbLunarCoins.PercentualRadius = true;
			this.tbLunarCoins.PlaceHolder = "Amount";
			this.tbLunarCoins.PlaceHolderColor = System.Drawing.Color.DimGray;
			this.tbLunarCoins.ReadOnly = false;
			this.tbLunarCoins.SelectAllOnClick = true;
			this.tbLunarCoins.Size = new System.Drawing.Size(220, 40);
			this.tbLunarCoins.Style = ControLib.SleekTextBox.TextBoxStyle.RoundRect;
			this.tbLunarCoins.TabIndex = 0;
			this.tbLunarCoins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbLunarCoins.WordWrap = true;
			// 
			// lblLunarCoins
			// 
			this.lblLunarCoins.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblLunarCoins.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lblLunarCoins.Location = new System.Drawing.Point(228, 8);
			this.lblLunarCoins.Name = "lblLunarCoins";
			this.lblLunarCoins.Size = new System.Drawing.Size(86, 40);
			this.lblLunarCoins.TabIndex = 2;
			this.lblLunarCoins.Text = "Lunar Coins";
			this.lblLunarCoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(314, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(20, 40);
			this.panel1.TabIndex = 5;
			// 
			// btnApplyCoins
			// 
			this.btnApplyCoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(73)))), ((int)(((byte)(98)))));
			this.btnApplyCoins.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(69)))), ((int)(((byte)(86)))));
			this.btnApplyCoins.BorderRadius = 40F;
			this.btnApplyCoins.BorderSize = 3F;
			this.btnApplyCoins.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnApplyCoins.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnApplyCoins.FlatAppearance.BorderSize = 0;
			this.btnApplyCoins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnApplyCoins.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnApplyCoins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnApplyCoins.Location = new System.Drawing.Point(334, 8);
			this.btnApplyCoins.Name = "btnApplyCoins";
			this.btnApplyCoins.PercentualRadius = true;
			this.btnApplyCoins.Size = new System.Drawing.Size(192, 40);
			this.btnApplyCoins.TabIndex = 1;
			this.btnApplyCoins.Text = "Apply";
			this.btnApplyCoins.UseVisualStyleBackColor = false;
			this.btnApplyCoins.Click += new System.EventHandler(this.BtnApplyCoins_Click);
			// 
			// pnlRowSplit2
			// 
			this.pnlRowSplit2.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRowSplit2.Location = new System.Drawing.Point(2, 198);
			this.pnlRowSplit2.Name = "pnlRowSplit2";
			this.pnlRowSplit2.Padding = new System.Windows.Forms.Padding(8, 8, 8, 6);
			this.pnlRowSplit2.Size = new System.Drawing.Size(534, 28);
			this.pnlRowSplit2.TabIndex = 5;
			// 
			// pnlRowInputProfiles
			// 
			this.pnlRowInputProfiles.Controls.Add(this.tlpProfiles);
			this.pnlRowInputProfiles.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRowInputProfiles.Location = new System.Drawing.Point(2, 142);
			this.pnlRowInputProfiles.Name = "pnlRowInputProfiles";
			this.pnlRowInputProfiles.Padding = new System.Windows.Forms.Padding(5);
			this.pnlRowInputProfiles.Size = new System.Drawing.Size(534, 56);
			this.pnlRowInputProfiles.TabIndex = 4;
			// 
			// tlpProfiles
			// 
			this.tlpProfiles.ColumnCount = 2;
			this.tlpProfiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpProfiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpProfiles.Controls.Add(this.btnLoadProfiles, 0, 0);
			this.tlpProfiles.Controls.Add(this.btnSaveProfiles, 0, 0);
			this.tlpProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpProfiles.Location = new System.Drawing.Point(5, 5);
			this.tlpProfiles.Margin = new System.Windows.Forms.Padding(0);
			this.tlpProfiles.Name = "tlpProfiles";
			this.tlpProfiles.RowCount = 1;
			this.tlpProfiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpProfiles.Size = new System.Drawing.Size(524, 46);
			this.tlpProfiles.TabIndex = 0;
			// 
			// btnLoadProfiles
			// 
			this.btnLoadProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(148)))), ((int)(((byte)(191)))));
			this.btnLoadProfiles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(120)))), ((int)(((byte)(153)))));
			this.btnLoadProfiles.BorderRadius = 40F;
			this.btnLoadProfiles.BorderSize = 3F;
			this.btnLoadProfiles.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnLoadProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLoadProfiles.FlatAppearance.BorderSize = 0;
			this.btnLoadProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoadProfiles.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnLoadProfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnLoadProfiles.Location = new System.Drawing.Point(265, 3);
			this.btnLoadProfiles.Name = "btnLoadProfiles";
			this.btnLoadProfiles.PercentualRadius = true;
			this.btnLoadProfiles.Size = new System.Drawing.Size(256, 40);
			this.btnLoadProfiles.TabIndex = 1;
			this.btnLoadProfiles.Text = "Go Back to Latest Backup";
			this.btnLoadProfiles.UseVisualStyleBackColor = false;
			this.btnLoadProfiles.Click += new System.EventHandler(this.BtnLoadProfiles_Click);
			// 
			// btnSaveProfiles
			// 
			this.btnSaveProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(114)))));
			this.btnSaveProfiles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(158)))), ((int)(((byte)(98)))));
			this.btnSaveProfiles.BorderRadius = 40F;
			this.btnSaveProfiles.BorderSize = 3F;
			this.btnSaveProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSaveProfiles.Enabled = false;
			this.btnSaveProfiles.FlatAppearance.BorderSize = 0;
			this.btnSaveProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveProfiles.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnSaveProfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnSaveProfiles.Location = new System.Drawing.Point(3, 3);
			this.btnSaveProfiles.Name = "btnSaveProfiles";
			this.btnSaveProfiles.PercentualRadius = true;
			this.btnSaveProfiles.Size = new System.Drawing.Size(256, 40);
			this.btnSaveProfiles.TabIndex = 0;
			this.btnSaveProfiles.Text = "Backup RoR2 Profiles";
			this.btnSaveProfiles.UseVisualStyleBackColor = false;
			this.btnSaveProfiles.Click += new System.EventHandler(this.BtnSaveProfiles_Click);
			// 
			// pnlRowLabelProfiles
			// 
			this.pnlRowLabelProfiles.AutoSize = true;
			this.pnlRowLabelProfiles.Controls.Add(this.lblProfiles);
			this.pnlRowLabelProfiles.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRowLabelProfiles.Location = new System.Drawing.Point(2, 114);
			this.pnlRowLabelProfiles.Name = "pnlRowLabelProfiles";
			this.pnlRowLabelProfiles.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
			this.pnlRowLabelProfiles.Size = new System.Drawing.Size(534, 28);
			this.pnlRowLabelProfiles.TabIndex = 3;
			// 
			// lblProfiles
			// 
			this.lblProfiles.AutoSize = true;
			this.lblProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblProfiles.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lblProfiles.Location = new System.Drawing.Point(8, 8);
			this.lblProfiles.Name = "lblProfiles";
			this.lblProfiles.Size = new System.Drawing.Size(402, 20);
			this.lblProfiles.TabIndex = 1;
			this.lblProfiles.Text = "You must backup of your RoR2 profiles before editing coins";
			this.lblProfiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlRowSplit1
			// 
			this.pnlRowSplit1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRowSplit1.Location = new System.Drawing.Point(2, 86);
			this.pnlRowSplit1.Name = "pnlRowSplit1";
			this.pnlRowSplit1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 6);
			this.pnlRowSplit1.Size = new System.Drawing.Size(534, 28);
			this.pnlRowSplit1.TabIndex = 2;
			// 
			// pnlRowLabelPath
			// 
			this.pnlRowLabelPath.AutoSize = true;
			this.pnlRowLabelPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlRowLabelPath.Controls.Add(this.lblPath);
			this.pnlRowLabelPath.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRowLabelPath.Location = new System.Drawing.Point(2, 2);
			this.pnlRowLabelPath.Name = "pnlRowLabelPath";
			this.pnlRowLabelPath.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
			this.pnlRowLabelPath.Size = new System.Drawing.Size(534, 28);
			this.pnlRowLabelPath.TabIndex = 0;
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPath.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lblPath.Location = new System.Drawing.Point(8, 8);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(249, 20);
			this.lblPath.TabIndex = 0;
			this.lblPath.Text = "Steam \"userdata\" path + Steam user";
			this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fbdPath
			// 
			this.fbdPath.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this.fbdPath.ShowNewFolderButton = false;
			// 
			// FMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnQuit;
			this.ClientSize = new System.Drawing.Size(544, 400);
			this.Controls.Add(this.tlpCenter);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(690, 500);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(560, 416);
			this.Name = "FMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Risk of Coins";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPrincipal_FormClosed);
			this.Load += new System.EventHandler(this.FPrincipal_Load);
			this.pnlRowInputPath.ResumeLayout(false);
			this.tlpCenter.ResumeLayout(false);
			this.tlpCenter.PerformLayout();
			this.pnlForm.ResumeLayout(false);
			this.pnlForm.PerformLayout();
			this.pnlRowInputQuit.ResumeLayout(false);
			this.pnlRowInputLunarCoins.ResumeLayout(false);
			this.pnlRowInputProfiles.ResumeLayout(false);
			this.tlpProfiles.ResumeLayout(false);
			this.pnlRowLabelProfiles.ResumeLayout(false);
			this.pnlRowLabelProfiles.PerformLayout();
			this.pnlRowLabelPath.ResumeLayout(false);
			this.pnlRowLabelPath.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ControLib.SleekTextBox tbPath;
		private ControLib.SleekButton btnPath;
		private System.Windows.Forms.Panel pnlRowInputPath;
		private System.Windows.Forms.TableLayoutPanel tlpCenter;
		private System.Windows.Forms.Panel pnlForm;
		private System.Windows.Forms.Panel pnlRowInputLunarCoins;
		private ControLib.SleekTextBox tbLunarCoins;
		private System.Windows.Forms.Panel pnlRowLabelPath;
		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.Panel pnlRowSplit1;
		private System.Windows.Forms.Panel pnlRowInputProfiles;
		private System.Windows.Forms.Panel pnlRowInputQuit;
		private ControLib.SleekButton btnQuit;
		private System.Windows.Forms.Panel pnlRowSplit3;
		private ControLib.SleekButton btnApplyCoins;
		private System.Windows.Forms.Panel pnlRowSplit2;
		private System.Windows.Forms.TableLayoutPanel tlpProfiles;
		private ControLib.SleekButton btnLoadProfiles;
		private ControLib.SleekButton btnSaveProfiles;
		private System.Windows.Forms.Panel pnlRowLabelProfiles;
		private System.Windows.Forms.Label lblProfiles;
		private System.Windows.Forms.FolderBrowserDialog fbdPath;
		private System.Windows.Forms.Label lblLunarCoins;
		private System.Windows.Forms.Panel panel6;
		private ControLib.SleekComboBox cmbUser;
		private System.Windows.Forms.Panel panel1;
	}
}

