namespace _06.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem06
    {
        private static Dictionary<string, User> dict;

        public static void Main()
        {
            dict = new Dictionary<string, User>();

            ReadInput();

            PrintMsgs();
        }

        public static void ReadInput()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "exit")
                {
                    break;
                }

                ReadLine(inputLine);
            }
        }

        public static void ReadLine(string input)
        {
            var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (arr[0] == "register")
            {
                dict.Add(arr[1], new User(arr[1]));
            }
            else if (dict.ContainsKey(arr[0])
                && dict.ContainsKey(arr[2]))
            {
                AddMsg(arr);
            }
        }

        public static void AddMsg(string[] arr)
        {
            var receiveUser = dict[arr[2]];
            var sendUser = dict[arr[0]];
            var msg = arr[3];

            dict[arr[2]].AddMsg(sendUser, msg);
        }

        public static void PrintMsgs()
        {
            var inputArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var user1 = inputArr[0];
            var user2 = inputArr[1];

            if (dict.ContainsKey(user1) && dict.ContainsKey(user2))
            {
                PrintMsgsBetween(user1, user2);
            }
            else
            {
                Console.WriteLine("No messages");
            }
        }

        public static void PrintMsgsBetween(string user1, string user2)
        {            
            var user1Msgs = GetMsgsBetween(user1, user2);
            var user2Msgs = GetMsgsBetween(user2, user1);
            var length = Math.Max(user1Msgs.Length, user2Msgs.Length);
            if (length == 0)
            {
                Console.WriteLine("No messages");
            }

            for (int i = 0; i < length; i++)
            {
                if (user2Msgs.Length > i)
                {
                    var firstUser = user2Msgs[i].Sender.Username;
                    var contentFirstUser = user2Msgs[i].Content;
                    Console.WriteLine($"{firstUser}: {contentFirstUser}");
                }

                if (user1Msgs.Length > i)
                {
                    var secondUser = user1Msgs[i].Sender.Username;
                    var contentSecondUser = user1Msgs[i].Content;
                    Console.WriteLine($"{contentSecondUser} :{secondUser}");
                }
            }
        }

        public static Message[] GetMsgsBetween(string user1, string user2)
        {
                return dict[user1].ReceivedMessages.Where(x => x.Sender == dict[user2]).ToArray();
            
            // sender.username == user2
        }
    }
}
