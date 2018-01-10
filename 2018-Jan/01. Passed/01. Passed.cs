namespace _01.Passed
{

    using System;


    public class Problem01
    {

        public static void Main()
        {

            var grade = float.Parse(Console.ReadLine());

            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }

        }
    }
}
