using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RiskOfCoins {
	[Serializable]
	class CoinsWizard {
		private const string REGEX_PATH_STEAM_USERDATA_EXT = "((.+\\\\)+userdata)\\\\(\\d{1,11})";
		private string userdataPath;

		public CoinsWizard(string path = "C:\\Program Files (x86)\\Steam\\userdata") {
			this.UserdataPath = path;
			this.TryMatchUserId();
			this.LunarCoins = int.MaxValue;
		}

		public string UserdataPath {
			set {
				if(value is null || !Directory.Exists(value)) {
					this.userdataPath = null;
					return;
				}

				string path = value;
				string userId = null;

				path = path.Replace("/", "\\");

				if(path.EndsWith("\\"))
					path = path.Remove(path.Length - 1);

				if(!path.EndsWith("userdata")) {
					Match match = Regex.Match(path, REGEX_PATH_STEAM_USERDATA_EXT);

					if(match.Success) {
						path = match.Groups[1].Value;
						userId = match.Groups[3].Value;
					} else
						path = Path.Combine(path, "userdata");
				}

				if(!Directory.Exists(path)) {
					this.userdataPath = null;
					return;
				}

				this.userdataPath = path;

				if(userId != null)
					this.UserId = userId;
			}
			get {
				return this.userdataPath;
			}
		}

		public string UserId { set; get; }

		public int LunarCoins { set; get; }

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

		public bool TryMatchUserId() {
			if(!Directory.Exists(this.UserdataPath))
				return false;

			if(this.IsFullPathValid())
				return true;

			string[] directories = Directory.GetDirectories(this.UserdataPath);

			if(directories.Length == 0)
				return false;

			this.UserId = directories[0].Split('\\').Last();
			return true;
		}

		public string GetFullPath() {
			if(string.IsNullOrEmpty(this.UserdataPath) || string.IsNullOrEmpty(this.UserId))
				return null;

			string restOfPath = Path.Combine("632360", "remote", "UserProfiles");

			return Path.Combine(this.UserdataPath, this.UserId, restOfPath);
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
