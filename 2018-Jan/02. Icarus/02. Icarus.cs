namespace _02.Icarus
{
    using System;
    using System.Linq;

    public class Problem02
    {
        public static int[] arr;
        public static int index;
        public static int damage;
        public static void Main()
        {
            ReadInput();

            PrintResult();
        }

        private static void ReadInput()
        {
            arr = Console.ReadLine()
                         .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                         .Select(int.Parse)
                         .ToArray();
            index = int.Parse(Console.ReadLine());
            damage = 1;

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Supernova")
                {
                    break;
                }

                ReaExecute(command);
            }
        }

        private static void ReaExecute(string inputLine)
        {
            var input = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var command = input[0];
            var steps = int.Parse(input[1]);

            for (int i = 1; i <= steps; i++)
            {
                index = command == "left" ? --index: ++index;

                if (index < 0)
                {
                    index = arr.Length - 1;
                    damage++;
                }
                else if (index > arr.Length - 1)
                {
                    index = 0;
                    damage++;
                }

                arr[index] -= damage;
            }
        }

        private static void PrintResult()
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
