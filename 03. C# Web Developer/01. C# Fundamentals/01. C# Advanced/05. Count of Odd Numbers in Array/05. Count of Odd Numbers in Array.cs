namespace _05.Count_of_Odd_Numbers_in_Array
{

    using System;


    public class Problem05
    {

        public static void Main()
        {
            var input = Console.ReadLine();
            var strArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var intArr = new int[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                intArr[i] = int.Parse(strArr[i]);
            }

            var oddCntr = 0;

            foreach (var num in intArr)
            {
                if (num % 2 != 0)
                {
                    oddCntr++;
                }
            }

            Console.WriteLine(oddCntr);

        }
    }
}
