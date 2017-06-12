namespace _04.Grab_and_Go
{
    using System;
    using System.Linq;

    public class Arrays
    {

        public static void Main()
        {
            var numbersArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int specialNumber = int.Parse(Console.ReadLine());

            long sum = 0;
            bool haveSpacialNum = false;

            for (int i = numbersArr.Length - 1; i >= 0; i--)
            {
                if (haveSpacialNum)
                {
                    sum += numbersArr[i];
                }

                if (numbersArr[i] == specialNumber)
                {
                    haveSpacialNum = true;
                }
               
            }

            if (haveSpacialNum)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }

        }
    }
}
