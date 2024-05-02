using System;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace RiskOfCoins {
	public partial class FMain: Form {
		private readonly CoinsWizard wizard;
		private readonly string dirRoot;
		private readonly string dirBackup;
		private readonly string dirBin;

		public FMain() {
			this.InitializeComponent();

			this.dirRoot = Application.StartupPath;
			this.dirBackup = Path.Combine(this.dirRoot, "Profile Backups");
			this.dirBin = Path.Combine(this.dirRoot, ".RoC");

			if(!Directory.Exists(this.dirBackup))
				Directory.CreateDirectory(this.dirBackup);

			#region Serialización
			FileStream fs = null;

			try {
				if(File.Exists(this.dirBin)) {
					fs = new FileStream(this.dirBin, FileMode.Open, FileAccess.Read);
					BinaryFormatter bf = new BinaryFormatter();
					this.wizard = bf.Deserialize(fs) as CoinsWizard;
				}
			} catch(IOException) {
				MessageBox.Show("Couldn't load previous application data. Delete the .RoC file", "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} catch(UnauthorizedAccessException) {
				MessageBox.Show("Couldn't load previous application data. Delete the .RoC file", "Permissions Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} catch(SerializationException) {
				MessageBox.Show("Couldn't load previous application data. Delete the .RoC file", "Serialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				if(fs != null)
					fs.Close();
			}

			if(this.wizard == null)
				this.wizard = new CoinsWizard();
			#endregion
		}

		private void FPrincipal_Load(object sender, EventArgs e) {
			string path = this.wizard.UserdataPath;
			string userId = this.wizard.UserId;
			string coins = (this.wizard.LunarCoins > 0) ? this.wizard.LunarCoins.ToString() : null;

			if(!string.IsNullOrEmpty(path))
				this.tbPath.InputText = path;

			if(!string.IsNullOrEmpty(userId))
				this.tbUserId.InputText = userId;

			if(!string.IsNullOrEmpty(coins))
				this.tbLunarCoins.InputText = coins;

			this.btnSaveProfiles.Enabled = this.wizard.IsUserdataPathValid();

			this.fbdPath.Description = string.Join("\n",
				"Select the Steam \"userdata\" folder.",
				"It's usually inside of 'C:\\Program Files (x86)\\'.",
				"You can also select the numbered folder in \"userdata\" here");
		}

		private void BtnPath_Click(object sender, EventArgs e) {
			string startPath = this.tbPath.InputText;
			if(!string.IsNullOrEmpty(startPath) && Directory.Exists(startPath))
				this.fbdPath.SelectedPath = startPath;

			if(this.fbdPath.ShowDialog()!= DialogResult.OK)
				return;

			this.wizard.UserdataPath = this.fbdPath.SelectedPath;

			if(!this.wizard.IsUserdataPathValid()) {
				MessageBox.Show("You must select a valid Steam \"userdata\" folder!", "Invalid \"userdata\" Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			this.tbPath.InputText = this.wizard.UserdataPath;

			if(this.wizard.TryMatchUserId())
				this.tbUserId.InputText = this.wizard.UserId;

			this.btnSaveProfiles.Enabled = true;
		}

		private void BtnSaveProfiles_Click(object sender, EventArgs e) {
			if(!this.ExpectPath()) {
				this.btnSaveProfiles.Enabled = false;
				return;
			}

			string profilesPath = this.wizard.GetFullPath();
			string[] profileFilenames = this.wizard.GetProfileFilenames();

			if(profileFilenames is null) {
				MessageBox.Show($"Couldn't find any profiles in path:{profilesPath}", "No Profiles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			List<string> successful = new List<string>();
			List<string> failed = new List<string>();

			foreach(string filename in profileFilenames) {
				string src  = Path.Combine(profilesPath,   filename);
				string dest = Path.Combine(this.dirBackup, filename);

				try {
					if(File.Exists(dest))
						File.Delete(dest);

					File.Copy(src, dest);

					successful.Add(filename);
				} catch(UnauthorizedAccessException) {
					MessageBox.Show($"Access denied while trying to copy profiles\n\nFrom:\n{src}\nTo:\n{dest}", "Access Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Error);
					failed.Add(filename);
				} catch(IOException ex) {
					MessageBox.Show($"Failed due to a system I/O issue\n\nFrom:\n{src}\nTo:\n{dest}\n\n{ex.Message}", "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					failed.Add(filename);
				} catch(Exception ex) {
					MessageBox.Show(ex.Message, "Unexpected Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
					failed.Add(filename);
				}
			}

			if(successful.Count > 0) {
				MessageBox.Show($"A backup has been performed for the following profiles:\n{string.Join("\n", successful)}", "Task Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);

				this.pnlRowInputLunarCoins.Enabled = failed.Count == 0;
			}

			if(failed.Count > 0)
				MessageBox.Show($"Couldn't backup the following profiles:\n{string.Join("\n", failed)}", "Task Finished", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void BtnLoadProfiles_Click(object sender, EventArgs e) {
			if(!this.ExpectPath()) {
				this.btnSaveProfiles.Enabled = false;
				return;
			}

			string profilesPath = this.wizard.GetFullPath();
			string[] profileFilenames = Directory.GetFiles(this.dirBackup);

			if(profileFilenames is null) {
				MessageBox.Show($"Couldn't find any profiles in path:{profilesPath}", "No Profiles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			List<string> successful = new List<string>();
			List<string> failed = new List<string>();

			foreach(string profilePath in profileFilenames) {
				string filename = profilePath.Split('\\').Last();

				string src  = Path.Combine(this.dirBackup, filename);
				string dest = Path.Combine(profilesPath,   filename);

				try {
					if(File.Exists(dest))
						File.Delete(dest);

					File.Copy(src, dest);

					successful.Add(filename);
				} catch(UnauthorizedAccessException) {
					MessageBox.Show($"Access denied while trying to copy profiles\n\nFrom:\n{src}\nTo:\n{dest}", "Access Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Error);
					failed.Add(filename);
				} catch(IOException ex) {
					MessageBox.Show($"Failed due to a system I/O issue\n\nFrom:\n{src}\nTo:\n{dest}\n\n{ex.Message}", "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					failed.Add(filename);
				} catch(Exception ex) {
					MessageBox.Show(ex.Message, "Unexpected Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
					failed.Add(filename);
				}
			}

			if(successful.Count > 0)
				MessageBox.Show($"The following profile backups were loaded:\n{string.Join("\n", successful)}", "Task Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);

			if(failed.Count > 0)
				MessageBox.Show($"Couldn't load the following profile backups:\n{string.Join("\n", failed)}", "Task Finished", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void BtnApplyCoins_Click(object sender, EventArgs e) {
			if(!this.ExpectPath())
				return;

			int coins;
			if(!int.TryParse(this.tbLunarCoins.InputText, out coins)) {
				if(long.TryParse(this.tbLunarCoins.InputText, out _)) {
					coins = int.MaxValue;
					this.tbLunarCoins.InputText = coins.ToString();
				} else {
					MessageBox.Show($"Lunar coins amount must be a positive integer up to {int.MaxValue:###,###,###,###}", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}

			if(coins < 0) {
				MessageBox.Show($"Lunar coins amount must be a positive integer up to {int.MaxValue:###,###,###,###}", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string profilesPath = this.wizard.GetFullPath();
			string[] profileFilenames = this.wizard.GetProfileFilenames();

			List<string> successful = new List<string>();
			List<string> failed = new List<string>();

			foreach(string filename in profileFilenames) {
				string profilePath = Path.Combine(profilesPath, filename);

				try {
					string profileData = File.ReadAllText(profilePath, Encoding.UTF8);
					string newProfileData = Regex.Replace(profileData, "<coins>(\\d+)<\\/coins>", $"<coins>{coins}</coins>");
					File.WriteAllText(profilePath, newProfileData, Encoding.UTF8);

					successful.Add(filename);
				} catch(UnauthorizedAccessException) {
					MessageBox.Show($"Access denied while trying to modify values in file:\n{profilePath}", "Access Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Error);
					failed.Add(filename);
				} catch(IOException ex) {
					MessageBox.Show($"Failed due to a system I/O issue:\n\n{profilePath}\n\n{ex.Message}", "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					failed.Add(filename);
				} catch(Exception ex) {
					MessageBox.Show(ex.Message, "Unexpected Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
					failed.Add(filename);
				}
			}

			if(successful.Count > 0)
				MessageBox.Show($"Modified profiles:\n{string.Join("\n", successful)}", "Task finished", MessageBoxButtons.OK, MessageBoxIcon.Information);

			if(failed.Count > 0)
				MessageBox.Show($"Couldn't modify the following profiles:\n{string.Join("\n", failed)}", "Task finished", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void BtnQuit_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void FPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
			if(this.wizard is null)
				return;

			FileStream fs = null;

			this.wizard.UserdataPath = this.tbPath.InputText;
			this.wizard.UserId = this.tbUserId.InputText;

			int lunarCoins;
			if(int.TryParse(this.tbLunarCoins.InputText, out lunarCoins))
				this.wizard.LunarCoins = lunarCoins;

			try {
				fs = new FileStream(this.dirBin, FileMode.OpenOrCreate, FileAccess.Write);
				BinaryFormatter bf = new BinaryFormatter();
				bf.Serialize(fs, this.wizard);
			} catch(IOException) {
				MessageBox.Show("Couldn't save current application data", "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} catch(UnauthorizedAccessException) {
				MessageBox.Show("Couldn't save current application data", "Permissions Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				if(fs != null)
					fs.Close();
			}
		}

		private bool ExpectPath() {
			if(!this.wizard.IsUserdataPathValid()) {
				MessageBox.Show("The selected Steam \"userdata\" path isn't a folder or doesn't exist!", "Invalid \"userdata\" Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.btnPath.Focus();
				this.tbPath.ResetText();
				return false;
			}

			if(!this.wizard.IsFullPathValid()) {
				MessageBox.Show("The user number should be a valid number. Check inside the \"userdata\" folder!", "Invalid user number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.btnPath.Focus();
				this.tbUserId.ResetText();
				return false;
			}

			return true;
		}
	}
}
