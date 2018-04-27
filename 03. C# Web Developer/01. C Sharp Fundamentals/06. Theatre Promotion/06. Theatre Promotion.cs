namespace _06.Theatre_Promotion
{

    using System;


    public class Problem06
    {

        public static void Main()
        {

            var dayOfWeek = Console.ReadLine();
            var inputAge = short.Parse(Console.ReadLine());

            if (inputAge < 0 || inputAge > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                switch (dayOfWeek)
                {
                    case "Weekday":

                        if (inputAge <= 18)
                        {
                            Console.WriteLine("12$");
                        }
                        else if (inputAge <= 64)
                        {
                            Console.WriteLine("18$");
                        }
                        else
                        {
                            Console.WriteLine("12$");
                        }
                        break;

                    case "Weekend":

                        if (inputAge <= 18)
                        {
                            Console.WriteLine("15$");
                        }
                        else if (inputAge <= 64)
                        {
                            Console.WriteLine("20$");
                        }
                        else
                        {
                            Console.WriteLine("15$");
                        }
                        break;

                    case "Holiday":

                        if (inputAge <= 18)
                        {
                            Console.WriteLine("5$");
                        }
                        else if (inputAge <= 64)
                        {
                            Console.WriteLine("12$");
                        }
                        else
                        {
                            Console.WriteLine("10$");
                        }
                        break;
                }
            }

        }
    }
}
