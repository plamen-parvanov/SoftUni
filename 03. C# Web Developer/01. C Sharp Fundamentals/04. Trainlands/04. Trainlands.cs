namespace _04.Trainlands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {
        public static Dictionary<string, List<Wagon>> trains;
        public static void Main()
        {
            ReadInput();

            PrintResult();
        }

        private static void ReadInput()
        {
            trains = new Dictionary<string, List<Wagon>>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "It's Training Men!")
                {
                    break;
                }

                ReadLine(inputLine);
            }
        }

        private static void ReadLine(string input)
        {
            var splitBySpace = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var trainName = splitBySpace[0];
            if (!trains.ContainsKey(trainName))
            {
                trains[trainName] = new List<Wagon>();
            }

            if (splitBySpace.Length > 3)
            {
                AddWagons(splitBySpace);
            }
            else if (splitBySpace[1] == "->")
            {
                AddWagonsAndRemoveTrain(splitBySpace);
            }
            else if (splitBySpace[1] == "=")
            {
                Copy(splitBySpace);
            }
        }

        private static void AddWagons(string[] input)
        {
            var trainName = input[0];
            var wagonName = input[2];
            var wagonPower = int.Parse(input[4]);

            trains[trainName].Add(new Wagon(wagonName, wagonPower));
        }

        private static void AddWagonsAndRemoveTrain(string[] input)
        {
            var firstTrain = input[0];
            var secondTrain = input[2];

            trains[firstTrain].AddRange(trains[secondTrain]);
            trains.Remove(secondTrain);
        }

        private static void Copy(string[] input)
        {
            var firstTrain = input[0];
            var secondTrain = input[2];

            trains[firstTrain].Clear();
            trains[firstTrain].AddRange(trains[secondTrain]);
        }

        private static void PrintResult()
        {
            foreach (var train in trains
                .OrderByDescending(x => x.Value.Sum(y => y.Power))
                .ThenByDescending(x => x.Value.Count()))
            {
                var trainName = train.Key;
                Console.WriteLine("Train: {0}{1}###{2}",
                          trainName,
                          Environment.NewLine,
                          string.Join($"{Environment.NewLine}###", train.Value
                                          .OrderByDescending(p => p.Power)
                                          .Select(x => string.Format($"{x.Name} - {x.Power}"))));
            }
        }
    }
}
