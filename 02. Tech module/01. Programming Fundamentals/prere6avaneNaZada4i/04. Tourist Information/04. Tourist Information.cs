using System;


namespace _04.Tourist_Information
{
    class TouristInformation

    {
        static void Main()
        {
            string imperialUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            double resultValue = 0;
            string resultUnit = string.Empty;

            switch (imperialUnit)
            {
                case "miles":
                    resultValue = value * 1.6;
                    resultUnit = "kilometers";
                    break;
                case "inches":
                    resultValue = value * 2.54;
                    resultUnit = "centimeters";
                    break;
                case "feet":
                    resultValue = value * 30d;
                    resultUnit = "centimeters";
                    break;
                case "yards":
                    resultValue = value * 0.91;
                    resultUnit = "meters";
                    break;
                case "gallons":
                    resultValue = value * 3.8;
                    resultUnit = "liters";
                    break;
            }
            Console.WriteLine($"{value} {imperialUnit} = {resultValue:f2} {resultUnit}");
        }
    }
}
