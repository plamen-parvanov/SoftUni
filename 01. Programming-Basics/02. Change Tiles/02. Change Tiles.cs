using System;

namespace _02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var aFloor = double.Parse(Console.ReadLine());
            var bFloor = double.Parse(Console.ReadLine());
            var aTiles = double.Parse(Console.ReadLine());
            var hTiles = double.Parse(Console.ReadLine());
            var priceTiles = double.Parse(Console.ReadLine());
            var worker = double.Parse(Console.ReadLine());

            var sFloor = aFloor * bFloor;
            var sTiles = aTiles * hTiles / 2;
            var tilesNedded = Math.Ceiling(sFloor / sTiles) + 5;
            var total = tilesNedded * priceTiles + worker;
            
            if (money >= total )
            {
                Console.WriteLine("{0:f2} lv left.", money - total);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", total - money );
            }
        }
    }
}
