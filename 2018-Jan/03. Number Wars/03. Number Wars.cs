namespace _03.Number_Wars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem03
    {
        private static Queue<string> firstPlrCards;
        private static Queue<string> secondPlrCards;
        private static bool gameContinue;
        private static int rounds;
        public static void Main()
        {
            firstPlrCards = AddingCards();

            secondPlrCards = AddingCards();

            StartPlayingVoina();

            PrintWinner();
        }

        private static void PrintWinner()
        {
            if (firstPlrCards.Count > secondPlrCards.Count)
            {
                Console.Write("First player wins ");
            }
            else if (firstPlrCards.Count < secondPlrCards.Count)
            {
                Console.Write("Second player wins ");
            }
            else
            {
                Console.Write("Draw ");
            }
           
                Console.WriteLine($"after {rounds} turns");
         
        }

        private static void StartPlayingVoina()
        {
            rounds = 0;
            gameContinue = true;

            while (rounds < 1000000 && gameContinue)
            {
                rounds++;

                MakeMove();

                IsThereWinner();
               
            }

        }

        private static void MakeMove()
        {
            var firstPlrCard = firstPlrCards.Dequeue();
            var firstPlrPower = GetPlrDigitPower(firstPlrCard);
            var secondPlrCard = secondPlrCards.Dequeue();
            var secondPlrPower = GetPlrDigitPower(secondPlrCard);

            if (firstPlrPower > secondPlrPower)
            {
                firstPlrCards.Enqueue(firstPlrCard);
                firstPlrCards.Enqueue(secondPlrCard);
            }
            else if (secondPlrPower > firstPlrPower)
            {
                secondPlrCards.Enqueue(secondPlrCard);
                secondPlrCards.Enqueue(firstPlrCard);
            }
            else if (firstPlrCards.Count < 3 || secondPlrCards.Count < 3)
            {
                gameContinue = false;
            }
            else
            {
                var allCards = new Queue<string>();
                allCards.Enqueue(firstPlrCard);
                allCards.Enqueue(secondPlrCard);
                MakeVoina(allCards);
            }
        }

        private static int GetPlrDigitPower(string firstPlrCard)
        {
            return int.Parse(firstPlrCard.Substring(0, firstPlrCard.Length - 1));
        }

        private static void MakeVoina(Queue<string> allCards)
        {          
            var firstPlrPower = 0;

            for (int i = 0; i < 3; i++)
            {
                var currCard = firstPlrCards.Dequeue();
                allCards.Enqueue(currCard);
                firstPlrPower += GetPlrCharPower(currCard);
            }

            var secondPlrPower = 0;

            for (int i = 0; i < 3; i++)
            {
                var currCard = secondPlrCards.Dequeue();
                allCards.Enqueue(currCard);
                secondPlrPower += GetPlrCharPower(currCard);
            }

            if (firstPlrPower > secondPlrPower)
            {
                var ordered = allCards.OrderByDescending(c => GetPlrDigitPower(c)).ThenBy(c => GetPlrCharPower(c)).ToList();
                ordered.ForEach(s => firstPlrCards.Enqueue(s));
               
            }
            else if (secondPlrPower > firstPlrPower)
            {
                var ordered = allCards.OrderByDescending(c => GetPlrDigitPower(c)).ThenBy(c => GetPlrCharPower(c)).ToList();
                ordered.ForEach(s => secondPlrCards.Enqueue(s));
            }
            else if(firstPlrCards.Count > 2 && secondPlrCards.Count > 2)
            {
                MakeVoina(allCards);
            }
            else
            {
                gameContinue = false;
            }

        }

        private static int GetPlrCharPower(string currCard)
        {
            return currCard[currCard.Length - 1] - 'a' + 1;
        }

        private static void IsThereWinner()
        {
            if (firstPlrCards.Count == 0)
            {
                gameContinue = false;
            }
            else if (secondPlrCards.Count == 0)
            {
                gameContinue = false;
            }
            
        }

        private static Queue<string> AddingCards()
        {
            var queue = new Queue<string>();
            Action<string> addToQueue = s => queue.Enqueue(s);

            Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(addToQueue);

            return queue;
        }
    }
}
