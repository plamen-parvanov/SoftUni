using System;


namespace _14.Boat_Simulator
{
    class BoatSimulator

    {
        static void Main()
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int tilesFirstBoat = 0;
            int tilesSecondBoat = 0;
            char winner = secondBoat;

            for (int i = 1; i < n + 1; i++)
            {
                string text = Console.ReadLine();

                if (text == "UPGRADE")
                {
                    firstBoat = (char)(firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                }

                BoatMoves(ref tilesFirstBoat, ref tilesSecondBoat, i, text);

                if (tilesFirstBoat >= 50)
                {
                    winner = firstBoat;
                    break;
                }
                else if (tilesSecondBoat >= 50)
                {
                    winner = secondBoat;
                    break;
                }
            }

            if (tilesFirstBoat > tilesSecondBoat)
            {
                winner = firstBoat;
            }
            else
            {
                winner = secondBoat;
            }

            Console.WriteLine(winner);
        }

        private static void BoatMoves(ref int tilesFirstBoat, ref int tilesSecondBoat, int i, string text)
        {
            if (i % 2 == 0)
            {
                tilesSecondBoat += text.Length;
            }
            else
            {
                tilesFirstBoat += text.Length;
            }
        }
    }
}
