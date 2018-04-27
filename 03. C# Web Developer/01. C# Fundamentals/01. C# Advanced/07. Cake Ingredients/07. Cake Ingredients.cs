namespace _07.Cake_Ingredients
{

    using System;


    public class Problem07
    {

        public static void Main()
        {
            var number = 0;
            
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Bake!")
                {
                    Console.WriteLine(
                        $"Preparing cake with {number} ingredients.");
                    break;
                }

                Console.WriteLine($"Adding ingredient {command}.");
                number++;
            }

        }
    }
}
