namespace _05.Sort_Numbers
{
    using System;
    using System.Linq;


    public class Lists
    {

        public static void Main()
        {
            var numList = Console.ReadLine().Split().Select(double.Parse).ToList();

            numList.Sort();

            Console.WriteLine(string.Join(" <= ", numList));



        }
    }
}
