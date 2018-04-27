namespace _02.Multiply_an_Array_of_Doubles
{

    using System;


    public class Problem02
    {

        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var doubleArr = new double[input.Length];

            InitializeDoubleArr(input, doubleArr);

            MultiplyArrayByP(doubleArr);

            Console.WriteLine(string.Join(" ", doubleArr));

        }

        public static void InitializeDoubleArr(string[] input, double[] doubleArr)
        {
            for (int i = 0; i < input.Length; i++)
            {
                doubleArr[i] = double.Parse(input[i]);
            }
        }

        public static void MultiplyArrayByP(double[] doubleArr)
        {
            var multiplier = double.Parse(Console.ReadLine());

            for (int i = 0; i < doubleArr.Length; i++)
            {
                doubleArr[i] *= multiplier;
            }
        }
    }
}
