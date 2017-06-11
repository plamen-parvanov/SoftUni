using System;


namespace _02___Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());
            var hoursWorked = workers * workDays * 8;

            if (hoursWorked > hoursNeeded)
            {
                Console.WriteLine("{0} hours left", hoursWorked - hoursNeeded);
            }

            else if (hoursWorked < hoursNeeded)
            {
                Console.WriteLine("{0} overtime\nPenalties: {1}", hoursNeeded - hoursWorked,
                    workDays * (hoursNeeded - hoursWorked));
            }

        }
    }
}
