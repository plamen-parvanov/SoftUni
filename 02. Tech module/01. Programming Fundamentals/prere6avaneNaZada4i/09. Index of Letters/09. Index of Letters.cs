namespace _09.Index_of_Letters
{
    using System;
    using System.Linq;


    public class Arrays
    {

        public static void Main()
        {

            var input = Console.ReadLine().ToArray();

            var charArr = new char['z' - 'a' + 1];
            for (int i = 0; i < charArr.Length; i++)
            {
                charArr[i] = (char)('a' + i);
            }

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < charArr.Length; j++)
                {
                    if (input[i] == charArr[j])
                    {
                        Console.WriteLine("{0} -> {1}", input[i], j);
                    }
                }
            }




        }
    }
}
