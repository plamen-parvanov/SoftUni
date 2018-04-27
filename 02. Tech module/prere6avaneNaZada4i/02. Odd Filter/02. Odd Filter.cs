namespace _02.Odd_Filter
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Dictionaries
    {

        public static void Main()
        {
            var numArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
           
            var numList = numArr.ToList();
            numList.RemoveAll(n => n % 2 != 0);

            var average = numList.Average();

            numList = numList.Select(x => x > average ? x += 1 : x -= 1).ToList();

            Console.WriteLine(string.Join(" ", numList));

            

           

        }
    }
}
