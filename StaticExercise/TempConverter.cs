using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		public static double FahrenheitToCelsius(double fTemp)
		{
			//Please Excuse My Dear Aunt Sally
			var celTemp = Math.Round((fTemp - 32) * (5 / 9), 4);

			return celTemp;
		}

		public static double CelsiusToFahrenheit(double celTemp)
		{
			return Math.Round(celTemp * (9 / 5) + 32, 2);
		}
	}

}
