using System;


namespace _10.Cube_Properties
{
    class Program
    {
        static void Main()
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            double result = 0;

            result = ClaculatesParameterOfCube(sideOfCube, parameter, result);

            Console.WriteLine("{0:F2}",result);

        }

        private static double ClaculatesParameterOfCube(double sideOfCube, string parameter, double result)
        {
            switch (parameter)
            {
                case "space":
                    result = Math.Sqrt(3 * sideOfCube * sideOfCube);
                    break;
                case "face":
                    result = Math.Sqrt(2 * sideOfCube * sideOfCube);
                    break;
                case "volume":
                    result = Math.Pow(sideOfCube, 3);
                    break;
                case "area":
                    result = 6 * sideOfCube * sideOfCube;
                    break;
            }
            return result;
        }
    }
}
