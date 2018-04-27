namespace _06.Triples_of_Latin_Letters
{

    using System;


    public class Problem06
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine()) + 'a';

            for (char i = 'a'; i < n; i++)
            {
                for (char j = 'a'; j < n; j++)
                {
                    for (char k = 'a'; k < n; k++)
                    {
                        Console.WriteLine("{0}{1}{2}", i, j, k);
                    }
                }
            }
        }
    }
}
