using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.company
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededHours = int.Parse(Console.ReadLine());
            var daysHave = int.Parse(Console.ReadLine());
            var overtimeWorkers = int.Parse(Console.ReadLine());

            var hoursForWork = (daysHave - daysHave * 0.1) * 8;
            var overTimeHours = overtimeWorkers * 2 * daysHave;
            var totalHours = Math.Floor(hoursForWork + overTimeHours);

            if (totalHours >= neededHours)
            {
                var hoursLeft = totalHours - neededHours;
                Console.WriteLine("Yes!{0} hours left.", hoursLeft);
            }

            else
            {
                var hoursMore = neededHours - totalHours;
                Console.WriteLine("Not enough time!{0} hours needed.", hoursMore);
            }    
        }
    }
}
