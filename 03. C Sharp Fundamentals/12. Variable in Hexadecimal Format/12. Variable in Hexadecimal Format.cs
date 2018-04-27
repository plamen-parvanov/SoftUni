namespace _12.Variable_in_Hexadecimal_Format
{

    using System;


    public class Problem12
    {

        public static void Main()
        {
            var input = Console.ReadLine();

            var convertToNumber = Convert.ToInt32(input, 16);

            Console.WriteLine(convertToNumber);
        }
    }
}
