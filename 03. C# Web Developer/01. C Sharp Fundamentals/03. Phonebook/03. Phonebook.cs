namespace _03.Phonebook
{

    using System;

    public class Problem03
    {

        public static void Main()
        {
            var numbersArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var namesArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "done")
                {
                    break;
                }

                var name = command;
                var number = GetNumberFromName(command, numbersArr, namesArr);
                Console.WriteLine($"{name} -> {number}");
            }

        }

        public static string GetNumberFromName(string name, string[] nums, string[] names)
        {
            var indexOfNameInNumsArr = GetIndex(name, names);
            var number = nums[indexOfNameInNumsArr];

            return number;
        }

        public static int GetIndex(string name, string[] names)
        {
            var index = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (name == names[i])
                {
                    index = i;
                    break;
                }

            }

            return index;
        }
    }
}
