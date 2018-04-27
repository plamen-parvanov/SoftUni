namespace _03_vtoro_re6enie
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var modified = new List<char>(text).Distinct().ToList();

            for (int i = 0; i < modified.Count; i++)
            {
                var currLetter = modified[i];

                Console.WriteLine($"{currLetter}:{string.Join("/", FindAllIndexOf(currLetter, text))}");
            }
        }

        public static List<int> FindAllIndexOf(char letter, string text)
        {
            var list = new List<int>();
            var index = -1;

            while ((index = text.IndexOf(letter, index + 1)) != -1)
            {
                list.Add(index);
            }

            return list;  
        }
    }
}
