using System;


namespace _04.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            double allFans = double.Parse(Console.ReadLine());

            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double CSKA = 0;

            for (int i = 0; i < allFans; i++)
            {
                string fansInSector = Console.ReadLine();

                switch (fansInSector)
                {
                    case "A":
                        sectorA++;
                        break;
                    case "B":
                        sectorB++;
                        break;
                    case "V":
                        sectorV++;
                        break;
                    case "G":
                        CSKA++;
                        break;
                }
            }
            Console.WriteLine("{0:f2}%\n{1:f2}%\n{2:f2}%\n{3:f2}%\n{4:f2}%", sectorA / allFans * 100,
                sectorB / allFans * 100, sectorV / allFans * 100, CSKA / allFans * 100,
                allFans / capacity * 100); 
        }
    }
}
