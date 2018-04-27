namespace _06.Power_Plants
{
    using System;


    public class Array
    {

        public static void Main()
        {
            string input = Console.ReadLine();
            string[] inputSplited = input.Split(' ');

            int[] plantsArr = new int[input.Length];

            for (int i = 0; i < inputSplited.Length; i++)
            {
                plantsArr[i] = int.Parse(inputSplited[i]);
            }

            int alivePlants = 1;
            int days = 0;

            while (alivePlants != 0)
            {
                for (int i = 0; i < plantsArr.Length; i++)
                {
                    plantsArr[i]--;

                    if (i == days)
                    {
                        plantsArr[i]++;
                    }

                    days++;
                }
            } 

        }
    }
}
