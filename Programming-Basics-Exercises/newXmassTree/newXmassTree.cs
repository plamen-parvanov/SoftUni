using System;


namespace newXmassTree
{
    class newXmassTree
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n + 1 ; i++)
            {
                var spaces = new string(' ', n - i);        // ediniqt variant kato suzdadem predvaritelno string spaces
                Console.Write(spaces);
                Console.Write(new string ('*', i));         // drugiqt variant kato direktno mu kajem kakvo da pe4ati
                Console.Write(" | ");
                Console.WriteLine(new string('*', i));

            }
        }
    }
}
