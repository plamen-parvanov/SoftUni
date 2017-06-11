using System;


namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main()
        {
            
            int cntr = 0;
            string input = Console.ReadLine();

            while (input != "Bake!")
            {
               
                Console.WriteLine($"Adding ingredient {input}.");               
                cntr++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {cntr} ingredients.");
        }
    }
}
