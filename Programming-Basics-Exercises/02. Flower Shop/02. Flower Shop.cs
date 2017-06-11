using System;

namespace _02.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnolii = int.Parse(Console.ReadLine());
            var zumbuli = int.Parse(Console.ReadLine());
            var rozi = int.Parse(Console.ReadLine());
            var kaktusi = int.Parse(Console.ReadLine());
            var present = double.Parse(Console.ReadLine());

            var money = magnolii * 3.25 + zumbuli * 4.0 + rozi * 3.5 + kaktusi * 8.0;
            var withoutTaxes = money - 0.05 * money;

            if (withoutTaxes >= present)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(withoutTaxes - present));
            }

            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(present - withoutTaxes));
            }
        }
    }
}
