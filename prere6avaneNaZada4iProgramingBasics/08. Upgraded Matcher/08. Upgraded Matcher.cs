namespace _08.Upgraded_Matcher
{
    using System;
    using System.Linq;

    public class Arrays
    {
        public static void Main()
        {
            var namesArr = Console.ReadLine().Split().ToArray();
            var secondInput = Console.ReadLine();
            long[] quantityArr = InitQuantityArr(secondInput, namesArr.Length);
            var priceArr = Console.ReadLine().Split().ToArray();

            var input = Console.ReadLine().Split().ToArray();

            while (input[0] != "done")
            {
                int index = GetIndex(namesArr, input);

                PrintQuanityAndPrice(quantityArr, priceArr, input, index);

                input = Console.ReadLine().Split().ToArray();
            }



        }

        public static long[] InitQuantityArr(string input, int length)
        {
            var intArr = new long[length];
            var inputArr = input.Split();

            for (int i = 0; i < inputArr.Length; i++)
            {
                intArr[i] = long.Parse(inputArr[i]);
            }

            return intArr;
            
             
        }

        public static void PrintQuanityAndPrice(long[] quantityArr, string[] priceArr, string[] input, int index)
        {
            long quantityWanted = long.Parse(input[1]);

            if (quantityArr[index] - quantityWanted >= 0)
            {
                double price = double.Parse(priceArr[index]);
                double totalPrice = quantityWanted * price;
                quantityArr[index] -= quantityWanted;
                Console.WriteLine("{0} x {1} costs {2:f2}", input[0], quantityWanted, totalPrice);
            }
            else
            {
                Console.WriteLine($"We do not have enough {input[0]}");
            }
        }

        public static int GetIndex(string[] namesArr, string[] input)
        {
            for (int i = 0; i < namesArr.Length; i++)
            {
                if (namesArr[i] == input[0])
                {
                    int index = i;
                    return index;
                }
            }
            return 0;

        }
    }
}


