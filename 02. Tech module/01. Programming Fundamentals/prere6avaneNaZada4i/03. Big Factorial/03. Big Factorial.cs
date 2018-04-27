namespace _03.Big_Factorial
{

    using System;
    using System.Numerics;


    public class ObjectsAndClasses
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 2; i < n + 1; i++)
            {
                result = result * i;
            }

            Console.WriteLine(result);
        }
    }
}
