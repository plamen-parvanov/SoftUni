using System;

namespace _03.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMin = int.Parse(Console.ReadLine());

            int examTimeInMin = examHour * 60 + examMin;
            int arriveTimeInMin = arriveHour * 60 + arriveMin;
            

            if (arriveTimeInMin > examTimeInMin)
            {
                Console.WriteLine("Late");
            }
            else if (arriveTimeInMin >= examTimeInMin - 30)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Early");
            }
            int difInMin = Math.Abs(arriveTimeInMin - examTimeInMin);
            int h = difInMin / 60;
            int m = difInMin % 60;

            if (difInMin >= 60)
            {
                Console.Write("{0}:{1:d2} hours", h, m);
            }
            else if (difInMin != 0)
            {
                Console.Write("{0} minutes", difInMin);
            }

            if (arriveTimeInMin > examTimeInMin)
            {
                Console.WriteLine(" after the start");
            }
            else if (difInMin != 0)
            {
                Console.WriteLine(" before the start");
            }
        }
    }
}
