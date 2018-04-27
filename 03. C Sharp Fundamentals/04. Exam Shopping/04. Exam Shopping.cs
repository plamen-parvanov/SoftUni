namespace _04.Exam_Shopping
{

    using System;
    using System.Collections.Generic;

    public class Problem04
    {

        public static void Main()
        {
            var dict = new Dictionary<string, int>();

            StockingProducts(dict);

            BuyingProducts(dict);

            PrintRemainingProducts(dict);
        }

        public static Dictionary<string, int> StockingProducts(Dictionary<string, int> dict)
        {
            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "shopping time")
                {
                    break;
                }

                var arr = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var product = arr[1];
                var quantity = int.Parse(arr[2]);

                if (!dict.ContainsKey(product))
                {
                    dict[product] = 0;
                }

                dict[product] += quantity;
            }

            return dict;
        }

        public static Dictionary<string, int> BuyingProducts(Dictionary<string, int> dict)
        {
            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "exam time")
                {
                    break;
                }

                var inputArr = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var product = inputArr[1];
                var quantity = int.Parse(inputArr[2]);

                if (!dict.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else if(dict[product] == 0)
                {
                    Console.WriteLine($"{product} out of stock");
                }
                else
                {
                    dict[product] -= quantity;

                    if (dict[product] < 0)
                    {
                        dict[product] = 0;
                    }
                }
                            
            }

            return dict;
        }

        public static void PrintRemainingProducts(Dictionary<string, int> dict)
        {
            foreach (var kvp in dict)
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }

        }
    }
}
