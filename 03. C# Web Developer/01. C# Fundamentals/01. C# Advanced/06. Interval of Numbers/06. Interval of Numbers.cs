namespace _06.Interval_of_Numbers
{

    using System;


    public class Problem06
    {

        public static void Main()
        {

            var num1 = byte.Parse(Console.ReadLine());
            var num2 = byte.Parse(Console.ReadLine());

            var startNum = num2;
            var endNum = num1;

            if (num1 < num2)
            {
                startNum = num1;
                endNum = num2;
            }

            for (; startNum <= endNum; startNum++)
            {
                Console.WriteLine(startNum);
            }

        }
    }
}
