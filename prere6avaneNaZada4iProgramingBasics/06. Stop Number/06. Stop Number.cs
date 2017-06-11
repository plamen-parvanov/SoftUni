using System;


namespace _06.Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());

            for (int i = lastNum; i >= firstNum; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == stopNum)
                    {
                        return;
                    }
                    else
                    {
                        Console.Write("{0} ", i);
                    }
                }
            }
        }
    }
}
