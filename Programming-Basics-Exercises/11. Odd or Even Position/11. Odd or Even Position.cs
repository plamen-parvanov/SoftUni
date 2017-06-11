using System;


namespace _11.Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var evenOldSmlNum = double.MaxValue;
            var evenOldBigNum = double.MinValue;
            var evenSum = 0d;
            var oddSum = 0d;
            var oddOldSmlNum = double.MaxValue;
            var oddOldBigNum = double.MinValue;

            if (n > 1)
            {


                for (int i = 1; i <= n; i++)
                {
                    var nextNum = double.Parse(Console.ReadLine());

                    if (i % 2 == 0)
                    {

                        if (nextNum > evenOldBigNum)
                        {
                            evenOldBigNum = nextNum;
                        }

                        if (nextNum < evenOldSmlNum)
                        {
                            evenOldSmlNum = nextNum;
                        }

                        evenSum += nextNum;
                    }

                    else
                    {

                        if (nextNum > oddOldBigNum)
                        {
                            oddOldBigNum = nextNum;
                        }

                        if (nextNum < oddOldSmlNum)
                        {
                            oddOldSmlNum = nextNum;
                        }

                        oddSum += nextNum;
                    }


                }
                Console.WriteLine("OddSum={0} \nOddMin={1} \nOddMax={2} \nEvenSum={3} \nEvenMin={4} \nEvenMax={5}",
                    oddSum, oddOldSmlNum, oddOldBigNum, evenSum, evenOldSmlNum, evenOldBigNum);
            }

            else if (n == 0)
            {
                Console.WriteLine("OddSum=0 \nOddMin=No \nOddMax=No \nEvenSum=0 \nEvenMin=No \nEvenMax=No");
            }

            else if (n == 1)
            {
                var num = int.Parse(Console.ReadLine());
                Console.WriteLine("OddSum={0} \nOddMin={0} \nOddMax={0} \nEvenSum=0 \nEvenMin=No \nEvenMax=No",
                    num);
            }

          

            //Console.WriteLine("OddSum=" +oddSum);
            //Console.Write("OddMin="); 
            //    if (oddOldSmlNum == double.MaxValue)
            //{
            //    Console.WriteLine("No");
            //}
            //else
            //{
            //    Console.WriteLine(oddOldSmlNum);
            //}



            //Console.Write("OddMax=");
            //if (oddOldBigNum == double.MinValue)
            //{
            //    Console.WriteLine("No");
            //}
            //else
            //{
            //    Console.WriteLine(oddOldBigNum);
            //}

            //Console.WriteLine("EvenSum=" +evenSum);
            //Console.Write("EvenMin=");
            //if (evenOldSmlNum == double.MaxValue)
            //{
            //    Console.WriteLine("No");
            //}
            //else
            //{
            //    Console.WriteLine(evenOldSmlNum);
            //}



            //Console.Write("EvenMax=");
            //if (evenOldBigNum == double.MinValue)
            //{
            //    Console.WriteLine("No");
            //}
            //else
            //{
            //    Console.WriteLine(evenOldBigNum);
            //}



        }
    }
}
