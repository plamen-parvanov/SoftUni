using System;


namespace _03.Count_of_Given_Element_in_Array

{
    class Program
    {
        static void Main()
        {
            string stringIntegers = Console.ReadLine();
            int elemnt = int.Parse(Console.ReadLine());

            string[] integers = stringIntegers.Split(' ');
            int[] intArr = new int[integers.Length];
            int cntrElement = 0;

            CopyStrinArrToIntArr(integers, intArr);

            cntrElement = SearchForElement(elemnt, intArr, cntrElement);

            Console.WriteLine(cntrElement);
        }

        private static void CopyStrinArrToIntArr(string[] integers, int[] intArr)
        {
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = int.Parse(integers[i]);
            }
        }

        private static int SearchForElement(int elemnt, int[] intArr, int cntrElement)
        {
            foreach (var number in intArr)
            {
                if (number == elemnt)
                {
                    cntrElement++;
                }
            }

            return cntrElement;
        }
    }
}
