using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var namesAndGrades = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var grade = input[1];

                if (!namesAndGrades.Keys.Contains(name))
                {
                    namesAndGrades[name] = new List<string>();
                }

                namesAndGrades[name].Add(grade);
            }

            foreach (var name in namesAndGrades)
            {
                Console.WriteLine("{0} -> {1:f2} (avg: {2:f2})",
                    name.Key, string.Join(" ", name.Value), name.Value.Select(double.Parse).Average());
            }
        }
    }
}
