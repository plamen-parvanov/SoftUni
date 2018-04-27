using System;



namespace _07.Sum_Arrays
{
    class Sum_Arrays
    {
        static void Main()
        {
            var firstInput = Console.ReadLine();
            var firstInputArr = firstInput.Split(' ');
            var firstArr = new int[firstInputArr.Length];

            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = int.Parse(firstInputArr[i]);
            }

            var secondInput = Console.ReadLine();
            var secondInputArr = secondInput.Split(' ');
            var secondArr = new int[secondInputArr.Length];

            for (int i = 0; i < secondArr.Length; i++)
            {
                secondArr[i] = int.Parse(secondInputArr[i]);
            }

            var sumArr = new int[Math.Max(firstArr.Length, secondArr.Length)];

            for (int i = 0; i < sumArr.Length; i++)
            {
                sumArr[i] = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
