using System;


namespace Problem06_MagicCombination.docx
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());


            for (int i = 111111; i <= 999999; i++)
            {
                int sixth = i % 10;
                int fifth = (i / 10) % 10;
                int forth = (i / 100) % 10;
                int third = (i / 1000) % 10;
                int second = (i / 10000) % 10;
                int first = (i / 100000) % 10;

                if (first * second * third * forth * fifth * sixth == a)
                {
                    Console.Write("{0}{1}{2}{3}{4}{5} ", first, second, third, forth, fifth, sixth);
                }
            }
            Console.WriteLine();
        }
    }
}
