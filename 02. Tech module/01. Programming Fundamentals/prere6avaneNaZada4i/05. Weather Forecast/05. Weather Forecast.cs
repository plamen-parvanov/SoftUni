using System;


namespace _05.Weather_Forecast
{
    class WeatherForecast

    {
        static void Main()
        {
            string inputNum = Console.ReadLine();

            try
            {
                var number = sbyte.Parse(inputNum);
                Console.WriteLine("Sunny");
            }
            
            catch (Exception)
            {
                try
                {
                    var number = int.Parse(inputNum);
                    Console.WriteLine("Cloudy");
                }
                catch (Exception)
                {

                    try
                    {
                        var number = long.Parse(inputNum);
                        Console.WriteLine("Windy");
                    }
                    catch (Exception)
                    {   
                            var number = double.Parse(inputNum);
                            Console.WriteLine("Rainy");
                      
                    }
                }
            }
        }
    }
}
