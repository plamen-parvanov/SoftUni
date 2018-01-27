namespace _03.Phonebook
{

    using System;

    public class Problem03
    {

        public static void Main()
        {
            var numbersArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var namesArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "done")
                {
                    break;
                }

                var command = input[0];

                if (command == "call")
                {
                    MakeCall(input[1], numbersArr, namesArr);
                }
                else if (command == "message")
                {
                    SendSMS(input[1], numbersArr, namesArr);
                }


            }

        }

        public static void SendSMS(string input, string[] nums, string[] names)
        {
            var index = 0;

            if (input[0] >= 'A' && input[0] <= 'z')
            {
                index = GetIndex(input, names);
                Console.WriteLine($"sending sms to {nums[index]}...");
            }
            else
            {
                index = GetIndex(input, nums);
                Console.WriteLine($"sending sms to {names[index]}...");
            }

            var sumOfDigits = CalculateSumOfDigits(nums[index]);

            PrintSMSInfo(sumOfDigits);
        }

        public static void MakeCall(string input, string[] nums, string[] names)
        {
            var index = 0;

            if (input[0] >= 'A' && input[0] <= 'z')
            {
                index = GetIndex(input, names);
                Console.WriteLine($"calling {nums[index]}...");
            }
            else
            {
                index = GetIndex(input, nums);
                Console.WriteLine($"calling {names[index]}...");
            }

            var sumOfDigits = CalculateSumOfDigits(nums[index]);

            PrintCallInfo(sumOfDigits);

        }

        public static int GetIndex(string input, string[] arr)
        {
            var index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (input == arr[i])
                {
                    index = i;
                    break;
                }

            }

            return index;
        }

        public static void PrintCallInfo(int sumOfDigits)
        {

            if (sumOfDigits % 2 != 0)
            {
                Console.WriteLine("no answer");
            }
            else
            {
                Console.WriteLine("call ended. duration: {0:d2}:{1:d2}",
                    sumOfDigits / 60, sumOfDigits % 60);
            }
        }

        public static void PrintSMSInfo(int sumOfDigits)
        {
            if (sumOfDigits % 2 != 0)
            {
                Console.WriteLine("busy");
            }
            else
            {
                Console.WriteLine("meet me there");
            }
        }

        public static int CalculateSumOfDigits(string number)
        {
            var sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < '0' || number[i] > '9')
                {
                    continue;
                }

                var currDigit = number[i] - '0';
                sum += currDigit;
            }

            return sum;
        }
    }
}
