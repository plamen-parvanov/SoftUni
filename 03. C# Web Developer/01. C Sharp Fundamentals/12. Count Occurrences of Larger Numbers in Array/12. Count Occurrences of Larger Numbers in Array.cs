namespace _12.Count_Occurrences_of_Larger_Numbers_in_Array
{

    using System;

    public class Problem12
    {

        public static void Main()
        {
            var input = Console.ReadLine();
            var strArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var doubleArr = new double[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                doubleArr[i] = double.Parse(strArr[i]);
            }

            var p = double.Parse(Console.ReadLine());
            var biggerThanPcntr = 0;

            foreach (var num in doubleArr)
            {
                if (num > p)
                {
                    biggerThanPcntr++;
                }
            }

            Console.WriteLine(biggerThanPcntr);

        }
    }
}
