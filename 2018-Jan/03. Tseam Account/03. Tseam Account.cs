namespace _03._Tseam_Account
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem03
    {
        private static List<string> list;

        public static void Main()
        {
            ReadInput();

            PrintList();

        }

        private static void PrintList()
        {
            Console.WriteLine(string.Join(" ", list));
        }

        private static void ReadInput()
        {
            list = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                var currLine = Console.ReadLine();

                if (currLine == "Play!")
                {
                    break;
                }

                ExecuteCommand(currLine);
            }
        }

        private static void ExecuteCommand(string input)
        {
            var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var command = arr[0];

            switch (command)
            {
                case "Install":
                    if (!list.Contains(arr[1]))
                    {
                        list.Add(arr[1]);
                    }
                    break;
                case "Uninstall":
                    list.Remove(arr[1]);
                    break;
                case "Update":
                    if (list.Contains(arr[1]))
                    {
                        list.Remove(arr[1]);
                        list.Add(arr[1]);
                    }
                    
                    break;
                case "Expansion":
                    var splitted = arr[1].Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    var game = splitted[0];
                    if (list.Contains(game))
                    {
                        var expansion = game + ":" + splitted[1];
                        var index = list.IndexOf(game);
                        list.Insert(index + 1, expansion);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
