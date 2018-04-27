namespace _05.Sort_Numbers
{

    using System;
    using System.Collections.Generic;

    public class Problem05
    {

        public static void Main()
        {
            var input = Console.ReadLine();
            var decimalList = InitializeList(input);

            decimalList.Sort();

            Console.WriteLine(string.Join(" <= ", decimalList));
        }

        public static List<decimal> InitializeList(string input)
        {
            var splitBy = new[] { ' ' };
            var strArr = input.Split(splitBy);
            var list = new List<decimal>();

            foreach (var str in strArr)
            {
                list.Add(decimal.Parse(str));
            }

            return list;
        }

    }
}
