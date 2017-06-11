using System;


namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var bigger = 0;
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var next = int.Parse(Console.ReadLine());

                if (next > bigger)
                {
                    sum += bigger;
                    bigger = next;
                }
                else
                {
                    sum += next;
                }
            }

            if (bigger == sum)
            {
                Console.WriteLine("Yes sum = " + sum);
            }
            else
            {
                Console.WriteLine("No Diff = " + Math.Abs(sum - bigger));
            }
        }
    }
}
