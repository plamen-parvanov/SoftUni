namespace _01.Jedi_Meditation
{
    using System;
    using System.Collections.Generic;

    public class Problem01
    {
        private static List<string> masters;
        private static List<string> knights;
        private static List<string> padawans;
        private static List<string> toshkoAndSlav;
        private static bool containsYoda;
         
        public static void Main()
        {
            ReadInput();

             var seq = OrderSequence();

            PrintOrdered(seq);
        }

        private static void PrintOrdered(List<string> seq)
        {
            Console.WriteLine(string.Join(" ", seq));
        }

        private static List<string> OrderSequence()
        {
            var result = new List<string>();

            if (containsYoda)
            {
                result.AddRange(masters);
                result.AddRange(knights);
                result.AddRange(toshkoAndSlav);
                result.AddRange(padawans);

                return result;
            }

            result.AddRange(toshkoAndSlav);
            result.AddRange(masters);
            result.AddRange(knights);
            result.AddRange(padawans);

            return result;


        }

        private static void ReadInput()
        {
            containsYoda = false;
            masters = new List<string>();
            knights = new List<string>();
            padawans = new List<string>();
            toshkoAndSlav = new List<string>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                ReadLine();
            }
        }

        private static void ReadLine()
        {
            var currLine = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in currLine)
            {
                switch (item[0])
                {
                    case 'm':
                        masters.Add(item);
                        break;
                    case 'k':
                        knights.Add(item);
                        break;
                    case 'p':
                        padawans.Add(item);
                        break;
                    case 't':
                    case 's':
                        toshkoAndSlav.Add(item);
                        break;
                    case 'y':
                        containsYoda = true;
                        break;
                }
            }
        }
    }
}
