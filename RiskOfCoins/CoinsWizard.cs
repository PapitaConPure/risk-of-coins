using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RiskOfCoins {
	[Serializable]
	class CoinsWizard {
		private const string STEAM_ROR2_ID = "632360";
		private const string REGEX_PATH_STEAM_USERDATA_EXT = "((.+\\\\)+userdata)\\\\(\\d{1,11})";
		private const string REGEX_INFO_STEAM_USERNAME = "\"PersonaName\"\\t\\t\"(.{1,32})\"";
		private string userdataPath;

		public CoinsWizard(string path = "C:\\Program Files (x86)\\Steam\\userdata") {
			this.UserdataPath = path;
			this.LunarCoins = int.MaxValue;
		}

		public string UserdataPath {
			set {
				if(value is null || !Directory.Exists(value)) {
					this.userdataPath = null;
					return;
				}

				string path = value;

				path = path.Replace("/", "\\");

				if(path.EndsWith("\\"))
					path = path.Remove(path.Length - 1);

				if(!path.EndsWith("userdata")) {
					Match match = Regex.Match(path, REGEX_PATH_STEAM_USERDATA_EXT);

					if(match.Success) {
						path = match.Groups[1].Value;
					} else
						path = Path.Combine(path, "userdata");
				}

				if(!Directory.Exists(path)) {
					this.userdataPath = null;
					return;
				}

				this.userdataPath = path;
			}
			get {
				return this.userdataPath;
			}
		}

		public User User { set; get; }

		public int LunarCoins { set; get; }

		public List<User> FetchUsers() {
			List<User> users = new List<User>();

			if(this.userdataPath is null || !Directory.Exists(this.userdataPath))
				return users;

			string[] directories = Directory.GetDirectories(this.UserdataPath);

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
				users.Add(new User(userId, userName));
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
			if(string.IsNullOrEmpty(this.UserdataPath) || this.User is null)
				return null;

			string restOfPath = Path.Combine(STEAM_ROR2_ID, "remote", "UserProfiles");

			return Path.Combine(this.UserdataPath, this.User.Id, restOfPath);
		}

		public bool IsFullPathValid() {
			string fullPath = this.GetFullPath();
			return !string.IsNullOrEmpty(fullPath) && Directory.Exists(fullPath);
		}

		public bool IsUserdataPathValid() {
			return !string.IsNullOrEmpty(this.userdataPath) && Directory.Exists(this.userdataPath);
		}
	}
}
