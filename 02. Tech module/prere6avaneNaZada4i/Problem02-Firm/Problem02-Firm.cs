using System;


namespace Problem02_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysHave = int.Parse(Console.ReadLine());
            int workersXtraTime = int.Parse(Console.ReadLine());

            double hoursWork = Math.Floor(daysHave * (0.9 * 8 + 2 * workersXtraTime));

            if (hoursNeeded <= hoursWork )
            {
                Console.WriteLine("Yes!{0} hours left.", hoursWork - hoursNeeded);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", hoursNeeded - hoursWork);
            }
        }
    }
}
