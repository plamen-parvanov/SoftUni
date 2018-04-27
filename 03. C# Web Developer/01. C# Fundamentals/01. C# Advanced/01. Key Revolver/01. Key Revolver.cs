namespace _01.Key_Revolver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem02
    {
        public static void Main()
        {
            var bulletPrice = int.Parse(Console.ReadLine());
            var gunBerrel = int.Parse(Console.ReadLine());
            var bullets = AddBulletsToStack();
            var locks = AddLocksToQueue();
            var value = int.Parse(Console.ReadLine());
            var bullStart = bullets.Count;

            ShootingAtLocks(gunBerrel, bullets, locks);

            PrintResult(bulletPrice, bullets.Count, locks, value, bullStart);

        }

        private static Stack<int> AddBulletsToStack()
        {
            return new Stack<int>(Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
        }

        private static Queue<int> AddLocksToQueue()
        {
            return new Queue<int>(Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
        }

        private static void ShootingAtLocks(int gunBarrel, Stack<int> bullets, Queue<int> locks)
        {
            var cntr = gunBarrel;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                var currBullet = bullets.Pop();
                var currLock = locks.Peek();

                if (currBullet <= currLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                cntr--;

                if (cntr == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    cntr = gunBarrel;
                }
            }
        }

        private static void PrintResult(int price, int bulletsLeft, Queue<int> locks, int value, int bullStart)
        {
            if (locks.Count != 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                var moneyEarned = value - (bullStart - bulletsLeft) * price;
                Console.WriteLine($"{bulletsLeft} bullets left. Earned ${moneyEarned}");
            }

        }
    }
}
