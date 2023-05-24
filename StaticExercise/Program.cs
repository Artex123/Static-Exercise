namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelcius(68);
            Console.WriteLine($"celsius {celsius}");
            
            var fahrenheit = TempConverter.CelsiusToFahrenheit(0);
            Console.WriteLine($"Fahrenheit {fahrenheit}");
        }
    }
}
