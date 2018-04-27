using System;


namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main()
        {
            string numberInHex = Console.ReadLine();
            int number = Convert.ToInt32(numberInHex, 16);
            Console.WriteLine(number);
        }
    }
}
