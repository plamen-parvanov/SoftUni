using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opit
{
    class Program
    {
        static void Main(string[] args)
        {

            char ch = 'a';

            for (int i = 0; i < 5; i++)
            {
                ch++;
                ch++;
                Console.WriteLine(ch);
            }
        }
    }
}
