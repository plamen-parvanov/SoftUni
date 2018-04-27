namespace _05.BPM_Counter
{

    using System;


    public class Problem05
    {

        public static void Main()
        {

            var beatsPerMin = int.Parse(Console.ReadLine());
            var beats = int.Parse(Console.ReadLine());

            var bars = Math.Round(beats / 4d , 1);
            var time = (int)Math.Floor(beats / (double)beatsPerMin * 60);
            

            Console.Write($"{bars} bars - ");
            Console.WriteLine("{0:d1}m {1:d1}s", time / 60, time % 60);

        }
    }
}
