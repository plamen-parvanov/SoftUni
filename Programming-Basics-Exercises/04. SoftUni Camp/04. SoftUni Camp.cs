using System;


namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var train = 0;
            var bus = 0;
            var minibus = 0;
            var microbus = 0;
            var car = 0;
            var allPeople = 0.0;
            

            for (int i = 0; i < n; i++)
            {
                var people = int.Parse(Console.ReadLine());

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

                allPeople += people;
            }
            var percentCar = car / allPeople * 100;
            var percentMicrobus = microbus / allPeople * 100;
            var percenMinibus = minibus / allPeople * 100;
            var percentBus = bus / allPeople * 100;
            var percentTrain = train / allPeople * 100;

            Console.WriteLine("{0:f2}% \n{1:f2}% \n{2:f2}% \n{3:f2}% \n{4:f2}%",
                percentCar, percentMicrobus, percenMinibus, percentBus, percentTrain);
        }
    }
}
