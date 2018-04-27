using System;


namespace _11.String_Concatenation
{
    class StringConcatenation

    {
        static void Main()
        {
            char separator = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine();

            byte temp = 1;
            if (evenOrOdd == "even")
            {
                temp = 0;
            }

            byte n = byte.Parse(Console.ReadLine());
            string text = string.Empty;


            for (int i = 1; i < n + 1; i++)
            {
                string word = Console.ReadLine();

                if (i % 2 == temp)
                {
                    text += word + separator;
                }
            }
            text = text.Remove(text.Length - 1, 1);
            Console.WriteLine(text);

        }
    }
}
