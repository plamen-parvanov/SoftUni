namespace _01.Vehicles.Controllers
{
    using _01.Vehicles.Factories;
    using Models;
    using System;
    using System.Text;

    public class Engine
    {
        private static Vehicle car;
        private static Vehicle truck;
        private static Vehicle bus;
        private static StringBuilder result;

        public Engine()
        {
            result = new StringBuilder();
        }

        public void Run()
        {
            car = CreateVehicle(Console.ReadLine());
            truck = CreateVehicle(Console.ReadLine());
            bus = CreateVehicle(Console.ReadLine());


            ExecuteCommands();

            PrintResult();
        }

        private void PrintResult()
        {
            result.AppendLine(car.ToString());
            result.AppendLine(truck.ToString());
            result.AppendLine(bus.ToString());


            Console.WriteLine(result.ToString().TrimEnd());
        }

        private void ExecuteCommands()
        {
            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commandLine = Console.ReadLine();

                try
                {
                    Execute(commandLine);
                }
                catch (ArgumentException ex)
                {
                    result.AppendLine(ex.Message);
                }
            }
        }

        private void Execute(string commandLine)
        {
            var arr = commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var command = arr[0];
            var type = arr[1];
            var arg = double.Parse(arr[2]);

            if (command == "Drive")
            {
                if (type == "Car")
                {
                   result.AppendLine(car.Drive(arg));
                }
                else if (type == "Truck")
                {
                    result.AppendLine(truck.Drive(arg));
                }
                else if (type == "Bus")
                {
                    result.AppendLine(bus.Drive(arg));
                }
            }
            else if (command == "Refuel")
            {
                if (type == "Car")
                {
                    car.Refuel(arg);
                }
                else if (type == "Truck")
                {
                   truck.Refuel(arg);
                }
                else if (type == "Bus")
                {
                    bus.Refuel(arg);
                }
            }
            else if (command == "DriveEmpty" && type == "Bus")
            {
                if (bus is Bus emptyBus)
                {
                    result.AppendLine(emptyBus.DriveEmpty(arg));
                }
            }
        }

        private Vehicle CreateVehicle(string inputLine)
        {
            var arr = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var type = arr[0];
            var fuelQuantity = double.Parse(arr[1]);
            var fuelConsumptionPerKm = double.Parse(arr[2]);
            var fuelTank = double.Parse(arr[3]);

            if (type == "Car")
            {
                return CarFactory.CraeteCar(fuelQuantity, fuelConsumptionPerKm, fuelTank);
            }
            else if (type == "Truck")
            {
                return TruckFactory.CraeteTruck(fuelQuantity, fuelConsumptionPerKm, fuelTank);
            }
            else if (type == "Bus")
            {
                return BusFactory.CraeteBus(fuelQuantity, fuelConsumptionPerKm, fuelTank);
            }

            throw new ArgumentException(); 
        }
    }
}
