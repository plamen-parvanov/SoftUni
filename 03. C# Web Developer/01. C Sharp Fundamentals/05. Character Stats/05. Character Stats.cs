namespace _05.Character_Stats
{

    using System;


    public class Problem05
    {
        public static void Main()
        {
            //name, current health, maximum health, current energy and maximum energy

            var name = Console.ReadLine();
            var currHealth = short.Parse(Console.ReadLine());
            var maxHealth = short.Parse(Console.ReadLine());
            var currEnergy = short.Parse(Console.ReadLine());
            var maxEnergy = short.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", 
                new string('|', currHealth), new string('.', maxHealth - currHealth));
            Console.WriteLine("Energy: |{0}{1}|",
                new string('|', currEnergy), new string('.', maxEnergy - currEnergy));
        }
    }
}
