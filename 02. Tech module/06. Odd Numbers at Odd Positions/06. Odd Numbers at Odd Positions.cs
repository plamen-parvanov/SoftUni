namespace _06.Odd_Numbers_at_Odd_Positions
{

    using System;
    using System.Linq;


    public class Arrays
    {

        public static void Main()
        {
            var intArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < intArr.Length; i++)
            {
                if (i % 2 != 0 && intArr[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {intArr[i]}");
                }
            }
        }
    }
}
