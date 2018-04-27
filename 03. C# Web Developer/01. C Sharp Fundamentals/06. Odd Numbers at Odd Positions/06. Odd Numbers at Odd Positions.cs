namespace _06.Odd_Numbers_at_Odd_Positions
{

    using System;


    public class Problem06
    {

        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var strArr = inputLine.Split();
            var intArr = new int[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                intArr[i] = int.Parse(strArr[i]);
            }

            for (int i = 1; i < intArr.Length; i += 2)
            {
                if (intArr[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {intArr[i]}");
                }
            }

        }
    }
}
