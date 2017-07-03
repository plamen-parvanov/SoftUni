namespace _01.Order_by_Age
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    

    public class Program
    {

        public static void Main()
        {
            var inputLineArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var studentsList = new List<Student>();

            while (! inputLineArr[0].Equals("End"))
            {
                var name = inputLineArr[0];
                var personId = inputLineArr[1];
                var age = int.Parse(inputLineArr[2]);
                var curretStudent = new Student(name, personId, age);

                studentsList.Add(curretStudent);

                inputLineArr = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            }

            studentsList = studentsList.OrderBy(x => x.Age).ToList();


            foreach (var student in studentsList)
            {
                Console.WriteLine("{0} with ID: {1} is {2} years old.",
                    student.Name, student.PersonId, student.Age);
            }

        }
    }
}
