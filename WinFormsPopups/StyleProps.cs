using System.Drawing;

namespace WinFormsPopups {
	public readonly struct StyleProps {
		public StyleProps(Color color, Image icono = null) {
			this.Icon = icono;
			this.Color = color;
		}

		public Image Icon { get; }

		public Color Color { get; }
	}
}
