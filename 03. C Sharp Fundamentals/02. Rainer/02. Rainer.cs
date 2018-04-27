namespace _02.Rainer
{
    using System;
    using System.Linq;

    public class Problem02
    {
        public static void Main()
        {
            ReadInput();

        }

        private static void ReadInput()
        {
            var input = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse);
            var index = input.Last();
            var original = input.Take(input.Count() - 1).ToArray();
            var arr = new int[original.Length];
            Array.Copy(original, arr, original.Length);
            var steps = 0;

            while (true)
            {
                arr = arr.Select(x => x -= 1).ToArray();

                if (arr[index] == 0)
                {
                    Console.WriteLine(string.Join(" ", arr));
                    Console.WriteLine(steps);
                    break;
                }
                else if (arr.Any(x => x == 0))
                {
                    ReplaceAllZeroes(arr, original);
                }

                index = int.Parse(Console.ReadLine());
                steps++;
            }
        }

        private static void ReplaceAllZeroes(int[] arr, int[] original)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = original[i];
                }
            }
        }
    }
}
