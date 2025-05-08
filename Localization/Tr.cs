using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Localization {
	public static class Tr {
		private static readonly Dictionary<string, TranslationCategory> translationCategories
			= new Dictionary<string, TranslationCategory>();

		public static Assembly TargetAssembly { get; private set; }

		public static CultureInfo TargetCulture { get; private set; }

		public static bool IsSetup => TargetAssembly != null && TargetCulture != null;

		public static void Setup(Assembly targetAssembly, CultureInfo targetCulture) {
			TargetAssembly = targetAssembly;
			TargetCulture = targetCulture;
		}

		public static void AddSourceToCategory(string categoryKey, string resourceManagerBaseName) {
			if(!IsSetup)
				throw new InvalidOperationException("Tr.Setup() must be called before adding resource managers.");

			ResourceManager resourceManager = new ResourceManager(resourceManagerBaseName, TargetAssembly);
			TranslationCategory category;

			try {
				resourceManager.GetResourceSet(TargetCulture, true, true);
			} catch(MissingManifestResourceException ex) {
				throw new ArgumentException(
					$"Invalid resource manager base name. Make sure the resource manager exists in the assembly: {TargetAssembly.FullName}.",
					nameof(resourceManagerBaseName),
					ex);
			}

			if(translationCategories.TryGetValue(categoryKey, out category)) {
				category.AddResourceManager(resourceManager);
				return;
			}

			category = new TranslationCategory(resourceManager);
			translationCategories.Add(categoryKey, category);
		}

		public static string GetStr(string categoryKey, string key, object[] values) {
			if(!translationCategories.ContainsKey(categoryKey))
				throw new ArgumentOutOfRangeException(
					nameof(categoryKey),
					categoryKey,
					"Invalid translation category key. Make sure to call Tr.AddSourceToCategory() before using this key.");

			string resource = translationCategories[categoryKey].GetString(key, TargetCulture);

			for(int i = 0; i < values.Length; i++)
				resource = resource.Replace("{{" + i + "}}", values[i].ToString());

			return resource;
		}

		public static string GetStr(string resourceType, string key,
			object v0, object v1, object v2, object v3, object v4,
			object v5, object v6, object v7, object v8, object v9
		)
			=> GetStr(resourceType, key, new object[] { v0, v1, v2, v3, v4, v5, v6, v7, v8, v9 });

		public static string GetStr(string resourceType, string key,
			object v0, object v1, object v2, object v3, object v4,
			object v5, object v6, object v7, object v8
		)
			=> GetStr(resourceType, key, new object[] { v0, v1, v2, v3, v4, v5, v6, v7, v8 });

		public static string GetStr(string resourceType, string key,
			object v0, object v1, object v2, object v3, object v4,
			object v5, object v6, object v7
		)
			=> GetStr(resourceType, key, new object[] { v0, v1, v2, v3, v4, v5, v6, v7 });

		public static string GetStr(string resourceType, string key,
			object v0, object v1, object v2, object v3, object v4,
			object v5, object v6
		)
			=> GetStr(resourceType, key, new object[] { v0, v1, v2, v3, v4, v5, v6 });

		public static string GetStr(string resourceType, string key, object v0, object v1, object v2, object v3, object v4, object v5)
			=> GetStr(resourceType, key, new object[] { v0, v1, v2, v3, v4, v5 });

		public static string GetStr(string resourceType, string key, object v0, object v1, object v2, object v3, object v4)
			=> GetStr(resourceType, key, new object[] { v0, v1, v2, v3, v4 });

		public static string GetStr(string resourceType, string key, object v0, object v1, object v2, object v3)
			=> GetStr(resourceType, key, new object[] { v0, v1, v2, v3 });

		public static string GetStr(string resourceType, string key, object v0, object v1, object v2)
			=> GetStr(resourceType, key, new object[] { v0, v1, v2 });

		public static string GetStr(string resourceType, string key, object v0, object v1)
			=> GetStr(resourceType, key, new object[] { v0, v1 });

		public static string GetStr(string resourceType, string key, object v0)
			=> GetStr(resourceType, key, new object[] { v0 });

		public static string GetStr(string resourceType, string key)
			=> GetStr(resourceType, key, new object[0]);
	}
}
