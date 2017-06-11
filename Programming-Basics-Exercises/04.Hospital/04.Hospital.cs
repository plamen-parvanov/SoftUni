using System;


namespace _04.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());
            var doctors = 7;
            var days = 0;
            var treated = 0;
            var untreated = 0;
            var treated3days = 0;
            var untreated3days = 0;

            for (int i = 0; i < period; i++)
            {
                var patients = int.Parse(Console.ReadLine());
                days += 1;
                if (days == 3)
                {
                    if (treated3days < untreated3days)
                    {
                        doctors += 1;
                    }
                    days = 0;
                   
                }

                if (patients - doctors > 0)
                {
                    
                    treated3days += doctors;
                    treated += doctors;
                    untreated += (patients - doctors);
                    untreated3days += untreated;
                }
                else
                {
                   
                    
                    treated += patients;
                    treated3days += patients;
                    
                }

            }
            Console.WriteLine("Treated patients: {0}.\nUntreated patients: {1}.",treated, untreated);




            //int days = int.Parse(Console.ReadLine());

            //int treatedPatients = 0;
            //int untreatedPatients = 0;

            //int doctors = 7;

            //for (int i = 1; i <= days; i++)
            //{
            //    int patients = int.Parse(Console.ReadLine());

            //    if (i % 3 == 0)
            //    {
            //        if (untreatedPatients > treatedPatients)
            //        {
            //            doctors++;
            //        }
            //    }

            //    if (patients <= doctors)
            //    {
            //        treatedPatients = patients + treatedPatients;
            //    }
            //    else
            //    {
            //        treatedPatients = doctors + treatedPatients;
            //        untreatedPatients = patients - doctors + untreatedPatients;
            //    }

            //}

            //Console.WriteLine("Treated patients: {0}.", treatedPatients);
            //Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}
