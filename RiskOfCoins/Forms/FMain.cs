using RiskOfCoins.Classes;
using System;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using WinFormsPopups;
using Localization;

namespace RiskOfCoins.Forms {
	public partial class FMain: Form {
		private readonly CoinsWizard wizard;
		private readonly string dirRoot;
		private readonly string dirBackup;
		private readonly string dirBin;

		public FMain() {
			this.InitializeComponent();

			#region Directorio
			this.dirRoot = Application.StartupPath;
			this.dirBackup = Path.Combine(this.dirRoot, "Profile Backups");
			this.dirBin = Path.Combine(this.dirRoot, ".RoC");

			if(!Directory.Exists(this.dirBackup))
				Directory.CreateDirectory(this.dirBackup);
			#endregion

			#region Serialización
			FileStream fs = null;

			try {
				if(File.Exists(this.dirBin)) {
					fs = new FileStream(this.dirBin, FileMode.Open, FileAccess.Read);
					BinaryFormatter bf = new BinaryFormatter();
					this.wizard = bf.Deserialize(fs) as CoinsWizard;
				}
			} catch(UnauthorizedAccessException) {
				Popup.Show(Tr.GetStr("popups", "errorSerializationLoad"), "Access Forbidden", Style.Warning);
			} catch(IOException) {
				Popup.Show(Tr.GetStr("popups", "errorSerializationLoad"), "I/O Error", Style.Error);
			} catch(SerializationException) {
				Popup.Show(Tr.GetStr("popups", "errorSerializationLoad"), "Serialization Error", Style.Error);
			} finally {
				fs?.Close();
			}

			if(this.wizard is null)
				this.wizard = new CoinsWizard();
			#endregion
		}

		private void FPrincipal_Load(object sender, EventArgs e) {
			this.cmbUser.BackColor = Color.FromArgb(24, 55, 81);
			this.cmbUser.ListBackColor = Color.FromArgb(24, 55, 81);

			this.ApplyLocale();

			string path = this.wizard.SteamPath;
			string coins = (this.wizard.LunarCoins > 0) ? this.wizard.LunarCoins.ToString() : null;

			if(!string.IsNullOrEmpty(path))
				this.tbPath.InputText = path;

			this.UpdateUsers();

			if(!(this.wizard.User is null)) {
				User searchedUser = this.wizard.User;
				int foundIndex = -1;
				int userIndex = 0;
				foreach(User u in this.cmbUser.Items) {
					if(searchedUser.Id == u.Id) {
						foundIndex = userIndex;
						break;
					}
					userIndex++;
				}

				if(foundIndex >= 0 && foundIndex < this.cmbUser.Items.Count)
					this.cmbUser.SelectedIndex = foundIndex;
			}

			if(!string.IsNullOrEmpty(coins))
				this.tbLunarCoins.InputText = coins;

			this.btnBackupProfilesAndApplyCoins.Enabled = this.wizard.IsFullPathValid();
		}

		private void ApplyLocale() {
			this.btnLoadProfiles.Text = Tr.GetStr("main", "btnTextLoadProfilesBackup");
			this.cmbUser.DisplayText = Tr.GetStr("main", "cmbDisplayTextSteamUser");
			this.tbPath.PlaceHolder = Tr.GetStr("main", "tbPlaceholderSteamPath");
			this.fbdPath.Description = Tr.GetStr("main", "fbdPathDescription");
			this.lblPath.Text = Tr.GetStr("main", "lblTextSteamPath");
			this.lblLunarCoins.Text = Tr.GetStr("common", "lunarCoins");
			this.tbLunarCoins.PlaceHolder = Tr.GetStr("common", "amount");
			this.btnBackupProfilesAndApplyCoins.Text = Tr.GetStr("main", "btnTextBackupAndApply");
			this.btnQuit.Text = Tr.GetStr("common", "quit");
		}

		private void UpdateUsers() {
			this.cmbUser.Items.Clear();
			foreach(User u in this.wizard.FetchUsers())
				this.cmbUser.Items.Add(u);
		}

		private void BtnPath_Click(object sender, EventArgs e) {
			string startPath = this.tbPath.InputText;
			if(!string.IsNullOrEmpty(startPath) && Directory.Exists(startPath))
				this.fbdPath.SelectedPath = startPath;

			if(this.fbdPath.ShowDialog() != DialogResult.OK)
				return;

			this.wizard.SteamPath = this.fbdPath.SelectedPath;

			if(!this.wizard.IsSteamPathValid()) {
				Popup.Show(
					Tr.GetStr("popups", "errorInvalidSteamPath"),
					Tr.GetStr("popups", "errorInvalidSteamPathCaption"),
					Style.Error,
					new Anim(400, 3000, 1000, AnimCurve.EaseOut2, AnimCurve.EaseIn4));
				return;
			}

			this.UpdateUsers();
			this.tbPath.InputText = this.wizard.SteamPath;
			this.btnBackupProfilesAndApplyCoins.Enabled = this.wizard.IsFullPathValid();
		}

		private void CmbUser_OnSelectedIndexChanged(object sender, EventArgs e) {
			if(this.cmbUser.SelectedIndex < 0)
				return;

			this.wizard.User = this.cmbUser.SelectedItem as User;
			this.btnBackupProfilesAndApplyCoins.Enabled = this.wizard.IsFullPathValid();
		}

		private void BtnBackupProfilesAndApplyCoins_Click(object sender, EventArgs e) {
			if(!this.ExpectPath()) {
				this.btnBackupProfilesAndApplyCoins.Enabled = false;
				return;
			}

			List<string> succeeded, failed;
			bool backupFullySucceeded = this.BackupProfiles(out succeeded, out failed);

			if(succeeded.Count > 0)
				Popup.Show(
					Tr.GetStr("popups", "infoBackupSaveSavedList", string.Join("\n", succeeded)),
					"Task Finished",
					Style.Success,
					6_000);

			if(failed.Count > 0)
				Popup.Show(
					Tr.GetStr("popups", "infoBackupSaveFailedList", string.Join("\n", failed)),
					"Task Finished",
					Style.Error,
					12_000);

			if(!backupFullySucceeded) {
				Popup.Show(
					"Profiles backup wasn't fully successful, so no action will be taken.",
					"Operation Aborted",
					Style.Warning,
					8_000);
				return;
			}

			Popup.Show(
				"Profiles backup succeeded. Will try to apply coins.",
				Style.Info,
				5_000);

			if(!this.ApplyCoins(out succeeded, out failed)) {
				Popup.Show(
					"Couldn't find any profiles to apply coins to.",
					"Invalid Operation",
					Style.Warning,
					8_000);
				return;
			}

			if(succeeded.Count > 0)
				Popup.Show(
					Tr.GetStr("popups", "infoCoinWriteWrittenList", string.Join("\n", succeeded)),
					"Task finished",
					Style.Success,
					6_000);

			if(failed.Count > 0)
				Popup.Show(
					Tr.GetStr("popups", "infoCoinWriteFailedList", string.Join("\n", failed)),
					"Task finished",
					Style.Error,
					12_000);
		}

		private void BtnLoadProfiles_Click(object sender, EventArgs e) {
			if(!this.ExpectPath()) {
				this.btnBackupProfilesAndApplyCoins.Enabled = false;
				return;
			}

			DialogResult resultado = Dialog.ShowDialog(
				Tr.GetStr("popups", "askBackupLoad"),
				"Confirmation",
				DialogButtons.YesNo,
				Style.Question);

			if(resultado != DialogResult.Yes)
				return;

			List<string> succeeded, failed;
			bool hadProfilesToLoad = this.LoadProfiles(out succeeded, out failed);

			if(!hadProfilesToLoad) {
				Popup.Show(
					"Couldn't find any profiles to backup.",
					"Invalid Operation",
					Style.Warning,
					8_000);
				return;
			}

			if(succeeded.Count > 0)
				Popup.Show(
					Tr.GetStr("popups", "infoBackupLoadLoadedList", string.Join("\n", succeeded)),
					"Reverted Profiles",
					Style.Success,
					6_000);

			if(failed.Count > 0)
				Popup.Show(
					Tr.GetStr("popups", "infoBackupLoadFailedList", string.Join("\n", failed)),
					"Problems During Revertion",
					Style.Error,
					12_000);
		}

		private void BtnQuit_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void FPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
			if(this.wizard is null)
				return;

			if(string.IsNullOrEmpty(this.wizard.SteamPath))
				this.wizard.SteamPath = this.tbPath.InputText;

			if(this.wizard.User is null)
				this.wizard.User = this.cmbUser.SelectedItem as User;

			int lunarCoins;
			if(int.TryParse(this.tbLunarCoins.InputText, out lunarCoins))
				this.wizard.LunarCoins = lunarCoins;

			FileStream fs = null;
			try {
				fs = new FileStream(this.dirBin, FileMode.OpenOrCreate, FileAccess.Write);
				BinaryFormatter bf = new BinaryFormatter();
				bf.Serialize(fs, this.wizard);
			} catch(UnauthorizedAccessException) {
				Popup.Show(Tr.GetStr("popups", "errorSerializationSave"), "Access Forbidden", Style.Warning);
			} catch(IOException) {
				Popup.Show(Tr.GetStr("popups", "errorSerializationSave"), "I/O Error", Style.Error);
			} finally {
				fs?.Close();
			}
		}

		private bool ExpectPath() {
			if(!this.wizard.IsSteamPathValid()) {
				Popup.Show(
					Tr.GetStr("popups", "errorSteamPathWasInvalid"),
					"Invalid Steam Path",
					Style.Warning);
				this.tbPath.ResetText();
				this.btnPath.Focus();
				return false;
			}

			if(!this.wizard.IsFullPathValid()) {
				Popup.Show(
					Tr.GetStr("popups", "errorUserWasInvalid"),
					"Invalid user ID",
					Style.Warning);

				this.cmbUser.SelectedIndex = -1;

				this.cmbUser.Items.Clear();
				foreach(User user in this.wizard.FetchUsers())
					this.cmbUser.Items.Add(user);

				this.cmbUser.Focus();
				return false;
			}

			return true;
		}

		/// <summary>
		/// Attempts to apply a set amount of coins to all of the current Steam user's RoR2 profiles.
		/// </summary>
		/// <param name="succeeded">A list of profile paths that were successfully reverted.</param>
		/// <param name="failed">A list of profile paths that failed to be reverted.</param>
		/// <returns>
		/// Whether the operation was attempted for any profiles (<see langword="true"/>) or not (<see langword="false"/>).
		/// </returns>
		private bool ApplyCoins(out List<string> succeeded, out List<string> failed) {
			succeeded = new List<string>();
			failed = new List<string>();

			int coins;
			if(!int.TryParse(this.tbLunarCoins.InputText, out coins)) {
				if(long.TryParse(this.tbLunarCoins.InputText, out _)) {
					coins = int.MaxValue;
					this.tbLunarCoins.InputText = coins.ToString();
				} else {
					Popup.Show(
						Tr.GetStr("popups", "errorInvalidLunarCoins", $"{int.MaxValue:###,###,###,###}"),
						"Invalid value",
						Style.Warning);
					return false;
				}
			}

			if(coins < 0) {
				Popup.Show(
					Tr.GetStr("popups", "errorInvalidLunarCoins", $"{int.MaxValue:###,###,###,###}"),
					"Invalid value",
					Style.Warning);
				return false;
			}

			string profilesPath = this.wizard.GetFullPath();
			string[] profileFilenames = this.wizard.GetProfileFilenames();

			foreach(string filename in profileFilenames) {
				string profilePath = Path.Combine(profilesPath, filename);

				try {
					string profileData = File.ReadAllText(profilePath, Encoding.UTF8);
					string newProfileData = Regex.Replace(profileData, "<coins>(\\d+)<\\/coins>", $"<coins>{coins}</coins>");
					File.WriteAllText(profilePath, newProfileData, Encoding.UTF8);

					succeeded.Add(filename);
				} catch(UnauthorizedAccessException) {
					Popup.Show(Tr.GetStr("popups", "errorCoinWriteIO", profilePath), "Access Forbidden", Style.Warning);
					failed.Add(filename);
				} catch(IOException ex) {
					Popup.Show(Tr.GetStr("popups", "errorCoinWriteUnauthorized", profilePath, ex.Message), "I/O Error", Style.Error);
					failed.Add(filename);
				} catch(Exception ex) {
					Popup.Show(ex.Message, "Unexpected Exception", Style.Error);
					failed.Add(filename);
				}
			}

			return (succeeded.Count + failed.Count) > 0;
		}

		/// <summary>
		/// Attempts to save a backup for all of the current Steam user's RoR2 profiles
		/// </summary>
		/// <param name="succeeded">A list of profile paths that were successfully backed up.</param>
		/// <param name="failed">A list of profile paths that failed to be backed up.</param>
		/// <returns>
		/// Whether any and all of the profiles were successfully backed up (<see langword="true"/>) or not (<see langword="false"/>).
		/// </returns>
		private bool BackupProfiles(out List<string> succeeded, out List<string> failed) {
			string profilesPath = this.wizard.GetFullPath();
			string[] profileFilenames = this.wizard.GetProfileFilenames();

			succeeded = new List<string>();
			failed = new List<string>();

			if(profileFilenames is null) {
				Popup.Show(
					Tr.GetStr("popups", "errorBackupNoProfiles", profilesPath),
					"No Profiles",
					Style.Warning,
					new Anim(400, 6000, 2000, AnimCurve.EaseOut3, AnimCurve.EaseIn3));
				return false;
			}

			foreach(string filename in profileFilenames) {
				string src = Path.Combine(profilesPath, filename);
				string dest = Path.Combine(this.dirBackup, filename);

				try {
					if(File.Exists(dest))
						File.Delete(dest);

					File.Copy(src, dest);

					succeeded.Add(filename);
				} catch(UnauthorizedAccessException) {
					Popup.Show(Tr.GetStr("popups", "errorBackupProfileCopyUnauthorized", src, dest), "Access Forbidden", Style.Warning);
					failed.Add(filename);
				} catch(IOException ex) {
					Popup.Show(Tr.GetStr("popups", "errorBackupProfileCopyIO", src, dest, ex.Message), "I/O Error", Style.Error);
					failed.Add(filename);
				} catch(Exception ex) {
					Popup.Show(ex.Message, "Unexpected Exception", Style.Error);
					failed.Add(filename);
				}
			}

			return succeeded.Count > 0 && failed.Count == 0;
		}

		/// <summary>
		/// Attempts to revert the changes previously made to all of the current Steam user's RoR2 profiles via backup.
		/// </summary>
		/// <param name="succeeded">A list of profile paths that were successfully reverted.</param>
		/// <param name="failed">A list of profile paths that failed to be reverted.</param>
		/// <returns>
		/// Whether the operation was attempted for any profiles (<see langword="true"/>) or not (<see langword="false"/>).
		/// </returns>
		private bool LoadProfiles(out List<string> succeeded, out List<string> failed) {
			string profilesPath = this.wizard.GetFullPath();
			string[] profileFilenames = Directory.GetFiles(this.dirBackup);

			succeeded = new List<string>();
			failed = new List<string>();

			if(profileFilenames is null) {
				Popup.Show(
					Tr.GetStr("popups", "errorBackupNoProfiles", profilesPath),
					"No Profiles",
					Style.Warning,
					new Anim(400, 6000, 2000, AnimCurve.EaseOut3, AnimCurve.EaseIn3));
				return false;
			}

			foreach(string profilePath in profileFilenames) {
				string filename = profilePath.Split('\\').Last();

				string src = Path.Combine(this.dirBackup, filename);
				string dest = Path.Combine(profilesPath, filename);

				try {
					if(File.Exists(dest))
						File.Delete(dest);

					File.Copy(src, dest);

					succeeded.Add(filename);
				} catch(UnauthorizedAccessException) {
					Popup.Show(Tr.GetStr("popups", "errorBackupProfileCopyUnauthorized", src, dest), "Access Forbidden", Style.Warning);
					failed.Add(filename);
				} catch(IOException ex) {
					Popup.Show(Tr.GetStr("popups", "errorBackupProfileCopyIO", src, dest, ex.Message), "I/O Error", Style.Error);
					failed.Add(filename);
				} catch(Exception ex) {
					Popup.Show(ex.Message, "Unexpected Exception", Style.Error);
					failed.Add(filename);
				}
			}

			return (succeeded.Count + failed.Count) > 0;
		}

		private void BtnCoinsMinus100_Click(object sender, EventArgs e) {
			int currentCoins;
			int.TryParse(this.tbLunarCoins.InputText, out currentCoins);
			this.tbLunarCoins.InputText = Math.Max(0, currentCoins - 100).ToString();
		}

		private void BtnCoinsMinus10_Click(object sender, EventArgs e) {
			int currentCoins;
			int.TryParse(this.tbLunarCoins.InputText, out currentCoins);
			this.tbLunarCoins.InputText = Math.Max(0, currentCoins - 10).ToString();
		}

		private void BtnCoinsPlus10_Click(object sender, EventArgs e) {
			int currentCoins;
			int.TryParse(this.tbLunarCoins.InputText, out currentCoins);
			this.tbLunarCoins.InputText = ((currentCoins > int.MaxValue - 10) ? int.MaxValue : (currentCoins + 10)).ToString();
		}

		private void BtnCoinsPlus100_Click(object sender, EventArgs e) {
			int currentCoins;
			int.TryParse(this.tbLunarCoins.InputText, out currentCoins);
			this.tbLunarCoins.InputText = ((currentCoins > int.MaxValue - 100) ? int.MaxValue : (currentCoins + 100)).ToString();
		}

		private void BtnCoinsMax_Click(object sender, EventArgs e) {
			this.tbLunarCoins.InputText = int.MaxValue.ToString();
		}
	}
}
