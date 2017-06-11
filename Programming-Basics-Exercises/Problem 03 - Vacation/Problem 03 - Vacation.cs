using System;

namespace Problem_03___Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
           
            string location; // ili = null 
            string accommodation;
            var percent = 0.0;



            if (budget <= 1000)
            {
                accommodation = "Camp";
                switch (season)
                {
                    
                    case "Winter":
                        percent = 0.45;
                        location = "Morocco";
                        break;

                    case "Summer":
                        percent = 0.65;
                        location = "Alaska";
                        break;

                    default:
                        location = "unknown";
                        break;
                }

                Console.WriteLine("{0} - {1} - {2:F2}", location, accommodation, budget * percent);
            
            } 

            else if (budget <= 3000)
            {
                accommodation = "Hut";
                switch (season)
                {

                    case "Winter":
                        percent = 0.6;
                        location = "Morocco";
                        break;

                    case "Summer":
                        percent = 0.8;
                        location = "Alaska";
                        break;
                }

                Console.WriteLine("{0} - {1} - {2:F2}", location, accommodation, budget * percent);

            }

            else
            {
                accommodation = "Hotel";
                switch (season)
                {

                    case "Winter":
                        percent = 0.9;
                        location = "Morocco";
                        break;

                    case "Summer":
                        percent = 0.9;
                        location = "Alaska";
                        break;
                }

                Console.WriteLine("{0} - {1} - {2:F2}", location, accommodation, budget * percent);

            }



        }

    }
}
