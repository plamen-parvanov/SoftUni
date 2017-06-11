using System;


namespace _08.Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oldNum = int.MinValue;
            int counter = 0;
            int oldCounter = 0;
            for (int i = 0; i < n; i++)
            {
                int nextNum = int.Parse(Console.ReadLine());

                if (nextNum > oldNum)
                {
                    counter++;
                    //if (counter > oldCounter)
                    //{
                    //    oldCounter = counter;
                    //}
                }
                else
                {
                    oldCounter = Math.Max(oldCounter, counter);
                    counter = 1;
                }
                oldNum = nextNum;             
            }
            Console.WriteLine(Math.Max(oldCounter, counter));
        }
    }
}
