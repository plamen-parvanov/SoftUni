namespace ConsoleApplication1001.Poke_Mon
{

    using System;


    public class ExamPartI
    {

        public static void Main()
        {

            var power = int.Parse(Console.ReadLine());
            var distance = int.Parse(Console.ReadLine());
            var exFactor = byte.Parse(Console.ReadLine());

            var pokeCntr = 0;
            var halfPower = power / 2d;

            while (power >= distance)
            {
                power -= distance;
                pokeCntr++;

                if (exFactor != 0 && power == halfPower )
                {
                    power /= exFactor;
                }
            }

            Console.WriteLine($"{power}\n{pokeCntr}");
        }
    }
}
