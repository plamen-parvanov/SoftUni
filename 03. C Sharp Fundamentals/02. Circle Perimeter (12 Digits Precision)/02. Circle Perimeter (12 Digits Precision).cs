namespace _02.Circle_Perimeter__12_Digits_Precision_
{
    using System;


    public class Problem2
    {

        public static void Main()
        {
            var r = double.Parse(Console.ReadLine());
            var perimeter = 2 * Math.PI * r;

            Console.WriteLine("{0:F12}", perimeter);
        }
    }
}
