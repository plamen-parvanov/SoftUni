using System;


namespace _03.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            

                var examHours = int.Parse(Console.ReadLine());
                var examMinutes = int.Parse(Console.ReadLine());
                var arriveHours = int.Parse(Console.ReadLine());
                var arriveMinutes = int.Parse(Console.ReadLine());

                var examTimeInMinutes = examHours * 60 + examMinutes;
                var arriveTimeInMinutes = arriveHours * 60 + arriveMinutes;

                if (arriveTimeInMinutes > examTimeInMinutes)
                    Console.WriteLine("Late");
                else if (arriveTimeInMinutes + 30 >= examTimeInMinutes)
                    Console.WriteLine("On time");
                else
                    Console.WriteLine("Early");

                
                    var hours = Math.Abs((examTimeInMinutes - arriveTimeInMinutes) / 60);
                    var minutes = Math.Abs((examTimeInMinutes - arriveTimeInMinutes) % 60);

                    if (hours > 0)
                        if (minutes < 10)
                            Console.Write("{0}:0{1} hours", hours, minutes);
                        else
                            Console.Write("{0}:{1} hours", hours, minutes);


                    else
                        Console.Write("{0} minutes", minutes);

                    if (arriveTimeInMinutes > examTimeInMinutes)
                        Console.WriteLine(" after the start.");
                    else
                        Console.WriteLine(" before the start.");
                


              










          //  if (arriveTimeInMinutes > examMinutes)
           // {
          //      var minutesLate = arriveTimeInMinutes - examTimeInMinutes;
          //      if (minutesLate < 10)
           //         Console.WriteLine("0:{0} minutes after the start", minutesLate);

          //      else if (minutesLate < 60)
           //         Console.WriteLine("{0} minutes after the start", minutesLate);

           //     else if (minutesLate >=60)
            //        var hoursLate = Math.Floor(minutesLate / 60);


         //   }

        }
    }
}
