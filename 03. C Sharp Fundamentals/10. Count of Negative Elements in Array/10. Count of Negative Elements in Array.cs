namespace _10.Count_of_Negative_Elements_in_Array
{

    using System;

    public class Problem10
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var intArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                intArr[i] = int.Parse(Console.ReadLine());
            }

            var negaticeCntr = 0;

            foreach (var num in intArr)
            {
                if (num < 0)
                {
                    negaticeCntr++;
                }
            }

            Console.WriteLine(negaticeCntr);

        }
    }
}
