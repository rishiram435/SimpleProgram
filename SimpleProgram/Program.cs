using System;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intialization of c
            double c;
            // Intialization of f
            double f = 98.6;

            // Converting the Fahrenheit Scale to Celsius Scale
            c = (f - 32) * 5 / 9;

            Console.WriteLine("The conversion of the Fahrenheit Scale to Celsius Scale: "+c+ "°C");
        }
    }
}
