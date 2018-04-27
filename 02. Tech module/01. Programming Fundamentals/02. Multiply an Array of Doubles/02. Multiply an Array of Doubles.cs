namespace _02.Multiply_an_Array_of_Doubles
{

    using System;
    using System.Linq;

    public class Arrays
    {

        public static void Main()
        {
            var doubleArr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var p = double.Parse(Console.ReadLine());

            for (int i = 0; i < doubleArr.Length; i++)
            {
                doubleArr[i] *= p;
            }

            Console.WriteLine(string.Join(" ", doubleArr));
        }
    }
}
