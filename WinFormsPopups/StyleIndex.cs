using System.Collections.Generic;
using System.Drawing;

namespace WinFormsPopups {
	public static class StyleIndex {
		private static readonly Dictionary<Style, StyleProps> styles = new Dictionary<Style, StyleProps> {
			{ Style.Neutral, new StyleProps(
				color: Color.FromArgb(48, 48, 48)
			)},
			{ Style.Info, new StyleProps(
				icono: Properties.Resources.icon_popup_info,
				color: Color.FromArgb(20, 90, 143)
			)},
			{ Style.Question, new StyleProps(
				icono: Properties.Resources.icon_popup_question,
				color: Color.FromArgb(20, 90, 143)
			)},
			{ Style.Success, new StyleProps(
				icono: Properties.Resources.icon_popup_success,
				color: Color.FromArgb(64, 174, 72)
			)},
			{ Style.Warning, new StyleProps(
				icono: Properties.Resources.icon_popup_warning,
				color: Color.FromArgb(180, 132, 29)
			)},
			{ Style.Error, new StyleProps(
				icono: Properties.Resources.icon_popup_error,
				color: Color.FromArgb(163, 42, 50)
			)},
		};

		public static StyleProps Neutral => styles[Style.Neutral];

		public static StyleProps Info => styles[Style.Info];

		public static StyleProps Question => styles[Style.Info];

		public static StyleProps Success => styles[Style.Success];

		public static StyleProps Warning => styles[Style.Warning];

		public static StyleProps Error => styles[Style.Error];

		public static bool TryGet(Style style, out StyleProps result) {
			bool valid = styles.TryGetValue(style, out result);

			if(!valid) {
				result = Neutral;
				return false;
			}

			return true;
		}
	}
}
