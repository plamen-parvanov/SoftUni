namespace _03.Wormhole
{
    using System;
    using System.Linq;

    public class Problem03
    {
        public static void Main()
        {
            var steps = 0;
            var arr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    var temp = arr[i];
                    arr[i] = 0;
                    i = temp - 1;                   
                    continue;
                }

                steps++;
            }

            Console.WriteLine(steps);
        }
    }
}
