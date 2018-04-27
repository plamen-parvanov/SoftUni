using System;


namespace Problem04_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int treated = 0;
            int untreated = 0;
            int doctors = 7;


            for (int i = 1; i <= days; i++)
            {
                int patients = int.Parse(Console.ReadLine());
               
                if (i % 3 == 0 && untreated > treated )
                {
                    doctors++;
                }
                if (patients <= doctors)
                {
                    treated += patients;
                }
                else
                {
                    treated += doctors;
                    untreated += patients - doctors;
                }
               
            }

            Console.WriteLine("Treated patients: {0}.\nUntreated patients: {1}.", treated, untreated);
        }
    }
}
