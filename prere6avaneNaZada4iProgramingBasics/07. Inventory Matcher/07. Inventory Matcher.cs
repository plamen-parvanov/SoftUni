namespace _07.Inventory_Matcher
{
    using System;
    using System.Linq;


    public class Arrays
    {

        public static void Main()
        {
            var namesArr = Console.ReadLine().Split().ToArray();
            var quantityArr = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var priceArr = Console.ReadLine().Split().ToArray();

            string input = Console.ReadLine();

            while (input != "done")
            {
                int index = GetIndex(namesArr, input);

                Console.WriteLine("{0} costs: {1}; Available quantity: {2}",
                    input, priceArr[index], quantityArr[index]);

                input = Console.ReadLine();
            }



        }

        public static int GetIndex(string[] namesArr, string input)
        {
            for (int i = 0; i < namesArr.Length; i++)
            {
                if (namesArr[i] == input)
                {
                    int index = i;
                    return index;
                }
            }
            return -1;

        }
    }
}
