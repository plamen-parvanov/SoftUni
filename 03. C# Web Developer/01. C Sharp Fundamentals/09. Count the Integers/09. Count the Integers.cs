namespace _09.Count_the_Integers
{

    using System;


    public class Problem09
    {

        public static void Main()
        {

            var cntr = 0;

            while (true)
            {
                try
                {
                    var num = int.Parse(Console.ReadLine());
                    cntr++;
                }
                catch (Exception)
                {
                    break;
                }

            }

            Console.WriteLine(cntr);
        }
    }
}
