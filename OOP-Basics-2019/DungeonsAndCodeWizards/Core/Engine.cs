namespace DungeonsAndCodeWizards.Core
{
    using DungeonsAndCodeWizards.Controllers;
    using System;
    using System.Linq;
    using System.Text;

    public class Engine
    {
        private static DungeonMaster dm;
        private static StringBuilder output;

        public void Run()
        {
            dm = new DungeonMaster();
            output = new StringBuilder();

            ExecuteCommands();

            GetFinalStats();

            PrintOutPut();
        }

        private void GetFinalStats()
        {
            output.AppendLine("Final stats:");
            output.AppendLine(dm.GetStats());
        }

        private void PrintOutPut()
        {
            Console.WriteLine(output.ToString().TrimEnd());
        }

        private void ExecuteCommands()
        {
            while (!dm.IsGameOver())
            {
                var inputLine = Console.ReadLine();

                if (string.IsNullOrEmpty(inputLine))
                {
                    break;
                }

                try
                {
                    Execute(inputLine);
                }
                catch (ArgumentException am)
                {
                    output.AppendLine($"Parameter Error: {am.Message}");
                }
                catch (InvalidOperationException im)
                {
                    output.AppendLine($"Invalid Operation: {im.Message}");
                }
            }
        }

        private static void Execute(string inputLine)
        {
            var args = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];
            args = args.Skip(1).ToArray();

            var result = string.Empty;

            switch (command)
            {
                case "JoinParty":
                    result = dm.JoinParty(args);
                    break;
                case "AddItemToPool":
                    result = dm.AddItemToPool(args);
                    break;
                case "PickUpItem":
                    result = dm.PickUpItem(args);
                    break;
                case "UseItem":
                    result = dm.UseItem(args);
                    break;
                case "UseItemOn":
                    result = dm.UseItemOn(args);
                    break;
                case "GiveCharacterItem":
                    result = dm.GiveCharacterItem(args);
                    break;
                case "GetStats":
                    result = dm.GetStats();
                    break;
                case "Attack":
                    result = dm.Attack(args);
                    break;
                case "Heal":
                    result = dm.Heal(args);
                    break;
                case "EndTurn":
                    result = dm.EndTurn(args);
                    break;
                case "IsGameOver":
                    dm.IsGameOver();
                    break;
                default:
                    break;
            }

            output.AppendLine(result);
        }
    }
}
