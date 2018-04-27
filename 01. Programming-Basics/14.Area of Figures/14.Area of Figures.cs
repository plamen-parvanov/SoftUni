using System;


namespace _14.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            if (figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var area = a * a;

                Console.WriteLine(Math.Round(area, 3));
            }

            else if (figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var area = a * b;

                Console.WriteLine(Math.Round(area, 3));
            }

            else if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                var area = Math.PI * r * r;

                Console.WriteLine(Math.Round(area, 3));
            }

            else if (figure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var ha = double.Parse(Console.ReadLine());
                var area = a * ha / 2;

                Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
}
