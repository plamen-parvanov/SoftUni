namespace _08.Most_Frequent_Numberr
{
    using System;


    public class Arrays
    {

        public static void Main()
        {
            string input = Console.ReadLine();

            ushort[] numberArr = InitializeUshortArrFromInput(input);

            ushort[] countArr = new ushort[ushort.MaxValue];
            int maxCount = 0;
            int number = 0;

            for (int i = 0; i < numberArr.Length; i++)
            {
                ushort numberCount = numberArr[i];
                countArr[numberCount]++;

                for (int j = 0; j < countArr.Length; j++)
                {
                    if (countArr[j] > maxCount)
                    {
                        maxCount = countArr[j];
                        number = j;
                    }
                }
            }

           

           

            Console.WriteLine(number);
            



        }

        public static ushort[] InitializeUshortArrFromInput(string text)
        {
            string[] textSplited = text.Split(' ');
            ushort[] arr = new ushort[textSplited.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ushort.Parse(textSplited[i]);
            }

            return arr;
        }
    }
}
