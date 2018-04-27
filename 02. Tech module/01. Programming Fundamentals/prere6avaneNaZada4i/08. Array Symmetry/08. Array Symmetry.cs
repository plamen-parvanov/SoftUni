using System;


namespace _08.Array_Symmetry
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string[] spletedText = text.Split(' ');

            ChaeckArrSimmetry(spletedText);

        }

        private static void ChaeckArrSimmetry(string[] spletedText)
        {
            for (int i = 0; i < spletedText.Length; i++)
            {
                if (spletedText[i] != spletedText[spletedText.Length - 1 - i])
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
