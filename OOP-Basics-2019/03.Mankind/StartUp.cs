namespace _03.Mankind
{
    using _03.Mankind.Models;
    using _03.Mankind.Factories;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                var studentInfo = Console.ReadLine();

                var student = Parse(studentInfo);

                var workerInfo = Console.ReadLine();

                var worker = Parse(workerInfo);

                Print(student);

                Console.WriteLine();

                Print(worker);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static Human Parse(string humanInfo)
        {
            var arr = humanInfo.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            if (arr.Length == 3)
            {
                return StudentFactory.CreateStudent(arr);
            }

            return WorkerFactory.CreateWorker(arr);            
        }

        private static void Print(Human human)
        {
            Console.WriteLine(human.ToString());
        }
    }
}
