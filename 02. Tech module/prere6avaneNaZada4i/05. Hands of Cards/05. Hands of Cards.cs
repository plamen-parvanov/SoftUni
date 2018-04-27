namespace _05.Hands_of_Cards
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Dictionaries
    {

        public static void Main()
        {
           
            var cardsEachPlayer = AddAllCardsPerPlayerInDict();

            var totalPointPerPlayer = new Dictionary<string, int>();

            foreach (var player in cardsEachPlayer)
            {
                var points = SumAllPoints(player.Value);
                totalPointPerPlayer[player.Key] = points;
            }

            PrintPointPerPlayer(totalPointPerPlayer);
        }

        public static Dictionary<string, string> AddAllCardsPerPlayerInDict()
        {
            var input = Console.ReadLine().Split(':');
            var cardsEachPlayer = new Dictionary<string, string>();

            while (input[0] != "JOKER")
            {
                var name = input[0];
                var points = SumAllPoints(input[1]);

                if (!cardsEachPlayer.Keys.Contains(name))
                {
                    cardsEachPlayer[name] = string.Empty;
                }

                cardsEachPlayer[name] += input[1];

                input = Console.ReadLine().Split(':');
            }

            return cardsEachPlayer;
        }

        public static int SumAllPoints(string str)
        {   
            var cardsArr = str.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();
            var points = 0;

            foreach (var card in cardsArr)
            {
                var power = GetCardPower(card[0]);
                var type = GetCardType(card[card.Length - 1]);

                points += power * type;
            }

            return points;
        }

        public static int GetCardPower(char card)
        {
            var power = 0;

            switch (card)
            {
                case '2':
                    power = 2;
                    break;
                case '3':
                    power = 3;
                    break;
                case '4':
                    power = 4;
                    break;
                case '5':
                    power = 5;
                    break;
                case '6':
                    power = 6;
                    break;
                case '7':
                    power = 7;
                    break;
                case '8':
                    power = 8;
                    break;
                case '9':
                    power = 9;
                    break;
                case '1':
                    power = 10;
                    break;
                case 'J':
                    power = 11;
                    break;
                case 'Q':
                    power = 12;
                    break;
                case 'K':
                    power = 13;
                    break;
                case 'A':
                    power = 14;
                    break;
            }

            return power;
        }

        public static int GetCardType(char card)
        {
            var type = 0;

            switch (card)
            {
                case 'S':
                    type = 4;
                    break;
                case 'H':
                    type = 3;
                    break;
                case 'D':
                    type = 2;
                    break;
                case 'C':
                    type = 1;
                    break;      
            }

            return type;

        }

        public static void PrintPointPerPlayer(Dictionary<string, int> pointsEachPlayer)
        {
            foreach (var kvp in pointsEachPlayer)
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }

        }

    }
}
