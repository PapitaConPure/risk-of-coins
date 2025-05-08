using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskOfCoins.Classes {
	[Serializable]
	internal class User {
		public User(string id, string name) {
			this.Id = id;
			this.Name = name;
		}

		public string Id { get; private set; }
		public string Name { get; private set; }

		public override string ToString() {
			return this.Name;
		}
	}
}