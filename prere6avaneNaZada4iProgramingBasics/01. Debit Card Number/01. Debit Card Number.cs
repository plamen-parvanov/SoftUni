using System;


namespace _01.Debit_Card_Number
{
    class Program
    {
        static void Main()
        {
            int fisrtFourNums = int.Parse(Console.ReadLine());
            int secondFourNums = int.Parse(Console.ReadLine());
            int thirdFourNums = int.Parse(Console.ReadLine());
            int forthFourNums = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:d4} {1:d4} {2:d4} {3:d4}",
                fisrtFourNums, secondFourNums, thirdFourNums, forthFourNums);
        }
    }
}
