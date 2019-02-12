using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person(1);
            var teacher = new Teacher(11);
            var ut = new UniversityTeacher(111);
            
            Person t = teacher;
            Person u = ut;
            
            Console.WriteLine(t.Info);
            Console.WriteLine(u.Info);

            Console.WriteLine(t.Age);
            Console.WriteLine(u.Age);

            //Console.WriteLine(person.Age);
            //Console.WriteLine(teacher.Age);
            //Console.WriteLine(ut.Age);

        }
    }
}
