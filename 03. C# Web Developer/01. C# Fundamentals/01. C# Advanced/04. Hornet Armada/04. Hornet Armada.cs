namespace _04.Hornet_Armada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Soldier
    {
        private string soldierType;
        private int soldierCount;
        private int activity;

        public string SoldierType
        {
            get { return this.soldierType; }
            private set { this.soldierType = value; }
        }
        public int SoldierCount
        {
            get { return this.soldierCount; }
            set { this.soldierCount = value; }
        }
        public int Activity
        {
            get { return this.activity; }
            private set { this.activity = value; }
        }

        public Soldier(string soldierType, int soldierCount, int activity)
        {
            this.SoldierType = soldierType;
            this.SoldierCount = soldierCount;
            this.Activity = activity;
        }
    }

    public class Problem04
    {
        public static Dictionary<string, List<Soldier>> dict;
        public static void Main()
        {
            dict = new Dictionary<string, List<Soldier>>();

            var numberLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLines; i++)
            {
                ReadLine();
            }

            PrintResult();

        }

        private static void ReadLine()
        {
            var input = Console.ReadLine();
            var arr = input
                .Split(" =->:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            //{lastActivity} = {legionName} -> {soldierType}:{soldierCount}

            var activity = int.Parse(arr[0]);
            var legionName = arr[1];
            var soldierType = arr[2];
            var soldierCount = int.Parse(arr[3]);
            var currSoldier = new Soldier(soldierType, soldierCount, activity);

            if (!dict.ContainsKey(legionName))
            {
                dict[legionName] = new List<Soldier>();
            }

            if (dict[legionName].Any(x => x.SoldierType == soldierType))
            {
                if (dict[legionName].Where(x => x.SoldierType == soldierType).First().Activity > activity)
                {
                    activity = dict[legionName].Where(x => x.SoldierType == soldierType).First().Activity;
                }

                dict[legionName].Where(x => x.SoldierType == soldierType).First().SoldierCount += soldierCount;
            }
            else
            {
                dict[legionName].Add(currSoldier);
            }


        }

        private static void PrintResult()
        {
            var input = Console.ReadLine();
            if (char.IsDigit(input[0]))
            {
                var arr = input.Split(new[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                var activity = int.Parse(arr[0]);
                var type = arr[1];

                foreach (var item in dict
                    .Where(x => x.Value.All(y => y.Activity < activity))
                    .Where(x => x.Value.Any(y => y.SoldierType == type))
                    .OrderByDescending(x => x.Value.Sum(y => y.SoldierCount)))
                {
                    var name = item.Key;
                    var count = item.Value.Where(x => x.SoldierType == type).Sum(x => x.SoldierCount);

                    Console.WriteLine($"{name} -> {count}");
                }
            }
            else
            {
                var type = input;

                foreach (var item in dict
                    .Where(x => x.Value.Any(y => y.SoldierType == type))
                    .OrderByDescending(x => x.Value.Sum(y => y.Activity)))
                {
                    var activity = item.Value.Max(x => x.Activity);
                    var name = item.Key;
                    Console.WriteLine($"{activity} : {name}");
                }
            }
        }

    }
}

