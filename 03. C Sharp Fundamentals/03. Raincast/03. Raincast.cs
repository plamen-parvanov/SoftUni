namespace _03.Raincasts
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Raincast
    {
        private string type;
        private string source;
        private string forecast;

        public string Type
        {
            get { return this.type; }
            private set { this.type = value; }
        }
        public string Source
        {
            get { return this.source; }
            private set { this.source = value; }
        }
        public string Forecast
        {
            get { return this.forecast; }
            private set { this.forecast = value; }
        }

        public Raincast(string type, string source, string forecast)
        {
            this.Type = type;
            this.Source = source;
            this.Forecast = forecast;
        }
    }

    public class Problem03
    {
        public static List<Raincast> list;
        public static string search = "Type";
        public static string type = string.Empty;
        public static string source = string.Empty;
        public static string forecast = string.Empty;
        public static void Main()
        {
            ReadInput();

            PrintAllRaincasts();
        }

        private static void ReadInput()
        {
            list = new List<Raincast>();
            

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Davai Emo")
                {
                    break;
                }

                Read(inputLine);
            }
        }

        private static void Read(string input)
        {
            var arr = input.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);


            if (arr[0] == "Type" && search == "Type")
            {
                var regex = new Regex(@"^(Normal|Warning|Danger)$");
                type = regex.Match(arr[1]).Value;
                search = type != string.Empty ? "Source" : "Type";
            }
            else if (arr[0] == "Source" && search == "Source")
            {
                var regex = new Regex(@"^[A-Za-z0-9]+$");
                source = regex.Match(arr[1]).Value;
                search = source != string.Empty ? "Forecast" : "Source";
            }
            else if (arr[0] == "Forecast" && search == "Forecast")
            {
                var regex = new Regex(@"^[^!.,?]+$");
                forecast = regex.Match(arr[1]).Value;
                search = forecast != string.Empty ? "Type" : "Forecast";

                if (forecast != string.Empty)
                {
                    list.Add(new Raincast(type, source, forecast));
                }              
            }
        }

        private static void PrintAllRaincasts()
        {
            foreach (var raincast in list)
            {
                var type = raincast.Type;
                var source = raincast.Source;
                var forecast = raincast.Forecast;
                Console.WriteLine($"({type}) {forecast} ~ {source}");
            }
        }
    }
}
