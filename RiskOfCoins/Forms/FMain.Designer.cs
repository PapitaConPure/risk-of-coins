namespace RiskOfCoins.Forms {
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.pnlCmbUser = new System.Windows.Forms.Panel();
			this.cmbUser = new ControLib.SleekComboBox();
			this.tlpCenter = new System.Windows.Forms.TableLayoutPanel();
			this.pnlForm = new System.Windows.Forms.Panel();
			this.pnlRowInputQuit = new System.Windows.Forms.Panel();
			this.btnQuit = new ControLib.SleekButton();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnLoadProfiles = new ControLib.SleekButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pnlRowInputLunarCoins = new System.Windows.Forms.Panel();
			this.tbLunarCoins = new ControLib.SleekTextBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.btnCoinsMinus100 = new ControLib.SleekButton();
			this.btnCoinsMinus10 = new ControLib.SleekButton();
			this.btnCoinsPlus10 = new ControLib.SleekButton();
			this.btnCoinsPlus100 = new ControLib.SleekButton();
			this.btnCoinsMax = new ControLib.SleekButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnBackupProfilesAndApplyCoins = new ControLib.SleekButton();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblLunarCoins = new System.Windows.Forms.Label();
			this.pnlRowSplit1 = new System.Windows.Forms.Panel();
			this.pnlRowLabelPath = new System.Windows.Forms.Panel();
			this.lblPath = new System.Windows.Forms.Label();
			this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
			this.pnlRowInputPath.SuspendLayout();
			this.pnlCmbUser.SuspendLayout();
			this.tlpCenter.SuspendLayout();
			this.pnlForm.SuspendLayout();
			this.pnlRowInputQuit.SuspendLayout();
			this.panel4.SuspendLayout();
			this.pnlRowInputLunarCoins.SuspendLayout();
			this.panel5.SuspendLayout();
			this.pnlRowLabelPath.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbPath
			// 
			this.tbPath.BackColor = System.Drawing.Color.White;
			this.tbPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(81)))));
			this.tbPath.BorderRadius = 40F;
			this.tbPath.BorderSize = 3F;
			this.tbPath.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbPath.FocusColor = System.Drawing.Color.Empty;
			this.tbPath.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tbPath.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbPath.InputColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.tbPath.InputText = "";
			this.tbPath.Location = new System.Drawing.Point(10, 0);
			this.tbPath.MinimumSize = new System.Drawing.Size(27, 31);
			this.tbPath.Multiline = false;
			this.tbPath.Name = "tbPath";
			this.tbPath.PasswordChar = '\0';
			this.tbPath.PercentualRadius = true;
			this.tbPath.PlaceHolder = "Steam \"userdata\" path";
			this.tbPath.PlaceHolderColor = System.Drawing.Color.DimGray;
			this.tbPath.ReadOnly = false;
			this.tbPath.SelectAllOnClick = true;
			this.tbPath.Size = new System.Drawing.Size(334, 40);
			this.tbPath.Style = ControLib.SleekTextBox.TextBoxStyle.RoundRect;
			this.tbPath.TabIndex = 0;
			this.tbPath.TabStop = false;
			this.tbPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.tbPath.WordWrap = true;
			// 
			// btnPath
			// 
			this.btnPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(81)))));
			this.btnPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(81)))));
			this.btnPath.BorderRadius = 40F;
			this.btnPath.BorderSize = 0F;
			this.btnPath.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnPath.FlatAppearance.BorderSize = 0;
			this.btnPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPath.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnPath.Location = new System.Drawing.Point(350, 0);
			this.btnPath.Margin = new System.Windows.Forms.Padding(0);
			this.btnPath.Name = "btnPath";
			this.btnPath.PercentualRadius = true;
			this.btnPath.Size = new System.Drawing.Size(42, 40);
			this.btnPath.TabIndex = 2;
			this.btnPath.Text = "...";
			this.btnPath.UseVisualStyleBackColor = false;
			this.btnPath.Click += new System.EventHandler(this.BtnPath_Click);
			// 
			// pnlRowInputPath
			// 
			this.pnlRowInputPath.Controls.Add(this.tbPath);
			this.pnlRowInputPath.Controls.Add(this.panel2);
			this.pnlRowInputPath.Controls.Add(this.btnPath);
			this.pnlRowInputPath.Controls.Add(this.panel6);
			this.pnlRowInputPath.Controls.Add(this.pnlCmbUser);
			this.pnlRowInputPath.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRowInputPath.Location = new System.Drawing.Point(3, 23);
			this.pnlRowInputPath.Margin = new System.Windows.Forms.Padding(0);
			this.pnlRowInputPath.Name = "pnlRowInputPath";
			this.pnlRowInputPath.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.pnlRowInputPath.Size = new System.Drawing.Size(710, 40);
			this.pnlRowInputPath.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(344, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(6, 40);
			this.panel2.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel6.Location = new System.Drawing.Point(392, 0);
			this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(20, 40);
			this.panel6.TabIndex = 3;
			// 
			// pnlCmbUser
			// 
			this.pnlCmbUser.Controls.Add(this.cmbUser);
			this.pnlCmbUser.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlCmbUser.Location = new System.Drawing.Point(412, 0);
			this.pnlCmbUser.Name = "pnlCmbUser";
			this.pnlCmbUser.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.pnlCmbUser.Size = new System.Drawing.Size(288, 40);
			this.pnlCmbUser.TabIndex = 4;
			// 
			// cmbUser
			// 
			this.cmbUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbUser.BorderColor = System.Drawing.Color.Empty;
			this.cmbUser.BorderRadius = 40F;
			this.cmbUser.BorderSize = 0;
			this.cmbUser.DisplayText = "Choose a Steam User...";
			this.cmbUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUser.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.cmbUser.ForeColor = System.Drawing.Color.White;
			this.cmbUser.IconColor = System.Drawing.Color.WhiteSmoke;
			this.cmbUser.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(81)))));
			this.cmbUser.ListTextColor = System.Drawing.Color.WhiteSmoke;
			this.cmbUser.Location = new System.Drawing.Point(0, 2);
			this.cmbUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmbUser.MinimumSize = new System.Drawing.Size(171, 31);
			this.cmbUser.Name = "cmbUser";
			this.cmbUser.PercentualRadius = true;
			this.cmbUser.Size = new System.Drawing.Size(288, 36);
			this.cmbUser.TabIndex = 0;
			this.cmbUser.OnSelectedIndexChanged += new System.EventHandler(this.CmbUser_OnSelectedIndexChanged);
			// 
			// tlpCenter
			// 
			this.tlpCenter.ColumnCount = 1;
			this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpCenter.Controls.Add(this.pnlForm, 0, 1);
			this.tlpCenter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpCenter.Location = new System.Drawing.Point(0, 0);
			this.tlpCenter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.tlpCenter.Name = "tlpCenter";
			this.tlpCenter.RowCount = 3;
			this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCenter.Size = new System.Drawing.Size(716, 317);
			this.tlpCenter.TabIndex = 3;
			// 
			// pnlForm
			// 
			this.pnlForm.AutoSize = true;
			this.pnlForm.Controls.Add(this.pnlRowInputQuit);
			this.pnlForm.Controls.Add(this.panel4);
			this.pnlForm.Controls.Add(this.panel3);
			this.pnlForm.Controls.Add(this.pnlRowInputLunarCoins);
			this.pnlForm.Controls.Add(this.panel5);
			this.pnlForm.Controls.Add(this.pnlRowSplit1);
			this.pnlForm.Controls.Add(this.pnlRowInputPath);
			this.pnlForm.Controls.Add(this.pnlRowLabelPath);
			this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlForm.Location = new System.Drawing.Point(0, 10);
			this.pnlForm.Margin = new System.Windows.Forms.Padding(0);
			this.pnlForm.Name = "pnlForm";
			this.pnlForm.Padding = new System.Windows.Forms.Padding(3);
			this.pnlForm.Size = new System.Drawing.Size(716, 296);
			this.pnlForm.TabIndex = 3;
			// 
			// pnlRowInputQuit
			// 
			this.pnlRowInputQuit.Controls.Add(this.btnQuit);
			this.pnlRowInputQuit.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRowInputQuit.Location = new System.Drawing.Point(3, 253);
			this.pnlRowInputQuit.Margin = new System.Windows.Forms.Padding(0);
			this.pnlRowInputQuit.Name = "pnlRowInputQuit";
			this.pnlRowInputQuit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.pnlRowInputQuit.Size = new System.Drawing.Size(710, 40);
			this.pnlRowInputQuit.TabIndex = 7;
			// 
			// btnQuit
			// 
			this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
			this.btnQuit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.btnQuit.BorderRadius = 40F;
			this.btnQuit.BorderSize = 0F;
			this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnQuit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnQuit.FlatAppearance.BorderSize = 0;
			this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuit.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnQuit.Location = new System.Drawing.Point(10, 0);
			this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.PercentualRadius = true;
			this.btnQuit.Size = new System.Drawing.Size(690, 40);
			this.btnQuit.TabIndex = 0;
			this.btnQuit.Text = "Quit";
			this.btnQuit.UseVisualStyleBackColor = false;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnLoadProfiles);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(3, 203);
			this.panel4.Margin = new System.Windows.Forms.Padding(0);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
			this.panel4.Size = new System.Drawing.Size(710, 50);
			this.panel4.TabIndex = 6;
			// 
			// btnLoadProfiles
			// 
			this.btnLoadProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
			this.btnLoadProfiles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(120)))), ((int)(((byte)(153)))));
			this.btnLoadProfiles.BorderRadius = 40F;
			this.btnLoadProfiles.BorderSize = 0F;
			this.btnLoadProfiles.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnLoadProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLoadProfiles.FlatAppearance.BorderSize = 0;
			this.btnLoadProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoadProfiles.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnLoadProfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnLoadProfiles.Location = new System.Drawing.Point(10, 0);
			this.btnLoadProfiles.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.btnLoadProfiles.Name = "btnLoadProfiles";
			this.btnLoadProfiles.PercentualRadius = true;
			this.btnLoadProfiles.Size = new System.Drawing.Size(690, 40);
			this.btnLoadProfiles.TabIndex = 0;
			this.btnLoadProfiles.Text = "Revert to Last Backup?";
			this.btnLoadProfiles.UseVisualStyleBackColor = false;
			this.btnLoadProfiles.Click += new System.EventHandler(this.BtnLoadProfiles_Click);
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(3, 163);
			this.panel3.Margin = new System.Windows.Forms.Padding(0);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 40);
			this.panel3.Size = new System.Drawing.Size(710, 40);
			this.panel3.TabIndex = 5;
			// 
			// pnlRowInputLunarCoins
			// 
			this.pnlRowInputLunarCoins.Controls.Add(this.tbLunarCoins);
			this.pnlRowInputLunarCoins.Controls.Add(this.panel7);
			this.pnlRowInputLunarCoins.Controls.Add(this.btnCoinsMinus100);
			this.pnlRowInputLunarCoins.Controls.Add(this.btnCoinsMinus10);
			this.pnlRowInputLunarCoins.Controls.Add(this.btnCoinsPlus10);
			this.pnlRowInputLunarCoins.Controls.Add(this.btnCoinsPlus100);
			this.pnlRowInputLunarCoins.Controls.Add(this.btnCoinsMax);
			this.pnlRowInputLunarCoins.Controls.Add(this.panel1);
			this.pnlRowInputLunarCoins.Controls.Add(this.btnBackupProfilesAndApplyCoins);
			this.pnlRowInputLunarCoins.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRowInputLunarCoins.Location = new System.Drawing.Point(3, 123);
			this.pnlRowInputLunarCoins.Margin = new System.Windows.Forms.Padding(0);
			this.pnlRowInputLunarCoins.Name = "pnlRowInputLunarCoins";
			this.pnlRowInputLunarCoins.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.pnlRowInputLunarCoins.Size = new System.Drawing.Size(710, 40);
			this.pnlRowInputLunarCoins.TabIndex = 4;
			// 
			// tbLunarCoins
			// 
			this.tbLunarCoins.BackColor = System.Drawing.Color.White;
			this.tbLunarCoins.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(81)))));
			this.tbLunarCoins.BorderRadius = 40F;
			this.tbLunarCoins.BorderSize = 3F;
			this.tbLunarCoins.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbLunarCoins.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbLunarCoins.FocusColor = System.Drawing.Color.Empty;
			this.tbLunarCoins.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tbLunarCoins.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbLunarCoins.InputColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.tbLunarCoins.InputText = "";
			this.tbLunarCoins.Location = new System.Drawing.Point(10, 0);
			this.tbLunarCoins.MinimumSize = new System.Drawing.Size(27, 31);
			this.tbLunarCoins.Multiline = false;
			this.tbLunarCoins.Name = "tbLunarCoins";
			this.tbLunarCoins.PasswordChar = '\0';
			this.tbLunarCoins.PercentualRadius = true;
			this.tbLunarCoins.PlaceHolder = "Amount";
			this.tbLunarCoins.PlaceHolderColor = System.Drawing.Color.DimGray;
			this.tbLunarCoins.ReadOnly = false;
			this.tbLunarCoins.SelectAllOnClick = true;
			this.tbLunarCoins.Size = new System.Drawing.Size(94, 40);
			this.tbLunarCoins.Style = ControLib.SleekTextBox.TextBoxStyle.RoundRect;
			this.tbLunarCoins.TabIndex = 0;
			this.tbLunarCoins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbLunarCoins.WordWrap = true;
			// 
			// panel7
			// 
			this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel7.Location = new System.Drawing.Point(104, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(6, 40);
			this.panel7.TabIndex = 10;
			// 
			// btnCoinsMinus100
			// 
			this.btnCoinsMinus100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
			this.btnCoinsMinus100.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.btnCoinsMinus100.BorderRadius = 40F;
			this.btnCoinsMinus100.BorderSize = 0F;
			this.btnCoinsMinus100.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCoinsMinus100.FlatAppearance.BorderSize = 0;
			this.btnCoinsMinus100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCoinsMinus100.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCoinsMinus100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnCoinsMinus100.Location = new System.Drawing.Point(110, 0);
			this.btnCoinsMinus100.Name = "btnCoinsMinus100";
			this.btnCoinsMinus100.PercentualRadius = true;
			this.btnCoinsMinus100.Size = new System.Drawing.Size(56, 40);
			this.btnCoinsMinus100.TabIndex = 1;
			this.btnCoinsMinus100.Text = "-100";
			this.btnCoinsMinus100.UseVisualStyleBackColor = false;
			this.btnCoinsMinus100.Click += new System.EventHandler(this.BtnCoinsMinus100_Click);
			// 
			// btnCoinsMinus10
			// 
			this.btnCoinsMinus10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
			this.btnCoinsMinus10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.btnCoinsMinus10.BorderRadius = 40F;
			this.btnCoinsMinus10.BorderSize = 0F;
			this.btnCoinsMinus10.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCoinsMinus10.FlatAppearance.BorderSize = 0;
			this.btnCoinsMinus10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCoinsMinus10.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCoinsMinus10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnCoinsMinus10.Location = new System.Drawing.Point(166, 0);
			this.btnCoinsMinus10.Name = "btnCoinsMinus10";
			this.btnCoinsMinus10.PercentualRadius = true;
			this.btnCoinsMinus10.Size = new System.Drawing.Size(56, 40);
			this.btnCoinsMinus10.TabIndex = 2;
			this.btnCoinsMinus10.Text = "-10";
			this.btnCoinsMinus10.UseVisualStyleBackColor = false;
			this.btnCoinsMinus10.Click += new System.EventHandler(this.BtnCoinsMinus10_Click);
			// 
			// btnCoinsPlus10
			// 
			this.btnCoinsPlus10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
			this.btnCoinsPlus10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.btnCoinsPlus10.BorderRadius = 40F;
			this.btnCoinsPlus10.BorderSize = 0F;
			this.btnCoinsPlus10.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCoinsPlus10.FlatAppearance.BorderSize = 0;
			this.btnCoinsPlus10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCoinsPlus10.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCoinsPlus10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnCoinsPlus10.Location = new System.Drawing.Point(222, 0);
			this.btnCoinsPlus10.Name = "btnCoinsPlus10";
			this.btnCoinsPlus10.PercentualRadius = true;
			this.btnCoinsPlus10.Size = new System.Drawing.Size(56, 40);
			this.btnCoinsPlus10.TabIndex = 3;
			this.btnCoinsPlus10.Text = "+10";
			this.btnCoinsPlus10.UseVisualStyleBackColor = false;
			this.btnCoinsPlus10.Click += new System.EventHandler(this.BtnCoinsPlus10_Click);
			// 
			// btnCoinsPlus100
			// 
			this.btnCoinsPlus100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
			this.btnCoinsPlus100.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.btnCoinsPlus100.BorderRadius = 40F;
			this.btnCoinsPlus100.BorderSize = 0F;
			this.btnCoinsPlus100.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCoinsPlus100.FlatAppearance.BorderSize = 0;
			this.btnCoinsPlus100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCoinsPlus100.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCoinsPlus100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnCoinsPlus100.Location = new System.Drawing.Point(278, 0);
			this.btnCoinsPlus100.Name = "btnCoinsPlus100";
			this.btnCoinsPlus100.PercentualRadius = true;
			this.btnCoinsPlus100.Size = new System.Drawing.Size(56, 40);
			this.btnCoinsPlus100.TabIndex = 4;
			this.btnCoinsPlus100.Text = "+100";
			this.btnCoinsPlus100.UseVisualStyleBackColor = false;
			this.btnCoinsPlus100.Click += new System.EventHandler(this.BtnCoinsPlus100_Click);
			// 
			// btnCoinsMax
			// 
			this.btnCoinsMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
			this.btnCoinsMax.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.btnCoinsMax.BorderRadius = 40F;
			this.btnCoinsMax.BorderSize = 0F;
			this.btnCoinsMax.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCoinsMax.FlatAppearance.BorderSize = 0;
			this.btnCoinsMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCoinsMax.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCoinsMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnCoinsMax.Location = new System.Drawing.Point(334, 0);
			this.btnCoinsMax.Name = "btnCoinsMax";
			this.btnCoinsMax.PercentualRadius = true;
			this.btnCoinsMax.Size = new System.Drawing.Size(58, 40);
			this.btnCoinsMax.TabIndex = 5;
			this.btnCoinsMax.Text = "Max";
			this.btnCoinsMax.UseVisualStyleBackColor = false;
			this.btnCoinsMax.Click += new System.EventHandler(this.BtnCoinsMax_Click);
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(392, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(20, 40);
			this.panel1.TabIndex = 6;
			// 
			// btnBackupProfilesAndApplyCoins
			// 
			this.btnBackupProfilesAndApplyCoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(81)))));
			this.btnBackupProfilesAndApplyCoins.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(69)))), ((int)(((byte)(86)))));
			this.btnBackupProfilesAndApplyCoins.BorderRadius = 40F;
			this.btnBackupProfilesAndApplyCoins.BorderSize = 0F;
			this.btnBackupProfilesAndApplyCoins.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnBackupProfilesAndApplyCoins.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnBackupProfilesAndApplyCoins.FlatAppearance.BorderSize = 0;
			this.btnBackupProfilesAndApplyCoins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBackupProfilesAndApplyCoins.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnBackupProfilesAndApplyCoins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.btnBackupProfilesAndApplyCoins.Location = new System.Drawing.Point(412, 0);
			this.btnBackupProfilesAndApplyCoins.Name = "btnBackupProfilesAndApplyCoins";
			this.btnBackupProfilesAndApplyCoins.PercentualRadius = true;
			this.btnBackupProfilesAndApplyCoins.Size = new System.Drawing.Size(288, 40);
			this.btnBackupProfilesAndApplyCoins.TabIndex = 7;
			this.btnBackupProfilesAndApplyCoins.Text = "Backup RoR2 Profiles and Apply";
			this.btnBackupProfilesAndApplyCoins.UseVisualStyleBackColor = false;
			this.btnBackupProfilesAndApplyCoins.Click += new System.EventHandler(this.BtnBackupProfilesAndApplyCoins_Click);
			// 
			// panel5
			// 
			this.panel5.AutoSize = true;
			this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel5.Controls.Add(this.lblLunarCoins);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(3, 103);
			this.panel5.Margin = new System.Windows.Forms.Padding(0);
			this.panel5.Name = "panel5";
			this.panel5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.panel5.Size = new System.Drawing.Size(710, 20);
			this.panel5.TabIndex = 3;
			// 
			// lblLunarCoins
			// 
			this.lblLunarCoins.AutoSize = true;
			this.lblLunarCoins.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblLunarCoins.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lblLunarCoins.Location = new System.Drawing.Point(10, 0);
			this.lblLunarCoins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLunarCoins.Name = "lblLunarCoins";
			this.lblLunarCoins.Size = new System.Drawing.Size(85, 20);
			this.lblLunarCoins.TabIndex = 0;
			this.lblLunarCoins.Text = "Lunar Coins";
			this.lblLunarCoins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlRowSplit1
			// 
			this.pnlRowSplit1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRowSplit1.Location = new System.Drawing.Point(3, 63);
			this.pnlRowSplit1.Margin = new System.Windows.Forms.Padding(0);
			this.pnlRowSplit1.Name = "pnlRowSplit1";
			this.pnlRowSplit1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.pnlRowSplit1.Size = new System.Drawing.Size(710, 40);
			this.pnlRowSplit1.TabIndex = 2;
			// 
			// pnlRowLabelPath
			// 
			this.pnlRowLabelPath.AutoSize = true;
			this.pnlRowLabelPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlRowLabelPath.Controls.Add(this.lblPath);
			this.pnlRowLabelPath.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRowLabelPath.Location = new System.Drawing.Point(3, 3);
			this.pnlRowLabelPath.Margin = new System.Windows.Forms.Padding(0);
			this.pnlRowLabelPath.Name = "pnlRowLabelPath";
			this.pnlRowLabelPath.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.pnlRowLabelPath.Size = new System.Drawing.Size(710, 20);
			this.pnlRowLabelPath.TabIndex = 0;
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPath.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lblPath.Location = new System.Drawing.Point(10, 0);
			this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnQuit;
			this.ClientSize = new System.Drawing.Size(716, 317);
			this.Controls.Add(this.tlpCenter);
			this.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(732, 356);
			this.Name = "FMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Risk of Coins";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPrincipal_FormClosed);
			this.Load += new System.EventHandler(this.FPrincipal_Load);
			this.pnlRowInputPath.ResumeLayout(false);
			this.pnlCmbUser.ResumeLayout(false);
			this.tlpCenter.ResumeLayout(false);
			this.tlpCenter.PerformLayout();
			this.pnlForm.ResumeLayout(false);
			this.pnlForm.PerformLayout();
			this.pnlRowInputQuit.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.pnlRowInputLunarCoins.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
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
		private System.Windows.Forms.Panel pnlRowInputQuit;
		private ControLib.SleekButton btnQuit;
		private System.Windows.Forms.FolderBrowserDialog fbdPath;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private ControLib.SleekButton btnCoinsMax;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label lblLunarCoins;
		private ControLib.SleekButton btnCoinsMinus100;
		private ControLib.SleekButton btnCoinsPlus100;
		private System.Windows.Forms.Panel panel4;
		private ControLib.SleekButton btnLoadProfiles;
		private System.Windows.Forms.Panel panel1;
		private ControLib.SleekButton btnBackupProfilesAndApplyCoins;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel pnlCmbUser;
		private ControLib.SleekComboBox cmbUser;
		private System.Windows.Forms.Panel panel6;
		private ControLib.SleekButton btnCoinsMinus10;
		private ControLib.SleekButton btnCoinsPlus10;
	}
}

