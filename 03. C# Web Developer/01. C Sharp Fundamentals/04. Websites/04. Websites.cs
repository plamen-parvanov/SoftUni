using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Websites
{
    public class Problem04
    {
        static List<Website> list;

        public static void Main()
        {
            list = new List<Website>();

            ReadInput();

            PrintList();
        }

        public static void ReadInput()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }

                ReadLine(inputLine);
            }
        }

        public static void ReadLine(string input)
        {
            //{host} | {domain} | {query1,query2. . .}
            var arr = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
            var host = arr[0];
            var domain = arr[1];
            if (arr.Length > 2)
            {
                var queries = arr[2].Split(new[] { ','}, StringSplitOptions.RemoveEmptyEntries );

                list.Add(new Website(host, domain, queries));              
            }
            else
            {
                list.Add(new Website(host, domain));
            }
        }

        public static void PrintList()
        {
            //https://www.softuni.bg/query?=[user]&[course]&[homework] 
            if (list.Count != 0)
            {
                foreach (var web in list)
                {
                    if (web.Queries.Count() == 0)
                    {
                        Console.WriteLine($"https://www.{web.Host}.{web.Domain}");
                    }
                    else
                    {
                        Console.WriteLine($"https://www.{web.Host}.{web.Domain}/query?=[{string.Join("]&[", web.Queries)}]");
                    }
                }
                
            }
        }
    }
}
