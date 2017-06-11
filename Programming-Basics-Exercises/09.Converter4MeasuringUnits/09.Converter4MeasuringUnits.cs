using System;


namespace _09.Converter4MeasuringUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var firstUnit = Console.ReadLine();
            var secondUnit = Console.ReadLine();

            var a = 0d;
            var b = 0d;


            var meter = 1d;
            var millimeters = 1000d;
            var centimeters = 100d;
            var miles = 0.000621371192d;
            var inches = 39.3700787d;
            var kilometers = 0.001d;
            var feet = 3.2808399d;
            var yards = 1.0936133d;

            if (firstUnit == "m")
                a = meter;

            else if (firstUnit == "mm")
                a = millimeters;

            else if (firstUnit == "cm")
                a = centimeters;

            else if (firstUnit == "mi")
                a = miles;

            else if (firstUnit == "in")
                a = inches;

            else if (firstUnit == "km")
                a = kilometers;

            else if (firstUnit == "ft")
                a = feet;

            else if (firstUnit == "yd")
                a = yards;


            if (secondUnit == "m")
                b = meter;

            else if (secondUnit == "mm")
                b = millimeters;

            else if (secondUnit == "cm")
                b = centimeters;

            else if (secondUnit == "mi")
                b = miles;

            else if (secondUnit == "in")
                b = inches;

            else if (secondUnit == "km")
                b = kilometers;

            else if (secondUnit == "ft")
                b = feet;

            else if (secondUnit == "yd")
                b = yards;


            var result = value * (a / b);
            Console.WriteLine(result + " " + secondUnit);

             
        }
    }
}
