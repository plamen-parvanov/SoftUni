namespace _04.Matching_Brackets
{
    using System;
    using System.Collections.Generic;

    public class Problem04
    {

        public static void Main()
        {

            int[,,] matrix =
            {
                {
                    { 1, 1 },
                    { 2, 4 }
                },
                {
                    { 5, 0},
                    { 6, 44 }
                }
            };

            Console.WriteLine(matrix[0, 1, 0]);
        }

    }
}
