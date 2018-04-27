namespace _13.Game_of_Numbers
{

    using System;


    public class Problem13
    {

        public static void Main()
        {

            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());

            var combinations = 0;

            for (int i = num2; i >= num1; i--)
            {
                for (int j = num2; j >= num1; j--)
                {
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicNum}");

                        return;
                    }

                    combinations++;
                }
            }

            Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");

        }
    }
}
