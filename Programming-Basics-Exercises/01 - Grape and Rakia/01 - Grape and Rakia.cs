using System;


namespace _01___Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            var vineyard = double.Parse(Console.ReadLine());
            var kgFromMM = double.Parse(Console.ReadLine());
            var lost = double.Parse(Console.ReadLine());
            var kgGrapes = vineyard * kgFromMM;
            var profitRakia = (kgGrapes - lost) * 0.45 / 7.5 * 9.8;
            var profitGrapes = (kgGrapes - lost) * 0.55 * 1.5;

            Console.WriteLine("{0:f2}\n{1:f2}", profitRakia, profitGrapes); 

        }
    }
}
