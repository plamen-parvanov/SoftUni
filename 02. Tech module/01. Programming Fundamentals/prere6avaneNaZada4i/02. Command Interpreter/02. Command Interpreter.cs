namespace _02.Command_Interpreter
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    public class ExamPreoarationIII
    {

        public static void Main()
        {
            var inputArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                var command = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (command[0].Equals("end"))
                {
                    break;
                }

                switch (command[0])
                {
                    case "reverse":
                        ReverseArr(command, inputArr);
                        break;
                       
                    case "sort":
                        SortArr(command, inputArr);
                        break;
                    //case "rotateLeft":
                    //    RotateArr();
                    //    break;
                    //case "RotateRight":
                    //    RotateArr(-);
                    //    break;
                }


            }
        }

        public static void ReverseArr(string[] command, string[] arr)
        {
            var start = int.Parse(command[2]);
            var count = int.Parse(command[4]);
            var arrLength = arr.Length;

            if (!CheckIndexesOutOfArr(start, count, arrLength))
            {
                return;
            }

            for (int i = 0; i < count / 2; i++)
            {
                var temp = arr[i + start];
                arr[i + start] = arr[start + count -1 - i];
                arr[start + count -1 - i] = temp;
            }
            
        }

        public static bool CheckIndexesOutOfArr(int start, int count, int length)
        {
            var isValid = true;

            if (start < 0 || start > length -1 ||
                start + count - 1 < 0 || start + count - 1 > length)
            {
                isValid = false;
            }
            return isValid;
        }

        public static void SortArr(string[] command, string[] arr)
        {
            var start = int.Parse(command[2]);
            var count = int.Parse(command[4]);

            var tempList = new List<string>();

            for (int i = start, j = 0; i < start + count; i++, j++)
            {
                tempList[j] = arr[i];
            }

            tempList.Sort();

            for (int i = start, j = 0; i < start + count; i++, j++)
            {
                arr[i] = tempList[j];
            }


        }
    }
}
