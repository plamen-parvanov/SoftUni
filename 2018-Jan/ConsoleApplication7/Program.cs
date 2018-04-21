
namespace ConsoleApplication7
{
    using System;
    using System.Linq;

    public class Problem
    {
        public static void Main()
        {
            var input = "abc";

            var result = string.Join(string.Empty, input.Reverse());
           
            Console.WriteLine(result);
        }
    }
}
