using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            // Each method displays a message and returns a Boolean value. 
            // Method1 returns false and Method2 returns true. When & is used,
            // both methods are called. 
           
            if ( a == 1 & b == 3)
                Console.WriteLine("Both methods returned true.");
            else
                Console.WriteLine("At least one of the methods returned false.");

            // When && is used, after Method1 returns false, Method2 is 
            // not called.
            
            if (a == 1 && b == 2)
                Console.WriteLine("Both methods returned true.");
            else
                Console.WriteLine("At least one of the methods returned false.");
        }

       
    }
}
