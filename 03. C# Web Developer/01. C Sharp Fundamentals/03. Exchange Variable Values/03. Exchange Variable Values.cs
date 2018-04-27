namespace _03.Exchange_Variable_Values
{

    using System;

    public class Problem03
    {

        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            

            var temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
