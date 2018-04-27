namespace _03.Spyfer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem03
    {
        public static List<int> list;
        public static void Main()
        {
            ReadInput();

            PrintResult();
        }

        private static void ReadInput()
        {
            list = new List<int>(Console.ReadLine()
                                   .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToList());
            var madeChange = true;

            while (madeChange)
            {
                madeChange = false;

                for (int i = 1; i < list.Count; i++)
                {
                    var curr = list[i];
                    var prev = list[i - 1];
                    if (i == 1 && curr == prev)
                    {
                        list.RemoveAt(i - 1);
                        madeChange = true;
                        break;
                    }
                    else if (i == list.Count - 1 && prev == curr)
                    {
                        list.RemoveAt(i - 1);
                        madeChange = true;
                        break;
                    }

                    if (i == list.Count - 1)
                    {
                        break;
                    }

                    var next = list[i + 1];

                    if (curr == prev + next)
                    {
                        list.RemoveAt(i + 1);
                        list.RemoveAt(i - 1);
                        madeChange = true;
                        break;
                    }
                }
            }
        }

        private static void PrintResult()
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
