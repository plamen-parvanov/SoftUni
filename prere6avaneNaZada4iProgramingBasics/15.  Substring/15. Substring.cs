using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());

        
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'p')
            {
                hasMatch = true;

                int endIndex = count + 1;

                if (endIndex + i > text.Length)
                {
                    endIndex = text.Length - 1;
                }

                string matchedString = text.Substring(i, count);
                Console.WriteLine(matchedString);
                i += count;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
