namespace _03.Safe_Manipulation
{

    using System;
    using System.Linq;

    public class Arrays
    {

        public static void Main()
        {
            var inputArr = Console.ReadLine().Split().ToArray();
            var commandsArr = Console.ReadLine().Split().ToArray();


            while (commandsArr[0] != "END")
            {
                switch (commandsArr[0])
                {
                    case "Reverse":
                        inputArr = inputArr.Reverse().ToArray();
                        break;

                    case "Distinct":
                        inputArr = inputArr.Distinct().ToArray();
                        break;

                    case "Replace":
                        var indexToReplace = int.Parse(commandsArr[1]);
                        var stringToReplace = commandsArr[2];

                        if (indexToReplace < 0 || indexToReplace > inputArr.Length - 1)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        { 
                            inputArr[indexToReplace] = stringToReplace;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }

                commandsArr = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(", ",inputArr));

        }
    }
}
