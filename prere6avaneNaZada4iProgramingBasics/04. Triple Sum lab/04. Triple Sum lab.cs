namespace _04.Triple_Sum_lab
{
    using System;


    public class Arrays
    {
        // ne raboti 60 ot 100 , re6enieto e s namiraneto 1vo na a i b i sled tova c + break;
        public static void Main()
        {
            string text = Console.ReadLine();
            string[] textSplited = text.Split(' ');

            int[] numbersArr = new int[textSplited.Length];
            InitNumbersArr(textSplited, numbersArr);
            bool isTripleElement = false;

            foreach (var number in numbersArr)
            {
                int c = number;
                isTripleElement = NewMethod(numbersArr, isTripleElement, c);
            }

            if (!isTripleElement)
            {
                Console.WriteLine("No");
            }

        }

        private static bool NewMethod(int[] numbersArr, bool isTripleElement, int c)
        {
            for (int i = 0; i < numbersArr.Length; i++)
            {
                int a = numbersArr[i];

                for (int j = i + 1; j < numbersArr.Length; j++)
                {
                    int b = numbersArr[j];

                    if (a + b == c)
                    {
                        isTripleElement = true;
                        Console.WriteLine($"{a} + {b} == {c}");
                        return isTripleElement;



                    }
                }
            }

            return isTripleElement;
        }

        public static void InitNumbersArr(string[] textSplited, int[] numbersArr)
        {
            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = int.Parse(textSplited[i]);
            }
        }
    }
}
