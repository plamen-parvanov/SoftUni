namespace _02.Cubic_s_Rube
{
    using System;
    using System.Linq;

    public class Problem02
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            var sum = 0L;
            var notChanged = Math.Pow(size, 3);

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Analyze")
                {
                    break;
                }

                var arr = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

                if (CellIsInsideTheCube(size, arr) && arr[3] != 0)
                {
                    sum += arr[3];
                    notChanged--;
                }
            }

            Console.WriteLine(sum);
            Console.WriteLine(notChanged);

        }

        private static bool CellIsInsideTheCube(int size, int[] arr)
        {
            //var firstInsideCube = arr[0] >= 0 && arr[0] < size;
            //var secondInsideCube = arr[1] >= 0 && arr[1] < size;
            //var thirdInsideCube = arr[2] >= 0 && arr[2] < size;

            // return firstInsideCube && secondInsideCube && thirdInsideCube;

            return arr.Take(3).All(x => x >= 0 && x < size);
        }
    }
}
