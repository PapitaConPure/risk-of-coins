using Localization;
using RiskOfCoins.Forms;
using System;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;

namespace RiskOfCoins {
	static class Program {
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main() {
			Assembly targetAssembly = typeof(Program).Assembly;
			CultureInfo targetCulture = CultureInfo.CurrentUICulture;
			Tr.Setup(targetAssembly, targetCulture);

			Tr.AddSourceToCategory("common", "RiskOfCoins.Resources.Text.common");
			Tr.AddSourceToCategory("main", "RiskOfCoins.Resources.Text.main");
			Tr.AddSourceToCategory("popups", "RiskOfCoins.Resources.Text.popups");

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FMain());
		}
	}
}
