using System;


namespace _01.Last_3_Consecutive_Equal_Strings
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string[] splitedText = text.Split(' ');
            string prevoius = string.Empty;
            int cntr = 0;

            for (int i = splitedText.Length -1; i >= 0; i--)
            {
                if (prevoius == splitedText[i])
                {
                    cntr++;
                }
                else
                {
                    cntr = 0;
                }

                prevoius = splitedText[i];

                if (cntr == 2)
                {
                    Console.WriteLine("{0} {0} {0}", prevoius);
                    return;
                }
            }
           

            

        }

    }
}
