namespace StorageMaster.Core
{
    using System;
    using System.Linq;
    using Controllers;

    public class Engine
    {
        public void Run()
        {
            var storageMaster = new StorageMaster();

            string commandLine;
            while ((commandLine = Console.ReadLine()) != "END")
            {
                try
                {
                    Execute(commandLine, storageMaster);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            Console.WriteLine(storageMaster.GetSummary());
        }

        private static void Execute(string commandLine, StorageMaster storageMaster)
        {
            var args = commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];
            string result;

            switch (command)
            {
                case "AddProduct":
                    result = storageMaster.AddProduct(args[1], double.Parse(args[2]));
                    break;
                case "RegisterStorage":
                    result = storageMaster.RegisterStorage(args[1], args[2]);
                    break;
                case "SelectVehicle":
                    result = storageMaster.SelectVehicle(args[1], int.Parse(args[2]));
                    break;
                case "LoadVehicle":
                    result = storageMaster.LoadVehicle(args.Skip(1).ToArray());
                    break;
                case "SendVehicleTo":
                    result = storageMaster.SendVehicleTo(args[1], int.Parse(args[2]), args[3]);
                    break;
                case "UnloadVehicle":
                    result = storageMaster.UnloadVehicle(args[1], int.Parse(args[2]));
                    break;
                case "GetStorageStatus":
                    result = storageMaster.GetStorageStatus(args[1]);
                    break;
                default:
                    throw new ArgumentException();
            }

            Console.WriteLine(result);
        }
    }
}
