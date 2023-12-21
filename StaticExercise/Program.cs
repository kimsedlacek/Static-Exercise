namespace StaticExercise
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The Tempertaure in Celsius is {TempConverter.FahrenheitToCelsius(50)} degrees.");

            Console.WriteLine($"The Temperature in Fahrenheit is {TempConverter.CelsiusToFahrenheit(30)} degrees.");
        }
    }
}
