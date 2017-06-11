using System;


namespace _04.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] splitedText = text.Split(' ');

            string[] reverse = new string[splitedText.Length];
            
            reverse[0] = splitedText[splitedText.Length - 1];

            for (int i = 1;  i < reverse.Length; i++)
            {
                reverse[i] = splitedText[i - 1];
            }

            Console.WriteLine(string.Join(" ", reverse));
            

            

        }

       
    }
}
