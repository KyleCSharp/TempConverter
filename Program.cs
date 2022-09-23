using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("give me a number to convert F to C");
            var celcius = TempConverter.FahrenheitToCelsius(int.Parse(Console.ReadLine())); //used console.readline for fun
            Console.WriteLine($"celcius = {celcius}");


            var fahrenheit = TempConverter.CelsiusToFahrenheit(0);
            Console.WriteLine($"fahrenheit = {fahrenheit}");
        }
    }
}
