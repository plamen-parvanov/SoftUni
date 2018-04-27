namespace _11.Equal_Sumss
{
    using System;
    using System.Linq;

    public class Arrays
    {

        public static void Main()
        {
            var numberArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

          
            bool isSuchNumber = false;

            for (int i = 0; i < numberArr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += numberArr[j];
                }

                for (int k = i + 1; k < numberArr.Length; k++)
                {
                    rightSum += numberArr[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isSuchNumber = true;
                }
            }

            if (!isSuchNumber)
            {
                Console.WriteLine("no");
            }

        }
    }
}
