using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class zakruglqne
    {
        static void Main(string[] args)
            // ako ne iskam prozoreca da mi se zatvarq sled vseki test
            // while tab-tab i zatvarqm vsi4ko v skoby {}
        {
            Console.WriteLine(Math.Round(19.5555, 2));    // zakruglq  , kolko znaka sled zapetaqta

            Console.WriteLine(Math.Floor(19.9999));      // zakruglq NADOLU do cqlo 4islo

            Console.WriteLine(Math.Ceiling(155.0001));   // zakruglq NAGORE do cqlo 4islo

            Console.WriteLine(Math.Truncate(222.99));    // ostavq SAMO cqlo 4islo

            var a = 44.5;
            Console.WriteLine("{0:F2}", a);    // izkarva 2 znaka sled zapetaqta ako sa pove4e zakruglq

            var b = 44.56789;
            Console.WriteLine("{0:F3}", b);

            var c = 44.50989;
            Console.WriteLine("{0:F1}", c);

            Console.WriteLine(Math.Abs(-111));  // vzima absoliutnata stoinost na parametura t.e. pravi go polojitelno
        }
    }
}
