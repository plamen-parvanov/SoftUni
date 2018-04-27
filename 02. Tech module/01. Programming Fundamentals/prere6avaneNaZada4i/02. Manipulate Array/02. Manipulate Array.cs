namespace _02.Manipulate_Array
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Arrays
    {

        public static void Main()
        {
            var inputArr = Console.ReadLine().Split().ToArray();
            var numberCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCommands; i++)
            {
                var command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    case "Distinct":
                        inputArr = inputArr.Distinct().ToArray();
                        break;

                    case "Reverse":
                        inputArr = inputArr.Reverse().ToArray();
                        break;

                    case "Replace":
                        var indexToReplace = int.Parse(command[1]);
                        var stringToReplace = command[2];
                        inputArr[indexToReplace] = stringToReplace;
                        break;
                }

            }

            Console.WriteLine(string.Join(", ", inputArr));

        }
    }
}
