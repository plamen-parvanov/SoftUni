using System;


namespace _02.Sudoku_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            int totalTime = 0;
            double numberGames = 0d;
            double averageTime = 0.0;
            while (text != "Quit")
            {                
                int min = int.Parse(text.Substring(0, 2));
                int sec = int.Parse(text.Substring(3, 2));
                totalTime += min * 60 + sec;
                numberGames++;
                text = Console.ReadLine();
            }
            averageTime = Math.Ceiling(totalTime / numberGames);
            if (averageTime > 1440)
            {
                Console.WriteLine("Bronze Star");
            }
            else if (averageTime >= 720 )
            {
                Console.WriteLine("Silver Star");
            }
            else
            {
                Console.WriteLine("Gold Star");
            }

            Console.WriteLine("Games - {0} \\ Average seconds - {1}", numberGames, averageTime);

        }
    }
}
