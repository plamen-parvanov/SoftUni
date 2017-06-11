using System;

namespace _04___Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());
            var lectorJelev = 0;
            var lectorRoYaL = 0;
            var lectorRoli = 0;
            var lectorTrofon = 0;
            var lectorSino = 0;
            var lectorOthers = 0;

            for (int i = 0; i < n; i++)
            {
                var lector = Console.ReadLine();

                if (lector == "Jelev")
                {
                    lectorJelev += 1;
                }
                else if (lector == "RoYaL")
                {
                    lectorRoYaL += 1;
                }
                else if (lector == "Roli")
                {
                    lectorRoli += 1;
                }
                else if (lector == "Trofon")
                {
                    lectorTrofon += 1;
                }
                else if (lector == "Sino")
                {
                    lectorSino += 1;
                }
                else
                {
                    lectorOthers += 1;
                }
            }
           var paymentPerL = budget / n;
            Console.WriteLine("Jelev salary: {0:f2} lv", paymentPerL * lectorJelev);
            Console.WriteLine("RoYaL salary: {0:f2} lv", paymentPerL * lectorRoYaL);
            Console.WriteLine("Roli salary: {0:f2} lv", paymentPerL * lectorRoli);
            Console.WriteLine("Trofon salary: {0:f2} lv", paymentPerL * lectorTrofon);
            Console.WriteLine("Sino salary: {0:f2} lv", paymentPerL * lectorSino);
            Console.WriteLine("Others salary: {0:f2} lv", paymentPerL * lectorOthers);

        }
    }
}
