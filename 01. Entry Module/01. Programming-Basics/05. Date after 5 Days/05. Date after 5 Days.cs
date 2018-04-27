using System;

namespace _05.Date_after_5_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var dayPlusFive = day + 5;
            int daysInMonth;


            switch (month)
            {
                case 2:
                    daysInMonth = 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;

                default:
                    daysInMonth = 31;
                    break;
          
            }


            if (dayPlusFive > daysInMonth)
            {
                month += 1;

                if (month > 12)
                {
                    month -= 12;
                    dayPlusFive %= daysInMonth;
                    Console.WriteLine("{0}.0{1}", dayPlusFive, month);

                }

                else if (month < 10)
                {
                    dayPlusFive %= daysInMonth;
                    Console.WriteLine("{0}.0{1}", dayPlusFive, month);
                }

                else
                {
                    dayPlusFive %= daysInMonth;
                    Console.WriteLine("{0}.{1}", dayPlusFive, month);
                }

            }

            else
            {
                

                 if (month < 10)
                {
                   
                    Console.WriteLine("{0}.0{1}", dayPlusFive, month);
                }

                else
                {
                    
                    Console.WriteLine("{0}.{1}", dayPlusFive, month);
                }
            }
        }
    }
}
