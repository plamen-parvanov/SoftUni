using System;


namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            bool textToBool = Convert.ToBoolean(text);

            if (textToBool)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
