namespace _07.Social_Media_Posts
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem07
    {
        static Dictionary<string, int[]> dictLikes;
        static Dictionary<string, List<string>> dictComments;
        public static void Main()
        {
            dictLikes = new Dictionary<string, int[]>();
            dictComments = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "drop the media")
                {
                    break;
                }

                var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                ExecuteCommand(arr);
            }

            PrintResult();
        }

        public static void ExecuteCommand(string[] arr)
        {
            var command = arr[0];
            var post = arr[1];

            switch (command)
            {
                case "post":
                    dictComments[post] = new List<string>();
                    dictLikes[post] = new int[2];
                    break;
                case "like":
                    dictLikes[post][0]++;
                    break;
                case "dislike":
                    dictLikes[post][1]++;
                    break;
                case "comment":
                    var name = arr[2];
                    var comm = string.Join(" ", arr.Skip(3));
                    var result = "*  " + name + ": " + comm;
                    dictComments[post].Add(result);
                    break;    
            }
        }

        public static void PrintResult()
        {
            foreach (var kvp in dictLikes)
            {
                var key = kvp.Key;
                var likes = kvp.Value[0];
                var dislikes = kvp.Value[1];
                var comments = dictComments[key];
                Console.WriteLine($"Post: {key} | Likes: {likes} | Dislikes: {dislikes}");
                Console.WriteLine("Comments:");
                if (comments.Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    Console.WriteLine(string.Join(Environment.NewLine, comments));

                }
            }
        }
    }
}
