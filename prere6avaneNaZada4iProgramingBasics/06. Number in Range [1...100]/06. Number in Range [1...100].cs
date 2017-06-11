using System;


namespace _06.Number_in_Range__1._._._100_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notBetween1and100 = true;
            int n = 0;
            while (notBetween1and100)
            {
                Console.Write("Еnter a number in the range[1...100]: ");
                n = int.Parse(Console.ReadLine());

                if (n > 0 && n < 101)
                {
                    notBetween1and100 = false;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            Console.WriteLine("The number is: {0}", n);
        }
    }
}
