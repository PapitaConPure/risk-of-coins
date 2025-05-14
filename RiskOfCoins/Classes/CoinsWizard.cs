using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RiskOfCoins.Classes {
	[Serializable]
	class CoinsWizard {
		private const string STEAM_ROR2_ID = "632360";
		private const string REGEX_INFO_STEAM_USERNAME = "\"PersonaName\"\\t\\t\"(.{1,32})\"";
		private string steamPath;

		public CoinsWizard(string path = "C:\\Program Files (x86)\\Steam") {
			this.SteamPath = path;
			this.LunarCoins = int.MaxValue;
		}

		public string SteamPath {
			set {
				if(value is null || !Directory.Exists(value)) {
					this.steamPath = null;
					return;
				}

				string path = value.Replace("/", "\\");

				if(path.EndsWith("\\"))
					path = path.Remove(path.Length - 1);

				if(path.EndsWith("userdata")) {
					path = path.Remove(path.Length - "userdata".Length);
				} else {
					string userdataPath = Path.Combine(path, "userdata");

					if(!Directory.Exists(userdataPath)) {
						this.steamPath = null;
						return;
					}
				}

				this.steamPath = path;
			}
			get {
				return this.steamPath;
			}
		}

		public SteamUser User { set; get; }

		public int LunarCoins { set; get; }

		public List<SteamUser> FetchUsers() {
			List<SteamUser> users = new List<SteamUser>();

			if(this.steamPath is null)
				return users;

			string userdataPath = Path.Combine(this.steamPath, "userdata");
			if(!Directory.Exists(userdataPath))
				return users;

			string[] directories = Directory.GetDirectories(userdataPath);
			if(directories.Length == 0)
				return users;

			string uconfFile, uRoR2Dir, userId, userData, userName;
			Match userNameMatch;
			foreach(string userPath in directories) {
				uconfFile = Path.Combine(userPath, "config", "localconfig.vdf");
				if(!File.Exists(uconfFile))
					continue;

				uRoR2Dir = Path.Combine(userPath, STEAM_ROR2_ID, "remote", "UserProfiles");
				if(!Directory.Exists(uRoR2Dir))
					continue;

				userData = File.ReadAllText(uconfFile, Encoding.UTF8);
				userNameMatch = Regex.Match(userData, REGEX_INFO_STEAM_USERNAME);
				if(userNameMatch.Groups.Count < 2)
					continue;

				userId = userPath.Split('\\').Last();
				userName = userNameMatch.Groups[1].Value;
				users.Add(new SteamUser(userId, userName));
			}

			return users;
		}

		public string[] GetProfileFilenames() {
			if(!this.IsFullPathValid())
				return null;

			string profilesPath = this.GetFullPath();

			if(profilesPath is null)
				return null;

			List<string> profileFilenames = new List<string>();

			foreach(string profilePath in Directory.EnumerateFiles(profilesPath)) {
				string profileFilename = profilePath.Split('\\').Last();
				profileFilenames.Add(profileFilename);
			}

			return profileFilenames.ToArray();
		}

		public string GetFullPath() {
			if(string.IsNullOrWhiteSpace(this.SteamPath) || this.User is null)
				return null;

			string userPath = Path.Combine("userdata", this.User.Id);
			string gamePath = Path.Combine(STEAM_ROR2_ID, "remote", "UserProfiles");

			return Path.Combine(this.SteamPath, userPath, gamePath);
		}

		public bool IsFullPathValid() {
			string fullPath = this.GetFullPath();
			return !string.IsNullOrWhiteSpace(fullPath) && Directory.Exists(fullPath);
		}

		public bool IsSteamPathValid() {
			if(string.IsNullOrWhiteSpace(this.SteamPath))
				return false;

			string userdataPath = Path.Combine(this.SteamPath, "userdata");
			return Directory.Exists(userdataPath);
		}
	}
}
