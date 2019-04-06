namespace SoftUniRestaurant.Core
{
    using System;
    using System.Text;

    public class Engine
    {
        private RestaurantController restaurantController;
        private StringBuilder outputMessages;

        public Engine(RestaurantController restaurantController)
        {
            this.restaurantController = restaurantController;
            this.outputMessages = new StringBuilder();
        }

        public void Run()
        {
            ReadInput();

            PrintResult();
        }

        private void PrintResult()
        {
            Console.WriteLine(this.outputMessages.ToString().TrimEnd());
        }

        private void ReadInput()
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    Execute(input);
                }
                catch (ArgumentException ex)
                {
                    this.outputMessages.AppendLine(ex.Message);
                }
            }

            outputMessages.AppendLine(this.restaurantController.GetSummary());
        }

        private void Execute(string input)
        {
            var args = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var command = args[0];
            var result = string.Empty;

            switch (command)
            {
                case "AddFood":
                    result = this.restaurantController.AddFood(args[1], args[2], decimal.Parse(args[3]));
                    break;
                case "AddDrink":
                    result = this.restaurantController.AddDrink(args[1], args[2], int.Parse(args[3]), args[4]);
                    break;
                case "AddTable":
                    result = this.restaurantController.AddTable(args[1], int.Parse(args[2]), int.Parse(args[3]));
                    break;
                case "ReserveTable":
                    result = this.restaurantController.ReserveTable(int.Parse(args[1]));
                    break;
                case "OrderFood":
                    result = this.restaurantController.OrderFood(int.Parse(args[1]), args[2]);
                    break;
                case "OrderDrink":
                    result = this.restaurantController.OrderDrink(int.Parse(args[1]), args[2], args[3]);
                    break;
                case "LeaveTable":
                    result = this.restaurantController.LeaveTable(int.Parse(args[1]));
                    break;
                case "GetFreeTablesInfo":
                    result = this.restaurantController.GetFreeTablesInfo();
                    break;
                case "GetOccupiedTablesInfo":
                    result = this.restaurantController.GetOccupiedTablesInfo();
                    break;
            }

            this.outputMessages.AppendLine(result);
        }
    }
}
