namespace _03.Endurance_Rally
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Exam1
    {

        public static void Main()
        {
            var allPlayerNames = Console.ReadLine().Split();
            List<Player> listAllPlayers = AddingPlayersInfo(allPlayerNames);

            var tracks = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var checkPoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < tracks.Length; i++)
            {
                var addRemoveFuel = checkPoints.Contains(i) ? tracks[i] : -tracks[i];

                CalculatePlayersFuel(listAllPlayers, i, addRemoveFuel);

            }

            PrintPlayersResults(listAllPlayers);

        }

        public static void CalculatePlayersFuel(List<Player> listAllPlayers, int i, double addRemoveFuel)
        {
            foreach (var player in listAllPlayers)
            {

                if (player.Fuel > 0)
                {
                    player.Fuel = player.Fuel + addRemoveFuel;
                    player.TrackReached = i;
                }

            }
        }

        private static List<Player> AddingPlayersInfo(string[] allPlayerNames)
        {
            var listAllPlayers = new List<Player>();
            foreach (var player in allPlayerNames)
            {
                var currentPlayer = new Player(player);
                listAllPlayers.Add(currentPlayer);
            }

            return listAllPlayers;
        }

        public static void PrintPlayersResults(List<Player> listAllPlayers)
        {
            foreach (var player in listAllPlayers)
            {
                Console.Write($"{player.Name} - ");
                if (player.Fuel > 0)
                {
                    Console.WriteLine($"fuel left {player.Fuel:F2}");
                }
                else
                {
                    Console.WriteLine($"reached {player.TrackReached}");
                }
            }
        }

    }
}
