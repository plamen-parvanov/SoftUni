namespace AnimalCentre.Core
{
    using System;
    using System.Text;

    public class Engine
    {
        private static AnimalCentre animalCenter;
        private static StringBuilder outputMessage;

        public void Run()
        {
            ReadInput();

            PrintResult();
        }

        private void PrintResult()
        {
            outputMessage.AppendLine(animalCenter.PrintAdoptedAnimals());

            Console.WriteLine(outputMessage.ToString().TrimEnd());
        }

        private void ReadInput()
        {
            animalCenter = new AnimalCentre();
            outputMessage = new StringBuilder();
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                try
                {
                    Read(inputLine);
                }
                catch (ArgumentException ex)
                {
                    outputMessage.AppendLine($"ArgumentException: {ex.Message}");
                }
                catch (InvalidOperationException ex)
                {
                    outputMessage.AppendLine($"InvalidOperationException: {ex.Message}");
                }
            }
        }

        private void Read(string inputLine)
        {
            var args = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];
            var result = string.Empty;

            switch (command)
            {
                case "RegisterAnimal":
                    result = animalCenter.RegisterAnimal(args[1], args[2], int.Parse(args[3]),
                        int.Parse(args[4]), int.Parse(args[5]));
                    break;
                case "Chip":
                    result = animalCenter.Chip(args[1], int.Parse(args[2]));
                    break;
                case "Fitness":
                    result = animalCenter.Fitness(args[1], int.Parse(args[2]));
                    break;
                case "Vaccinate":
                    result = animalCenter.Vaccinate(args[1], int.Parse(args[2]));
                    break;
                case "Play":
                    result = animalCenter.Play(args[1], int.Parse(args[2]));
                    break;
                case "DentalCare":
                    result = animalCenter.DentalCare(args[1], int.Parse(args[2]));
                    break;
                case "NailTrim":
                    result = animalCenter.NailTrim(args[1], int.Parse(args[2]));
                    break;
                case "Adopt":
                    result = animalCenter.Adopt(args[1], args[2]);
                    break;
                case "History":
                    result = animalCenter.History(args[1]);
                    break;
                default:
                    break;
            }

            outputMessage.AppendLine(result);
        }
    }
}
