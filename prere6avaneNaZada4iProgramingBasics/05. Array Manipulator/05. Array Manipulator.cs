namespace _05.Array_Manipulator
{

    using System;
    using System.Linq;

    public class Lists
    {

        public static void Main()
        {
            var numArr = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var commandsArr = Console.ReadLine().Split().ToArray();
            var command = commandsArr[0];

            while (command != "print")
            {
                switch (command)
                {
                    case "add":
                        numArr = AddNumber(commandsArr, numArr);
                        break;

                    case "addMany":
                        numArr = AddManyNumbers(commandsArr, numArr);
                        
                        break;

                    case "contains":
                        var index = ScanForNumber(commandsArr, numArr);
                        Console.WriteLine(index);
                        break;

                    case "remove":
                        numArr = RemoveElement(commandsArr, numArr);
                        break;

                    case "shift":
                        numArr = ShiftElements(commandsArr, numArr);
                        break;

                    case "sumPairs":
                        numArr = SumArrElementsByPAir(commandsArr, numArr);
                        break;
                }

                commandsArr = Console.ReadLine().Split().ToArray();
                command = commandsArr[0];

            }

            Console.WriteLine("[" +string.Join(", ", numArr) + "]");

        }

        public static long[] AddNumber(string[] comandArr, long[] oldArr)
        {
            var index = long.Parse(comandArr[1]);
            var element = long.Parse(comandArr[2]);
            var newArr = new long[oldArr.Length + 1];

            for (long i = 0; i < index; i++)
            {
                newArr[i] = oldArr[i];
            }

            newArr[index] = element;

            for (long i = index + 1; i < newArr.Length; i++)
            {
                newArr[i] = oldArr[i - 1];
            }

            return newArr;


        }

        public static long[] AddManyNumbers(string[] comandArr, long[] oldArr)
        {
            var index = long.Parse(comandArr[1]);
            var newArr = new long[oldArr.Length + comandArr.Length - 2];

            for (long i = 0; i < index; i++)
            {
                newArr[i] = oldArr[i];
            }

            for (long i = index, j = 2; i < index + comandArr.Length - 2; i++, j++)
            {
                newArr[i] = int.Parse(comandArr[j]);
            }

            for (long i = index + comandArr.Length - 2, j = index; i < newArr.Length; i++, j++)
            {
                newArr[i] = oldArr[j];
            }

            return newArr;

        }

        public static long ScanForNumber(string[] commandsArr, long[] numArr)
        {
            long elementToFind = long.Parse(commandsArr[1]);
            long index = -1;

            for (long i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] == elementToFind)
                {
                    index = i;
                    return index;
                }
            }

            return index;

        }

        public static long[] RemoveElement(string[] commandsArr, long[] oldArr)
        {
            var newArr = new long[oldArr.Length - 1];
            var index = long.Parse(commandsArr[1]);

            for (long i = 0; i < index; i++)
            {
                newArr[i] = oldArr[i];
            }

            for (long i = index; i < newArr.Length; i++)
            {
                newArr[i] = oldArr[i + 1];
            }

            return newArr;

        }

        public static long[] ShiftElements(string[] commandsArr, long[] numArr)
        {
            long rotateIndex = long.Parse(commandsArr[1]);
            
            for (long i = 0; i < rotateIndex % numArr.Length; i++)
            {
                long temp = numArr[0];

                for (int j = 0; j < numArr.Length - 1; j++)
                {
                    numArr[j] = numArr[j + 1];
                }

                numArr[numArr.Length - 1] = temp;
            }

            

            return numArr;
        }

        public static long[] SumArrElementsByPAir(string[] commandsArr, long[] oldArr)
        {
            var newArr = new long[(oldArr.Length + 1) / 2];

            for (int i = 0, j = 0; i < newArr.Length; i++, j += 2)
            {
                long firstNum = oldArr[j];
                long secondNum = oldArr[j + 1];
                if (oldArr.Length <= j + 1)
                {
                    secondNum = 0;
                }
                newArr[i] = oldArr[j] + oldArr[j + 1];
            }

            return newArr;
        }
    }
}
