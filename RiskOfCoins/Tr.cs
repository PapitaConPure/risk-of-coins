using System;
using System.Resources;
using System.Globalization;
using System.Collections.Generic;

namespace RiskOfCoins.Translator {
	public enum TrCat {
		Common,
		Main,
		Popups,
	};

	public static class Tr {
		private static readonly Dictionary<TrCat, ResourceManager> resourceManagers;

		static Tr() {
			resourceManagers = new Dictionary<TrCat, ResourceManager> {
				{ TrCat.Common, new ResourceManager("RiskOfCoins.Resources.common", typeof(Tr).Assembly) },
				{ TrCat.Main,   new ResourceManager("RiskOfCoins.Resources.main",   typeof(Tr).Assembly) },
				{ TrCat.Popups, new ResourceManager("RiskOfCoins.Resources.popups", typeof(Tr).Assembly) },
			};
		}

		public static string GetStr(TrCat resourceType, string key, object[] values) {
			if(!resourceManagers.ContainsKey(resourceType))
				throw new ArgumentOutOfRangeException(nameof(resourceType), resourceType, "Invalid resource type.");

			string resource = resourceManagers[resourceType].GetString(key, CultureInfo.CurrentUICulture);

			for(int i = 0; i < values.Length; i++)
				resource = resource.Replace("{{" + i + "}}", values[i].ToString());

			return resource;
		}

		public static string GetStr(TrCat resourceType, string key, object v0, object v1, object v2, object v3, object v4, object v5, object v6, object v7) {
			return GetStr(resourceType, key, new object[] { v0, v1, v2, v3, v4, v5, v6, v7 });
		}

		public static string GetStr(TrCat resourceType, string key, object v0, object v1, object v2, object v3, object v4, object v5, object v6) {
			return GetStr(resourceType, key, new object[] { v0, v1, v2, v3, v4, v5, v6 });
		}

		public static string GetStr(TrCat resourceType, string key, object v0, object v1, object v2, object v3, object v4, object v5) {
			return GetStr(resourceType, key, new object[] { v0, v1, v2, v3, v4, v5 });
		}

		public static string GetStr(TrCat resourceType, string key, object v0, object v1, object v2, object v3, object v4) {
			return GetStr(resourceType, key, new object[] { v0, v1, v2, v3, v4 });
		}

		public static string GetStr(TrCat resourceType, string key, object v0, object v1, object v2, object v3) {
			return GetStr(resourceType, key, new object[] { v0, v1, v2, v3 });
		}

		public static string GetStr(TrCat resourceType, string key, object v0, object v1, object v2) {
			return GetStr(resourceType, key, new object[] { v0, v1, v2 });
		}

		public static string GetStr(TrCat resourceType, string key, object v0, object v1) {
			return GetStr(resourceType, key, new object[] { v0, v1 });
		}

		public static string GetStr(TrCat resourceType, string key, object v0) {
			return GetStr(resourceType, key, new object[] { v0 });
		}

		public static string GetStr(TrCat resourceType, string key) {
			return GetStr(resourceType, key, new object[0]);
		}
	}
}
