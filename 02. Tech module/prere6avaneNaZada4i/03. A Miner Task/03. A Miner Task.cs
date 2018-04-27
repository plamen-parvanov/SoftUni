namespace _03.A_Miner_Task
{

    using System;
    using System.Collections.Generic;


    public class Dictionaries
    {

        public static void Main()
        {
            var colectedResourse = CollectAllResourcesInputed();

            PrintColectedResourse(colectedResourse);


        }

        public static Dictionary<string, int> CollectAllResourcesInputed()
        {
            var colectedResourse = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (input != "stop")
            {
                var resource = input;
                var quantity = Console.ReadLine();

                if (!colectedResourse.ContainsKey(resource))
                {
                    colectedResourse[resource] = 0;
                }

                colectedResourse[resource] += int.Parse(quantity);

                input = Console.ReadLine();
            }

            return colectedResourse;
        }

        public static void PrintColectedResourse(Dictionary<string, int> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            }
        }

    }
}
