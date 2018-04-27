using System;


namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int train = 0;
            int bus = 0;
            int minibus = 0;
            int microbus = 0;
            int car = 0;

            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());

                if (people >= 41)
                {
                    train += people;
                }
                else if (people >= 26)
                {
                    bus += people;
                }
                else if (people >= 13)
                {
                    minibus += people;
                }
                else if (people >= 6)
                {
                    microbus += people;
                }
                else
                {
                    car += people;
                }
            }

            double allPeople = train + bus + minibus + microbus + car;
            Console.WriteLine("{0:f2}%\n{1:f2}%\n{2:f2}%\n{3:f2}%\n{4:f2}%", car / allPeople * 100,
                microbus / allPeople * 100, minibus / allPeople * 100, 
                bus / allPeople * 100, train / allPeople * 100);

        }
    }
}
