namespace _05.PizzaCalories
{
    using _05.PizzaCalories.Models;
    using System;
    using System.Linq;

    public class StartUp
    {
        private static Pizza pizza;

        public static void Main()
        {
            try
            {
                ReadInput();

                PrintTotalCalories();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void PrintTotalCalories()
        {
            Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:F2} Calories.");
        }

        private static void ReadInput()
        {
            pizza = ParsePizza(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var currentTopping = ParseTopping(command);

                pizza.AddTopping(currentTopping);
            }
        }

        private static Topping ParseTopping(string command)
        {
            var arr = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var type = arr[1];
            var weight = int.Parse(arr[2]);

            return new Topping(type, weight);
        }

        private static Dough ParseDough(string input)
        {
            var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var flourType = arr[1];
            var bakingTechnique = arr[2];
            var weight = int.Parse(arr[3]);

            return new Dough(flourType, bakingTechnique, weight);
        }

        private static Pizza ParsePizza(string input)
        {
            var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var pizzaName = arr.Skip(1).ToArray().FirstOrDefault();

            var dough = ParseDough(Console.ReadLine());

            return new Pizza(pizzaName, dough);
        }
    }
}
