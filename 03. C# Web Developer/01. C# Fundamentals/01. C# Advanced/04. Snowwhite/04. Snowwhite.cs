namespace _04.Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Dwarf
    {
        private string name;
        private string color;
        private int physics;

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public string Color
        {
            get { return this.color; }
            private set { this.color = value; }
        }
        public int Physics
        {
            get { return this.physics; }
            private set { this.physics = value; }
        }

        public Dwarf(string name, string color, int physics)
        {
            this.Name = name;
            this.Color = color;
            this.Physics = physics;
        }
    }
    public class Problem04
    {
        public static List<Dwarf> list;
        public static void Main()
        {
            ReadInput();

            PrintResult();
        }

        private static void ReadInput()
        {
            list = new List<Dwarf>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Once upon a time")
                {
                    break;
                }

                AddDwarfsFrom(inputLine);
            }
        }

        private static void AddDwarfsFrom(string input)
        {
            var arr = input.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);
            var name = arr[0];
            var color = arr[1];
            var physics = int.Parse(arr[2]);

            if (list.Any(x => x.Name == name && x.Color == color && x.Physics > physics))
            {
                return;
            }
            else
            {
                list.RemoveAll(x => x.Name == name && x.Color == color);
                list.Add(new Dwarf(name, color, physics));
            }
        }

        private static void PrintResult()
        {
            
            foreach (var dwarf in list.OrderByDescending(x => x.Physics).GroupBy(y => y.Color).OrderByDescending(x => x.Count()).SelectMany(x => x).ToList())
            {
                var name = dwarf.Name;
                var color = dwarf.Color;
                var physics = dwarf.Physics;

                Console.WriteLine($"({color}) {name} <-> {physics}");
            }
        }
    }
}
