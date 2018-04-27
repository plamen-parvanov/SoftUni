using System;


namespace _07.Sentence_the_Thief
{
    class SentenceThief

    {
        static void Main()
        {
            string type = Console.ReadLine();
            byte n = byte.Parse(Console.ReadLine());

            long maxNum = long.MinValue;

            switch(type)
            {
                case "sbyte":
                    maxNum = MaxNumSbyte(n, maxNum);
                    break;

                case "int":
                    maxNum = MaxNumInt(n, maxNum);
                    break;

                case "long":
                    maxNum = MaxNumLong(n, maxNum);
                    break;
            }
            long yearsJail = 0;
            if (maxNum < 0)
            {
                yearsJail = (long)Math.Ceiling(maxNum / -128d); 
            }
            else
            {
                yearsJail = (long)Math.Ceiling(maxNum / 127d);
            }

            if (yearsJail > 1)
            {
                Console.WriteLine("Prisoner with id {0} is sentenced to {1} years",
                    maxNum, yearsJail);
            }
            else
            {
                Console.WriteLine($"Prisoner with id {maxNum} is sentenced to 1 year");
            }


        }

        private static long MaxNumSbyte(byte n, long maxNum)
        {
            for (int i = 0; i < n; i++)
            {
                try
                {
                    var num = sbyte.Parse(Console.ReadLine());
                    if (num > maxNum)
                    {
                        maxNum = num;
                    }
                }
                catch { }
            }

            return maxNum;
        }

        private static long MaxNumInt(byte n, long maxNum)
        {
            for (int i = 0; i < n; i++)
            {
                try
                {
                    var num = int.Parse(Console.ReadLine());
                    if (num > maxNum)
                    {
                        maxNum = num;
                    }
                }
                catch { }
            }

            return maxNum;
        }

        private static long MaxNumLong(byte n, long maxNum)
        {
            for (int i = 0; i < n; i++)
            {
                try
                {
                    var num = long.Parse(Console.ReadLine());
                    if (num > maxNum)
                    {
                        maxNum = num;
                    }
                }
                catch { }
            }

            return maxNum;
        }
    }
}
