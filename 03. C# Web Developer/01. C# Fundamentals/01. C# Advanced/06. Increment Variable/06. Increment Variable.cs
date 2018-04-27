namespace _06.Increment_Variable
{

    using System;

    public class Problem06
    {

        public static void Main()
        {

            var inputNum = int.Parse(Console.ReadLine());
            //var overflowed = Math.Floor(inputNum / 256d);
            //var result = inputNum - overflowed * 256;

            //Console.WriteLine(result);

            //if (overflowed > 0)
            //{
            //    Console.WriteLine($"Overflowed {overflowed} times");
            //}

            var overfloadTimes = 0;
            byte num = 0;
            for (int i = 0; i < inputNum; i++)
            {
                num++;

                if (num == 0)
                {
                    overfloadTimes++;
                }
            }

            Console.WriteLine(num);

            if (overfloadTimes > 0)
            {
                Console.WriteLine($"Overflowed {overfloadTimes} times");
            }
        }
    }
}
