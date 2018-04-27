using System;


namespace _10.Ballistics_Training
{
    class Program
    {
        static void Main()
        {
            string planeCoordinates = Console.ReadLine();

            string[] planeCoordinatesArr = planeCoordinates.Split(' ');
            double planeX = double.Parse(planeCoordinatesArr[0]);
            double planeY = double.Parse(planeCoordinatesArr[1]);
           
            string shootingCoordinates = Console.ReadLine();
            string[] shootingCoordinatesArr = shootingCoordinates.Split(' ');
            double shootingX = 0;
            double shootingY = 0;

            

            for (int i = 0; i < shootingCoordinatesArr.Length; i += 2)
            {
                ExecuteShootingComands(shootingCoordinatesArr, ref shootingX, ref shootingY, i);

                if (shootingX == planeX && shootingY == planeY)
                {
                    Console.WriteLine($"firing at [{ planeX}, { planeY}]");
                    Console.WriteLine("got 'em!");
                    return;
                }
            }
            Console.WriteLine($"firing at [{ shootingX}, { shootingY}]");
            Console.WriteLine("better luck next time...");

        }

        private static void ExecuteShootingComands(string[] shootingCoordinatesArr, ref double shootingX, ref double shootingY, int i)
        {
            switch (shootingCoordinatesArr[i])
            {
                case "up":
                    shootingY += double.Parse(shootingCoordinatesArr[i + 1]);
                    break;
                case "down":
                    shootingY -= double.Parse(shootingCoordinatesArr[i + 1]);
                    break;
                case "right":
                    shootingX += double.Parse(shootingCoordinatesArr[i + 1]);
                    break;
                case "left":
                    shootingX -= double.Parse(shootingCoordinatesArr[i + 1]);
                    break;
            }
        }
    }
}
