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

			Tr.AddSourceToCategory("common", "RiskOfCoins.Resources.common");
			Tr.AddSourceToCategory("main", "RiskOfCoins.Resources.main");
			Tr.AddSourceToCategory("popups", "RiskOfCoins.Resources.popups");

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FMain());
		}
	}
}
