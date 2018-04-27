namespace _06.Reverse_Array_of_Strings_Lab
{
    using System;


    public class Program
    {

        public static void Main()
        {
            string input = Console.ReadLine();
            string[] stringArr = input.Split(' ');

            ReaverseStringArr(stringArr);

            Console.WriteLine(string.Join(" ", stringArr));
        }

        public static void ReaverseStringArr(string[] stringArr)
        {
            for (int i = 0; i < stringArr.Length / 2; i++)
            {
                string temp = stringArr[i];
                stringArr[i] = stringArr[stringArr.Length - 1 - i];
                stringArr[stringArr.Length - 1 - i] = temp;
            }
        }

    }
}
