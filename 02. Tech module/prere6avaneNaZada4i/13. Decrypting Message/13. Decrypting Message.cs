using System;


namespace _13.Decrypting_Message
{
    class DecryptingMessage

    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                text += (char)(letter + key);
            }

            Console.WriteLine(text);
        }
    }
}
