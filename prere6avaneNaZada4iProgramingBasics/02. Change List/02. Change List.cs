namespace _02.Change_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lists
    {

        public static void Main()
        {
            var numList = Console.ReadLine().Split().Select(int.Parse).ToList();

            var resultList = ExecuteInputConmmands(numList);

            PrintResultList(resultList);


        }

        public static void PrintResultList(List<int> resultList)
        {
            Console.WriteLine(string.Join(" ", resultList));
        }

    public static List<int> ExecuteInputConmmands(List<int> numList)
        {
            for (;;)
            {
                var command = Console.ReadLine().Split().ToList();

                switch (command[0])
                {
                    case "Delete":
                        numList.RemoveAll(x => x == int.Parse(command[1]));
                        break;

                    case "Insert":
                        numList.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;

                    case "Odd":
                        numList.RemoveAll(x => x % 2 == 0);
                        return numList;

                    case "Even":
                        numList.RemoveAll(x => x % 2 != 0);
                        return numList;
                }

            }

        }
    }
}
