using System;

namespace _02.Count_Substring_Occurrences
{
    public class Problem02
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var find = Console.ReadLine().ToLower();

            var cntr = 0;
            var index = 0;

            while (true)
            {
                index = text.IndexOf(find, index);

                if (index < 0)
                {
                    break;
                }
                cntr++;
                index++;
            }

            Console.WriteLine(cntr);
        }
    }
}
