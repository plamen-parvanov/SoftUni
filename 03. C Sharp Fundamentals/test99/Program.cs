namespace test99
{

    using System;

    public class test
    {

        public static void Main()
        {
            var num = "1234f";
            var result = 1111; // ili var result samo bez stoinost
            

            if (int.TryParse(num, out result))
            {
                Console.WriteLine($"{result} is a number");
            }
            else
            {
                Console.WriteLine("Not a number!");
            }
        }
    }
}
