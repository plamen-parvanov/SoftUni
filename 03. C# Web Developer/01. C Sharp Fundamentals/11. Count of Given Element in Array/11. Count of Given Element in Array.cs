namespace _11.Count_of_Given_Element_in_Array
{

    using System;

    public class Problem11
    {

        public static void Main()
        {
            var input = Console.ReadLine();
            var element = int.Parse(Console.ReadLine());

            var intArr = InitializeIntArr(input);

            var result = CountGivenEllInnArr(intArr, element);

            Console.WriteLine(result);
        }

        public static int[] InitializeIntArr(string input)
        {
            var strArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var intArr = new int[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                intArr[i] = int.Parse(strArr[i]);
            }

            return intArr;
        }

        public static int CountGivenEllInnArr(int[] intArr, int element)
            {
            var elementCntr = 0;

            foreach (var num in intArr)
            {
                if (num == element)
                {
                    elementCntr++;
                }
}
return elementCntr;
}
    }
}
