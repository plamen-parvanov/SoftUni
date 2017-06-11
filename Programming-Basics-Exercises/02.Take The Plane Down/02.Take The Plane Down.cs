using System;

namespace _02.Take_The_Plane_Down
{
    class Program
    {
        static void Main(string[] args)
        {
            int xHeadquarter = int.Parse(Console.ReadLine());
            int yHeadquarter = int.Parse(Console.ReadLine());
            int radiusHq = int.Parse(Console.ReadLine());
            int enemyPlanes = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < enemyPlanes; i++)
            {
                int xEnemyPlanes = int.Parse(Console.ReadLine());
                int yEnemyPlanes = int.Parse(Console.ReadLine());

                int counter = xEnemyPlanes * xEnemyPlanes - 2 * xEnemyPlanes * xHeadquarter + xHeadquarter * xHeadquarter +
                yEnemyPlanes * yEnemyPlanes - 2 * yEnemyPlanes * yHeadquarter + yHeadquarter * yHeadquarter;

                if (counter <= radiusHq * radiusHq)
                {
                    Console.WriteLine("You destroyed a plane at [{0},{1}]", xEnemyPlanes, yEnemyPlanes);
                }
            }

            
        }
    }
}
