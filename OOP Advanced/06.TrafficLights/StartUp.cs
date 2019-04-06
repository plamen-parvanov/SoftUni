namespace _06.TrafficLights
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var signals = ReadSignals();
            var traficLight = new TrafficLight(signals);

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                traficLight.ChangeSignal();

                Console.WriteLine(traficLight.Print());
            }
        }

        private static Signal[] ReadSignals()
        {
            var input = Console.ReadLine();
            var agrs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var result = agrs.Select(a => Enum.Parse<Signal>(a)).ToArray();

            return result;

        }
    }
}
