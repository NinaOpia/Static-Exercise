using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		public static double FahrenheitToCelsius(double fTemp)
		{
			//Please Excuse My Dear Aunt Sally
			var celTemp = Math.Round((fTemp - 32) * (5.0 / 9.0), 2);

			return celTemp;
		}

		public static double CelsiusToFahrenheit(double celTemp)
		{
			return Math.Round(celTemp * (9d / 5d) + 32, 2);
		}
	}

}
