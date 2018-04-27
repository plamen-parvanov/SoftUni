namespace _03.Smallest_Element_in_Array
{

    using System;
    using System.Linq;


    public class Arrays
    {

        public static void Main()
        {
            var intArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var smallestNum = int.MaxValue;

            foreach (var number in intArr)
            {
                if (number < smallestNum)
                {
                    smallestNum = number;
                }
            }

            Console.WriteLine(smallestNum);

        }
    }
}
