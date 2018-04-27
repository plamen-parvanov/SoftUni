using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = Console.ReadLine();
            var text = Console.ReadLine();

            var replacement = new string('*', pattern.Length);
            var regex = new Regex(pattern);
            var result = string.Empty;

            if (text.Contains(pattern))
            {
                result = regex.Replace(text, replacement);
            }

            Console.WriteLine(result);
        }
    }
}
