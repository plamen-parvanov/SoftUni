namespace _09.Jump_Around
{
    using System;
    using System.Linq;

    public class Arrays
    {

        public static void Main()
        {
            var inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var currentIndex = 0;
            var sum = 0;
            
            while (true)
            {
                var nextIndex = currentIndex + inputArr[currentIndex];
                sum += inputArr[currentIndex];

                if (nextIndex > inputArr.Length - 1)
                {
                    nextIndex = currentIndex - inputArr[currentIndex];

                    if (nextIndex < 0)
                    {
                        break;
                    }
                }

               
                currentIndex = nextIndex;

            }

            Console.WriteLine(sum);

        }
    }
}
