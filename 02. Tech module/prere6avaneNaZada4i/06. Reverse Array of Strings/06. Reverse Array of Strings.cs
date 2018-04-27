using System;


namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] textArr = input.Split(' ');
            string[] reversedText = textArr;
            int arrLenght = textArr.Length;

            

            for (int i = 0; i < arrLenght / 2; i++)
            {
                string temp = reversedText[i];
                reversedText[i] = textArr[arrLenght -1 - i];
                textArr[arrLenght - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", reversedText));
        }
    }
}
