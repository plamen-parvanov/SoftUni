using System;


namespace _06.Catch_the_Thief
{
    class CatchTheThief

    {
        static void Main()
        {
            string typeID = Console.ReadLine();
            int IDcounts = int.Parse(Console.ReadLine());

            long maxNumForType = long.MinValue;

            switch (typeID)
            {
                case "sbyte":
                    maxNumForType = GetMaxNumForSbyte(IDcounts, maxNumForType);
                    break;

                case "int":
                    maxNumForType = GetMaxNumForInt(IDcounts, maxNumForType);
                    break;

                case "long":
                    maxNumForType = GetMaxNumForLong(IDcounts, maxNumForType);
                    break;
            }

            Console.WriteLine(maxNumForType);



        }

        private static long GetMaxNumForSbyte(int IDcounts, long maxNumForType)
        {
            for (int i = 0; i < IDcounts; i++)
            {
                try
                {
                    var num = sbyte.Parse(Console.ReadLine());
                    if (num > maxNumForType)
                    {
                        maxNumForType = num;
                    }
                }
                catch (Exception)
                {
                }
            }

            return maxNumForType;
        }

        private static long GetMaxNumForInt(int IDcounts, long maxNumForType)
        {
            for (int i = 0; i < IDcounts; i++)
            {
                try
                {
                    var num = int.Parse(Console.ReadLine());
                    if (num > maxNumForType)
                    {
                        maxNumForType = num;
                    }
                }
                catch (Exception)
                {
                }
            }

            return maxNumForType;
        }

        private static long GetMaxNumForLong(int IDcounts, long maxNumForType)
        {
            for (int i = 0; i < IDcounts; i++)
            {
                try
                {
                    var num = long.Parse(Console.ReadLine());
                    if (num > maxNumForType)
                    {
                        maxNumForType = num;
                    }
                }
                catch (Exception)
                {
                }
            }

            return maxNumForType;
        }
    }
}
