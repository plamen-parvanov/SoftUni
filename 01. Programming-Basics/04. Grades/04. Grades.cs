using System;


namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var top = 0.0;
            var above4 = 0.0;
            var above3 = 0.0;
            var fail = 0.0;
            var average = 0.0;

            for (int i = 0; i < n; i++)
            {
                var grade = double.Parse(Console.ReadLine());

                if (grade >= 5)
                {
                    top += 1;
                }

                else if (grade >= 4)
                {
                    above4 += 1;
                }

                else if (grade >= 3)
                {
                    above3 += 1;
                }

                else if (grade >= 2)
                {
                    fail += 1;
                }
                average += grade;
            }
            average /= n ;
            top *= 100d / n;
            above4 *=  100d / n;
            above3 *= 100d / n;
            fail *= 100d / n;
            Console.WriteLine(
 "Top students: {0:f2}%\nBetween 4.00 and 4.99: {1:f2}%\nBetween 3.00 and 3.99: {2:f2}%\nFail: {3:f2}%\nAverage: {4:F2}"
                , top, above4, above3, fail, average);
        }
    }
}
