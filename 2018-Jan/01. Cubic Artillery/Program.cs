namespace _01.Cubic_Artillery
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem01
    {
        private static Queue<char> bunkers;
        private static Queue<short> weapons;
        private static short capacity;
        private static int storedWeapons; 

        public static void Main()
        {
            capacity = short.Parse(Console.ReadLine());
            bunkers = new Queue<char>();
            weapons = new Queue<short>();
            storedWeapons = 0;

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Bunker Revision")
                {
                    break;
                }

                AddWeaponsAndBunkers(inputLine);
            } 
        }

        private static void AddWeaponsAndBunkers(string inputLine)
        {
            var arr = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in arr)
            {
                var isString = CheckIsString(item);
                if (isString)
                {
                    bunkers.Enqueue(item[0]);
                    continue;
                }

                AddWeaponOrMoveToNextBunker(item);
            
            }
        }

        private static bool CheckIsString(string item)
        {
            short digit;
            return !short.TryParse(item, out digit);
            
        }

        private static void AddWeaponOrMoveToNextBunker(string item)
        {
            var currWeapon = short.Parse(item);

            if (storedWeapons + currWeapon > capacity && bunkers.Count() > 1)
            {
                PrintBunker();

                bunkers.Dequeue();
                weapons.Clear();
                storedWeapons = 0;

                AddWeaponOrMoveToNextBunker(item);
            }
            else if (storedWeapons + currWeapon > capacity && capacity >= currWeapon)
            {
                RemoveWeaponsFromBunker(currWeapon);
            }
            else if (storedWeapons + currWeapon <= capacity)
            {
                weapons.Enqueue(currWeapon);
                storedWeapons += currWeapon;
            }
        }

        private static void PrintBunker()
        {
            Console.Write($"{bunkers.Peek()} -> ");

            if (weapons.Any())
            {
                Console.WriteLine("{0}", string.Join(", ", weapons));
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }

        private static void RemoveWeaponsFromBunker(short currWeapon)
        {
           
            while (true)
            {
                if (storedWeapons + currWeapon <= capacity)
                {
                    weapons.Enqueue(currWeapon);
                    storedWeapons += currWeapon;
                    break;
                }

                storedWeapons -= weapons.Dequeue();
            }
        }
    }
}
