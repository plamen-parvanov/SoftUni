using System;


namespace _04___Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var totalElectricity = 0.0;
            var totalWater = 0;
            var totalInternet = 0;
            var totalOthers = 0.0;

            for (int i = 0; i < n; i++)
            {
                var electicity = double.Parse(Console.ReadLine());
                totalElectricity += electicity;
                totalWater += 20;
                totalInternet += 15;
                totalOthers += 1.2 * (electicity + 35);
            }
            var average = (totalElectricity + totalWater + totalInternet + totalOthers) / n;
            Console.WriteLine("Electricity: {0:f2} lv", totalElectricity);
            Console.WriteLine("Water: {0:f2} lv", totalWater);
            Console.WriteLine("Internet: {0:f2} lv", totalInternet);
            Console.WriteLine("Other: {0:f2} lv", totalOthers);
            Console.WriteLine("Average: {0:f2} lv", average);







        }
    }
}
