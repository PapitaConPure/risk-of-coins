using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiskOfCoins {
	public partial class FPreview: Form {
		public FPreview() {
			this.InitializeComponent();
		}

		public FPreview(string filename, string data): this() {
			this.Text = $"Profile: {filename}";
			this.tbPreview.Text = data;
		}
	}
}
