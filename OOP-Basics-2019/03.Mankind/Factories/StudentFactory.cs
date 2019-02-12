using _03.Mankind.Models;

namespace _03.Mankind.Factories
{
    public abstract class StudentFactory
    {
        public static Student CreateStudent(string[] strudentInfoArr)
        {
            var firstName = strudentInfoArr[0];
            var lastName = strudentInfoArr[1];
            var facultyNumber = strudentInfoArr[2];

            return new Student(firstName, lastName, facultyNumber);
        }
    }
}
