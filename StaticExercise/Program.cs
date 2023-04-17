namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature in F you want to convert?");
            double fahTemp = Convert.ToDouble(Console.ReadLine());
            var convertedToCel = TempConverter.FahrenheitToCelsius(fahTemp);

            Console.WriteLine($"That equals {convertedToCel} degrees Celsius\n");

            Console.WriteLine("What is the temperature in C you want to convert?");
            var celTemp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"That equals {TempConverter.CelsiusToFahrenheit(celTemp)} degress Fahrenheit"); 
        }            
    }
}
