using static WinFormsPopups.InterpolationHelper;
using System;
using System.Collections.Generic;

namespace WinFormsPopups {
	public sealed class Anim {
		private static readonly IReadOnlyDictionary<AnimCurve, InterpolationFn> mappings
		= new Dictionary<AnimCurve, InterpolationFn>() {
			{ AnimCurve.Linear, Linear },
			{ AnimCurve.EaseIn2, EaseIn2 },
			{ AnimCurve.EaseIn3, EaseIn3 },
			{ AnimCurve.EaseIn4, EaseIn4 },
			{ AnimCurve.EaseIn5, EaseIn5 },
			{ AnimCurve.EaseOut2, EaseOut2 },
			{ AnimCurve.EaseOut3, EaseOut3 },
			{ AnimCurve.EaseOut4, EaseOut4 },
			{ AnimCurve.EaseOut5, EaseOut5 },
			{ AnimCurve.EaseInOut2, EaseInOut2 },
			{ AnimCurve.EaseInOut3, EaseInOut3 },
			{ AnimCurve.EaseInOut4, EaseInOut4 },
			{ AnimCurve.EaseInOut5, EaseInOut5 },
			{ AnimCurve.EaseInSine, EaseInSine },
			{ AnimCurve.EaseOutSine, EaseOutSine },
			{ AnimCurve.EaseInOutSine, EaseInOutSine },
			{ AnimCurve.EaseInExpo, EaseInExpo },
			{ AnimCurve.EaseOutExpo, EaseOutExpo },
			{ AnimCurve.EaseInOutExpo, EaseInOutExpo },
			{ AnimCurve.EaseInCirc, EaseInCirc },
			{ AnimCurve.EaseOutCirc, EaseOutCirc },
			{ AnimCurve.EaseInOutCirc, EaseInOutCirc },
			{ AnimCurve.EaseInBack, EaseInBack },
			{ AnimCurve.EaseOutBack, EaseOutBack },
			{ AnimCurve.EaseInOutBack, EaseInOutBack },
			{ AnimCurve.EaseInBounce, EaseInBounce },
			{ AnimCurve.EaseOutBounce, EaseOutBounce },
			{ AnimCurve.EaseInOutBounce, EaseInOutBounce },
			{ AnimCurve.EaseInElastic, EaseInElastic },
			{ AnimCurve.EaseOutElastic, EaseOutElastic },
			{ AnimCurve.EaseInOutElastic, EaseInOutElastic },
			{ AnimCurve.StepStart, StepStart },
			{ AnimCurve.StepMiddle, StepMiddle },
			{ AnimCurve.StepEnd, StepEnd },
			{ AnimCurve.StepsStart3, StepsStart3 },
			{ AnimCurve.StepsStart4, StepsStart4 },
			{ AnimCurve.StepsStart5, StepsStart5 },
			{ AnimCurve.StepsStart6, StepsStart6 },
			{ AnimCurve.StepsStart7, StepsStart7 },
			{ AnimCurve.StepsStart8, StepsStart8 },
			{ AnimCurve.StepsStart9, StepsStart9 },
			{ AnimCurve.StepsStart10, StepsStart10 },
			{ AnimCurve.StepsStart11, StepsStart11 },
			{ AnimCurve.StepsStart12, StepsStart12 },
			{ AnimCurve.StepsStart13, StepsStart13 },
			{ AnimCurve.StepsStart14, StepsStart14 },
			{ AnimCurve.StepsStart15, StepsStart15 },
			{ AnimCurve.StepsStart16, StepsStart16 },
			{ AnimCurve.StepsEnd3, StepsEnd3 },
			{ AnimCurve.StepsEnd4, StepsEnd4 },
			{ AnimCurve.StepsEnd5, StepsEnd5 },
			{ AnimCurve.StepsEnd6, StepsEnd6 },
			{ AnimCurve.StepsEnd7, StepsEnd7 },
			{ AnimCurve.StepsEnd8, StepsEnd8 },
			{ AnimCurve.StepsEnd9, StepsEnd9 },
			{ AnimCurve.StepsEnd10, StepsEnd10 },
			{ AnimCurve.StepsEnd11, StepsEnd11 },
			{ AnimCurve.StepsEnd12, StepsEnd12 },
			{ AnimCurve.StepsEnd13, StepsEnd13 },
			{ AnimCurve.StepsEnd14, StepsEnd14 },
			{ AnimCurve.StepsEnd15, StepsEnd15 },
			{ AnimCurve.StepsEnd16, StepsEnd16 }
		};

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
			double interpolated = mappings[this.InterpolationIn](fac);
			return outMin + interpolated * (outMax - outMin);
		}

		public double ValueOut(long ms, int outMin = 0, int outMax = 1) {
			double t = (double)ms / Math.Max(1, this.TimeOut);
			double fac = Math.Max(0, Math.Min(t, 1));
			double interpolated = mappings[this.InterpolationOut](fac);
			return outMin + interpolated * (outMax - outMin);
		}
	}
}
