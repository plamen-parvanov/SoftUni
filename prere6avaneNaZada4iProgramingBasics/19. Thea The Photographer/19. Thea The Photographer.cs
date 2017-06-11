using System;


namespace _19.Thea_The_Photographer
{
    class TheaThePhotographer

    {
        static void Main()
        {
            long picsNum = long.Parse(Console.ReadLine());
            long filterTimePer1 = long.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine());
            long uploadTimePer1 = long.Parse(Console.ReadLine());

            int goodPics = (int)Math.Ceiling(picsNum * filterFactor / 100);
            long filterTimeSec = picsNum * filterTimePer1;
            long uploadTimeSec = goodPics * uploadTimePer1;
            long totalTimeSec = filterTimeSec + uploadTimeSec;

            long second = 0;
            long min = 0;
            long hours = 0;
            long days = totalTimeSec / (24 * 3600);
            totalTimeSec -= days * (24 * 3600);

            while (totalTimeSec > 59)
            {
                totalTimeSec -= 60;
                min++;

                if (min > 59)
                {
                    min -= 60;
                    hours++;
                }
               
            }

            Console.WriteLine($"{days}:{hours:d2}:{min:d2}:{totalTimeSec:d2}");
            
        }
    }
}
