namespace _08.MilitaryElite
{
    using Factories;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static List<Soldier> soldiers;

        public static void Main()
        {
            ReadInput();

            PrintResult();
        }

        private static void PrintResult()
        {
            soldiers.ForEach(s => Console.WriteLine(s.ToString()));
        }

        private static void ReadInput()
        {
            soldiers = new List<Soldier>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                Execute(command);
            }
        }

        private static void Execute(string command)
        {
            var arr = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var type = arr[0];
            Soldier currentSoldier;

            arr = arr.Skip(1).ToArray();
         
            switch (type)
            {
                case "Private":
                    currentSoldier = PrivateFactory.CreatePrivate(arr);
                    break;
                case "LieutenantGeneral":
                    currentSoldier = LieutenantGeneralFactory.CreateLieutenantGeneral(arr, soldiers);
                    break;
                case "Engineer":
                    try
                    {
                        currentSoldier = EngineerFactory.CreateEmgeneer(arr);
                    }
                    catch (ArgumentException)
                    {
                        return;
                    }                  
                    break;
                case "Commando":
                    currentSoldier = CommandoFactory.CreateCommando(arr);
                    break;
                case "Spy":
                    currentSoldier = SpyFactory.CreateSpy(arr);
                    break;
                default:
                    throw new ArgumentException();
            }

            soldiers.Add(currentSoldier);
        }
    }
}
