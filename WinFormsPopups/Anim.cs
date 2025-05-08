using System;

namespace WinFormsPopups {
	public sealed class Anim {
		public Anim(long inTime, long holdTime, long outTime, AnimCurve interpolationIn, AnimCurve interpolationOut) {
			this.TimeIn = inTime;
			this.TimeHold = Math.Max(1, holdTime);
			this.TimeOut = outTime;
			this.InterpolationIn = interpolationIn;
			this.InterpolationOut = interpolationOut;
		}

		public Anim(long timeIn, long timeHold, long timeOut, AnimCurve interpolation)
		: this(timeIn, timeHold, timeOut, interpolation, interpolation) { }

		public Anim(long timeIn, long timeHold, long timeOut)
		: this(timeIn, timeHold, timeOut, AnimCurve.EaseOut2, AnimCurve.EaseIn2) { }

		public Anim(long tiempoFade, long timeHold, AnimCurve formulaIn, AnimCurve formulaOut)
		: this(tiempoFade, timeHold, tiempoFade, formulaIn, formulaOut) { }

		public Anim(long tiempoFade, long timeHold, AnimCurve formulaFade)
		: this(tiempoFade, timeHold, formulaFade, formulaFade) { }

		public Anim(long tiempoFade, long timeHold)
		: this(tiempoFade, timeHold, tiempoFade) { }

		public Anim(long timeHold, AnimCurve formulaIn, AnimCurve formulaOut)
		: this(500, timeHold, formulaIn, formulaOut) { }

		public Anim(long timeHold, AnimCurve formulaFade)
		: this(timeHold, formulaFade, formulaFade) { }

		public Anim(long timeHold)
		: this(timeHold, AnimCurve.EaseOut2, AnimCurve.EaseIn2) { }

		public Anim()
		: this(3000) { }

		public static explicit operator Anim(long timeHold)
			=> new Anim(timeHold);

		public long TimeIn { get; }

		public long TimeHold { get; }

		public long TimeOut { get; }

		public AnimCurve InterpolationIn { get; }

		public AnimCurve InterpolationOut { get; }

		public double ValueIn(long ms, int outMin = 0, int outMax = 1) {
			double t = (double)ms / Math.Max(1, this.TimeIn);
			double fac = Math.Max(0, Math.Min(t, 1));
			double interpolated = InterpolationHelper.Mappings[this.InterpolationIn](fac);
			return outMin + interpolated * (outMax - outMin);
		}

		public double ValueOut(long ms, int outMin = 0, int outMax = 1) {
			double t = (double)ms / Math.Max(1, this.TimeOut);
			double fac = Math.Max(0, Math.Min(t, 1));
			double interpolated = InterpolationHelper.Mappings[this.InterpolationOut](fac);
			return outMin + interpolated * (outMax - outMin);
		}
	}
}
