using System;


namespace Problem_02___Encoded_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var answer = "";
            var answerNew = "";
            var answerA = 0;
            var answerB = 0;
            var answerC = 0;
            var answerD = 0;


            for (int i = 0; i < n; i++)
            {
                var num = uint.Parse(Console.ReadLine());

                if (num % 4 == 0)
                {
                    answerNew = "a";
                    answerA ++;
                }
                else if (num % 4 == 1)
                {
                    answerNew = "b";
                    answerB += 1;
                }
                else if (num % 4 == 2 )
                {
                    answerNew = "c";
                    answerC += 1;
                }
                else if (num % 4 == 3)
                {
                    answerNew = "d";
                    answerD += 1;
                }
                answer += answerNew + " "; 
                //answer += answerNew + ' ';
            }
            Console.WriteLine(answer);
            Console.WriteLine("Answer A: {0}\nAnswer B: {1}\nAnswer C: {2}\nAnswer D: {3}",
                answerA, answerB, answerC, answerD);
        }
    }
}
