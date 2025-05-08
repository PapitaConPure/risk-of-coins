using System;
using System.Collections.Generic;

namespace WinFormsPopups {
	internal static class InterpolationHelper {
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

		internal static IReadOnlyDictionary<AnimCurve, InterpolationFn> Mappings => mappings;

		/// <summary>
		/// Delegate to define an interpolation function.
		/// </summary>
		/// <param name="t"></param>
		/// <returns></returns>
		internal delegate double InterpolationFn(double t);

		public static InterpolationFn Linear = t => t;

		public static InterpolationFn EaseIn2 = t => t * t;

		public static InterpolationFn EaseIn3 = t => t * t * t;

		public static InterpolationFn EaseIn4 = t => t * t * t * t;

		public static InterpolationFn EaseIn5 = t => t * t * t * t * t;

		public static InterpolationFn EaseOut2 = t => 1 - Math.Pow(1 - t, 2);

		public static InterpolationFn EaseOut3 = t => 1 - Math.Pow(1 - t, 3);

		public static InterpolationFn EaseOut4 = t => 1 - Math.Pow(1 - t, 4);

		public static InterpolationFn EaseOut5 = t => 1 - Math.Pow(1 - t, 5);

		public static InterpolationFn EaseInOut2 = t => t < 0.5 ? 2 * t * t : 1 - Math.Pow(-2 * t + 2, 2) / 2;

		public static InterpolationFn EaseInOut3 = t => t < 0.5 ? 4 * t * t * t : 1 - Math.Pow(-2 * t + 2, 3) / 2;

		public static InterpolationFn EaseInOut4 = t => t < 0.5 ? 8 * t * t * t * t : 1 - Math.Pow(-2 * t + 2, 4) / 2;

		public static InterpolationFn EaseInOut5 = t => t < 0.5 ? 16 * t * t * t * t * t : 1 - Math.Pow(-2 * t + 2, 5) / 2;

		public static InterpolationFn EaseInSine = t => 1 - Math.Cos(t * Math.PI / 2);

		public static InterpolationFn EaseOutSine = t => Math.Sin(t * Math.PI / 2);

		public static InterpolationFn EaseInOutSine = t => -(Math.Cos(Math.PI * t) - 1) / 2;

		public static InterpolationFn EaseInExpo = t => Math.Pow(2, 10 * (t - 1));

		public static InterpolationFn EaseOutExpo = t => 1 - Math.Pow(2, -10 * t);

		public static InterpolationFn EaseInOutExpo = t => t < 0.5 ? Math.Pow(2, 10 * (t - 1)) / 2 : (2 - Math.Pow(2, -10 * t)) / 2;

		public static InterpolationFn EaseInCirc = t => 1 - Math.Sqrt(1 - Math.Pow(t, 2));

		public static InterpolationFn EaseOutCirc = t => Math.Sqrt(1 - Math.Pow(t - 1, 2));

		public static InterpolationFn EaseInOutCirc = t => t < 0.5 ? (1 - Math.Sqrt(1 - Math.Pow(2 * t, 2))) / 2 : (Math.Sqrt(1 - Math.Pow(-2 * t + 2, 2)) + 1) / 2;

		public static InterpolationFn EaseInBack = t => 2.70158 * t * t * t - 1.70158 * t * t;

		public static InterpolationFn EaseOutBack = t => 1 + 2.70158 * Math.Pow(t - 1, 3) + 1.70158 * Math.Pow(t - 1, 2);

		public static InterpolationFn EaseInOutBack = t => t < 0.5 ? Math.Pow(2 * t, 2) * ((2.5949095 + 1) * 2 * t - 2.5949095) / 2 : (Math.Pow(2 * t - 2, 2) * ((2.5949095 + 1) * (t * 2 - 2) + 2.5949095) + 1) / 2;

		public static InterpolationFn EaseInBounce = t => 1 - EaseOutBounce(1 - t);

		public static InterpolationFn EaseOutBounce = t => {
			if (t < 1 / 2.75) {
				return 7.5625 * t * t;
			} else if (t < 2 / 2.75) {
				t -= 1.5 / 2.75;
				return 7.5625 * t * t + .75;
			} else if (t < 2.5 / 2.75) {
				t -= 2.25 / 2.75;
				return 7.5625 * t * t + .9375;
			} else {
				t -= 2.625 / 2.75;
				return 7.5625 * t * t + .984375;
			}
		};

		public static InterpolationFn EaseInOutBounce = t => t < 0.5 ? (1 - EaseOutBounce(1 - 2 * t)) / 2 : (1 + EaseOutBounce(2 * t - 1)) / 2;

		public static InterpolationFn EaseInElastic = t => {
			if (t == 0 || t == 1) {
				return t;
			} else {
				double p = 0.3;
				double s = p / 4;
				t -= 1;
				return -(Math.Pow(2, 10 * t) * Math.Sin((t - s) * (2 * Math.PI) / p));
			}
		};

		public static InterpolationFn EaseOutElastic = t => {
			if (t == 0 || t == 1) {
				return t;
			} else {
				double p = 0.3;
				double s = p / 4;
				return Math.Pow(2, -10 * t) * Math.Sin((t - s) * (2 * Math.PI) / p) + 1;
			}
		};

		public static InterpolationFn EaseInOutElastic = t => {
			if (t == 0 || t == 1) {
				return t;
			} else {
				double p = 0.3 * 1.5;
				double s = p / 4;
				t -= 1;
				if (t < 0) {
					return Math.Pow(2, 10 * t) * Math.Sin((t - s) * (2 * Math.PI) / p) / 2;
				} else {
					return Math.Pow(2, -10 * t) * Math.Sin((t - s) * (2 * Math.PI) / p) / 2 + 1;
				}
			}
		};

		public static InterpolationFn StepStart = t => t < 1 ? 0 : 1;

		public static InterpolationFn StepMiddle = t => t < 0.5 ? 0 : 1;

		public static InterpolationFn StepEnd = t => t > 0 ? 1 : 0;

		public static InterpolationFn StepsStart3 = t => Math.Floor(t * 3) / 2;

		public static InterpolationFn StepsStart4 = t => Math.Floor(t * 4) / 3;

		public static InterpolationFn StepsStart5 = t => Math.Floor(t * 5) / 4;

		public static InterpolationFn StepsStart6 = t => Math.Floor(t * 6) / 5;

		public static InterpolationFn StepsStart7 = t => Math.Floor(t * 7) / 6;

		public static InterpolationFn StepsStart8 = t => Math.Floor(t * 8) / 7;

		public static InterpolationFn StepsStart9 = t => Math.Floor(t * 9) / 8;

		public static InterpolationFn StepsStart10 = t => Math.Floor(t * 10) / 9;

		public static InterpolationFn StepsStart11 = t => Math.Floor(t * 11) / 10;

		public static InterpolationFn StepsStart12 = t => Math.Floor(t * 12) / 11;

		public static InterpolationFn StepsStart13 = t => Math.Floor(t * 13) / 12;

		public static InterpolationFn StepsStart14 = t => Math.Floor(t * 14) / 13;

		public static InterpolationFn StepsStart15 = t => Math.Floor(t * 15) / 14;

		public static InterpolationFn StepsStart16 = t => Math.Floor(t * 16) / 15;

		public static InterpolationFn StepsEnd3 = t => Math.Ceiling(t * 3) / 2;

		public static InterpolationFn StepsEnd4 = t => Math.Ceiling(t * 4) / 3;

		public static InterpolationFn StepsEnd5 = t => Math.Ceiling(t * 5) / 4;

		public static InterpolationFn StepsEnd6 = t => Math.Ceiling(t * 6) / 5;

		public static InterpolationFn StepsEnd7 = t => Math.Ceiling(t * 7) / 6;

		public static InterpolationFn StepsEnd8 = t => Math.Ceiling(t * 8) / 7;

		public static InterpolationFn StepsEnd9 = t => Math.Ceiling(t * 9) / 8;

		public static InterpolationFn StepsEnd10 = t => Math.Ceiling(t * 10) / 9;

		public static InterpolationFn StepsEnd11 = t => Math.Ceiling(t * 11) / 10;

		public static InterpolationFn StepsEnd12 = t => Math.Ceiling(t * 12) / 11;

		public static InterpolationFn StepsEnd13 = t => Math.Ceiling(t * 13) / 12;

		public static InterpolationFn StepsEnd14 = t => Math.Ceiling(t * 14) / 13;

		public static InterpolationFn StepsEnd15 = t => Math.Ceiling(t * 15) / 14;

		public static InterpolationFn StepsEnd16 = t => Math.Ceiling(t * 16) / 15;
	}
}
