namespace _02.Passed_or_Failed
{

    using System;


    public class Problem02
    {

        public static void Main()
        {

            var grade = float.Parse(Console.ReadLine());

            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }

        }
    }
}
