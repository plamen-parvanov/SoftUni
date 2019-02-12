namespace _01.ClassBox
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                var box = ParseBoxFromInput();

                Console.WriteLine($"Surface Area - {box.CalculateSurfaceArea():F2}");
                Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralSurfaceArea():F2}");
                Console.WriteLine($"Volume - {box.CalculateVolume():F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }        

        }

        private static Box ParseBoxFromInput()
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            return new Box(length, width, height);
        }
    }
}
