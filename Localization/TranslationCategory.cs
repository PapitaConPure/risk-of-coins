using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Localization {
	internal class TranslationCategory {
		private readonly List<ResourceManager> resourceManagers;

		public TranslationCategory(ResourceManager resourceManager) {
			this.resourceManagers = new List<ResourceManager> { resourceManager };
		}

		public void AddResourceManager(ResourceManager resourceManager) {
			if(this.Contains(resourceManager))
				return;

			resourceManagers.Add(resourceManager);
		}

		public bool Contains(ResourceManager resourceManager) {
			return resourceManagers.Any(rm => rm.BaseName == resourceManager.BaseName);
		}

		public string GetString(string key, System.Globalization.CultureInfo culture) {
			foreach(ResourceManager resourceManager in resourceManagers) {
				string value = resourceManager.GetString(key, culture);

				if(value != null)
					return value;
			}

			return null;
		}
	}
}
