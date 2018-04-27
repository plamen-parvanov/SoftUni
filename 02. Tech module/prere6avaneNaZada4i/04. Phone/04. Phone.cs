namespace _04.Phone
{
    using System;


    public class Arrays
    {

        public static void Main()
        {
            string inputNumbers = Console.ReadLine();
            string[] numbers = inputNumbers.Split(' ');

            string inputNames = Console.ReadLine();
            string[] names = inputNames.Split(' ');

            string comands = Console.ReadLine();
            string[] comandsArr = comands.Split(' ');

            while (comandsArr[0] != "done")
            {
                try
                {
                    long number = in.Parse(comandsArr[1]);
                    Console.WriteLine(number);
                }
                catch (Exception)
                {
                    string name = comandsArr[1];
                    Console.WriteLine(name);

                }

                switch (comandsArr[0])
                {
                    
                    case "call":
                       

                        break;

                    case "message":
                        break;

                }
            }
 
        }
    }
}
