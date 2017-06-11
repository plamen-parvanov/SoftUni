using System;


namespace Problem_04___Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lections = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double salaryJelev = 0;
            double salaryRoYal = 0;
            double salaryRoli = 0;
            double salaryTrofon = 0;
            double salarySino = 0;
            double salaryOthers = 0;
            double salaryPerLection = budget / lections;
            for (int i = 0; i < lections; i++)
            {
                string lector = Console.ReadLine();
                switch (lector)
                {
                    case "Jelev":
                        salaryJelev += salaryPerLection;
                        break;
                    case "RoYaL":
                        salaryRoYal += salaryPerLection;
                        break;
                    case "Roli":
                        salaryRoli += salaryPerLection;
                        break;
                    case "Trofon":
                        salaryTrofon += salaryPerLection;
                        break;
                    case "Sino":
                        salarySino += salaryPerLection;
                        break;
                    default:
                        salaryOthers +=salaryPerLection;
                        break;
                }
            }
           
            Console.WriteLine("Jelev salary: {0:f2} lv\nRoYaL salary: {1:f2} lv\nRoli salary: {2:f2} lv\nTrofon salary: {3:f2} lv\nSino salary: {4:f2} lv\nOthers salary: {5:f2} lv",
                salaryJelev, salaryRoYal, salaryRoli, salaryTrofon, salarySino, salaryOthers);
        }
    }
}
