namespace _06.Power_Plants
{

    using System;

    public class Problem06
    {
        static int days;

        public static void Main()
        {
            var plantArr = ReadArrFromConsole();
            var seasons = 0;

            while (true)
            {
                Whithering(plantArr);

                if (AreAllDead(plantArr))
                {
                    break;
                }

                BloomsCauseSeasonEnds(plantArr);

                seasons++;
            }

            Console.WriteLine($"survived {days} days ({seasons} seasons)");
        }

        public static int[] ReadArrFromConsole()
        {
            var input = Console.ReadLine();
            var strArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var intArr = new int[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                intArr[i] = int.Parse(strArr[i]);
            }

            return intArr;
        }

        public static void Whithering(int[] plantArr)
        {
            for (int i = 0; i < plantArr.Length; i++)
            {
                if (AreAllDead(plantArr))
                {
                    break;
                }

                days++;

                for (int j = 0; j < plantArr.Length; j++)
                {
                    if (i != j && plantArr[j] > 0)
                    {
                        plantArr[j]--;
                    }

                }
             
            }
        }

        public static bool AreAllDead(int[] plantArr)
        {
            var allDead = true;

            foreach (var plant in plantArr)
            {
                if (plant > 0)
                {
                    return false;
                }
            }

            return allDead;
        }

        public static void BloomsCauseSeasonEnds(int[] plantArr)
        {
            for (int i = 0; i < plantArr.Length; i++)
            {
                if (plantArr[i] > 0)
                {
                    plantArr[i]++;
                }

            }

        }
    }
}
