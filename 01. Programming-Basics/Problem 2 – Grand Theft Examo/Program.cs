using System;


namespace Problem_2___Grand_Theft_Examo
{
    class Program
    {
        static void Main(string[] args)
        {
            int attemps = int.Parse(Console.ReadLine());
            int slapped = 0;
            long drunk = 0;         // za6toto moje da ima int.MaxValue(beers) + su6toto i togava  int 6te prelee
            long escaped = 0;       // za6toto moje da ima int.MaxValue(thieves) + su6toto i togava int 6te prelee

            for (int i = 0; i < attemps; i++)
            {
                int thieves = int.Parse(Console.ReadLine());
                int beers = int.Parse(Console.ReadLine());

                if (thieves <= 5)
                {
                    slapped += thieves;
                    drunk += beers;
                }
                else
                {
                    slapped += 5;
                    escaped += thieves - 5;
                    drunk += beers;
                }
            }
            Console.WriteLine("{0} thieves slapped.\n{1} thieves escaped.\n{2} packs, {3} bottles.",
                slapped, escaped, drunk / 6, drunk % 6);
        }
    }
}
