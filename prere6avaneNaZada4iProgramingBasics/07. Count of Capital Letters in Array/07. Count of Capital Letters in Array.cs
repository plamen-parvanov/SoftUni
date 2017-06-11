using System;


namespace _07.Count_of_Capital_Letters_in_Array
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

         
            char[] charArr = new char[text.Length];
            FillingCharArr(text, charArr);

            int countCapitalLetters = CountsCapitalLetters(charArr);

            Console.WriteLine(countCapitalLetters);
        }

        private static int CountsCapitalLetters(char[] charArr)
        {
            int countCapitalLetters = 0;

            foreach (var symbol in charArr)
            {
                if (symbol >= 'A' && symbol <= 'Z')
                {
                    countCapitalLetters++;
                }
            }

            return countCapitalLetters;
        }

        private static void FillingCharArr(string text, char[] charArr)
        {
            for (int i = 0; i < charArr.Length; i++)
            {
                charArr[i] = text[i];
            }
        }
    }
}
