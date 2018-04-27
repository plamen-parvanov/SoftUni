using System;


namespace _08.House_Builder
{
    class HouseBuilder

    {
        static void Main()
        {
            var firstInput = int.Parse(Console.ReadLine());
            var secondInput = int.Parse(Console.ReadLine());

            long result = 0;

            if (firstInput < 128)
            {
                result += (long)4 * firstInput;
                result += (long)10 * secondInput;
            }
            else
            {
                result += (long)10 * firstInput;
                result += (long)4 * secondInput;
            }

            Console.WriteLine(result);
        }
    }
}
