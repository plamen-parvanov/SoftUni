namespace _03.Mankind.Models
{
    using _03.Mankind.Errors;
    using System;
    using System.Linq;
    using System.Text;

    public class Student : Human
    {
        private const int FACULTY_MIN_LENGTH = 5;
        private const int FACULTY_MAX_LENGTH = 10;

        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            private set
            {
                ValidateFacultyNumber(value);

                this.facultyNumber = value;
            }
        }

        private void ValidateFacultyNumber(string value)
        {
            var length = value.Length;

            if (length < FACULTY_MIN_LENGTH || length > FACULTY_MAX_LENGTH ||
                !value.All(char.IsLetterOrDigit))
            {
                throw new ArgumentException(ErrorMessages.InvalidFacultyNumber);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Faculty number: {this.FacultyNumber}");

            return sb.ToString().TrimEnd();
        }
    }
}
