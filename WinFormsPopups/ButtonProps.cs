using System.Drawing;
using System.Windows.Forms;

namespace WinFormsPopups {
	public readonly struct ButtonProps {
		public ButtonProps(DialogResult resultado, string texto, Color colorFondo, Color colorTexto) {
			this.DialogResult = resultado;
			this.Text = texto;
			this.ForeColor = colorTexto;
			this.BackColor = colorFondo;
		}

		public DialogResult DialogResult { get; }

		public string Text { get; }

		public Color ForeColor { get; }

		public Color BackColor { get; }
	}
}
