using System;


namespace ConsoleApplication205.Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numInBase10 = int.Parse(Console.ReadLine());
            int nBase = int.Parse(Console.ReadLine());

            string numberInBaseN = NumberInBaseN(numInBase10, nBase);

            Console.WriteLine(numberInBaseN);
        }

        static string NumberInBaseN(int numInBase10, int nBase)
        {
        int divisible = numInBase10;
        int result = 1;      
        string numberInBaseN = string.Empty;

            while (result != 0)
            {
                result = divisible  / nBase;
                int remainder = divisible  - nBase* result;
                divisible  = result;
                numberInBaseN = remainder + numberInBaseN;     
            }

            //numberInBaseN = Reverse(numberInBaseN);
            return numberInBaseN;
            }

        // static string Reverse(string s)
        //{
        //    char[] charArray = s.ToCharArray();
        //    Array.Reverse(charArray);
        //    return new string(charArray);
        //}
    }
}
