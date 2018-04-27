using System;

namespace za_proba
{
    class Program
    {
        static void Main()
        {
            string text = "Pesho";

            char[] charArr = new char[text.Length];

            for (int i = 0; i < charArr.Length; i++)
            {
                charArr[i] = text[i];
                Console.WriteLine(charArr[i]);
            }


        }
    }
}
