using System;


namespace _03.Phonebookk
{
    class Program
    {
        static void Main()
        {
            string textNumbs = Console.ReadLine();
            string textNames = Console.ReadLine();

            string[] telNumbersArr = textNumbs.Split(' ');
            string[] namesArr = textNames.Split(' ');

            string nameInput = string.Empty;

            do
            {
                nameInput = Console.ReadLine();

                PrintNumbrFromNameInput(telNumbersArr, namesArr, nameInput);

            } while (nameInput != "done");



        }

        private static void PrintNumbrFromNameInput(string[] telNumbersArr, string[] namesArr, string nameInput)
        {
            for (int i = 0; i < namesArr.Length; i++)
            {
                if (nameInput == namesArr[i])
                {
                    Console.WriteLine("{0} -> {1}", nameInput, telNumbersArr[i]);
                }
            }
        }
    }
}
