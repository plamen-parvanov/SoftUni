using System;


namespace _09.Altitude
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string[] textSplited = text.Split(' ');

            double altitude = double.Parse(textSplited[0]);

            for (int i = 1; i < textSplited.Length; i += 2)
            {
                if (textSplited[i] == "up")
                {
                    altitude += double.Parse(textSplited[i + 1]);
                }
                else if (textSplited[i] == "down")
                {
                    altitude -= double.Parse(textSplited[i + 1]);
                }

                if (altitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }
            Console.WriteLine("got through safely. current altitude: {0}m", altitude);
        }
    }
}
