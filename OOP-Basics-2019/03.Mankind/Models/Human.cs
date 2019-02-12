namespace _03.Mankind.Models
{
    using _03.Mankind.Errors;
    using System;
    using System.Text;

    public abstract class Human
    {
        private const int FIRST_NAME_MIN_SYMBOLS = 4;
        private const int LAST_NAME_MIN_SYMBOLS = 3;

        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                ValidateFirstName(value);

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                ValidateLastName(value);

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");

            return sb.ToString().TrimEnd();
        }

        private void ValidateLastName(string value)
        {
            ValidateFirstLetter(value, nameof(this.lastName));

            ValidateNameLenght(value, LAST_NAME_MIN_SYMBOLS, nameof(this.lastName));
        }

        private void ValidateFirstName(string value)
        {
            ValidateFirstLetter(value, nameof(this.firstName));

            ValidateNameLenght(value, FIRST_NAME_MIN_SYMBOLS, nameof(this.firstName));
        }

        private void ValidateNameLenght(string value, int min, string arg)
        {
            if (value.Length < min)
            {
                throw new ArgumentException(
                    string.Format(ErrorMessages.InvalidFirstNameLenght, min, arg));
            }
        }

        private void ValidateFirstLetter(string value, string arg)
        {
            if (char.IsLower(value[0]))
            {
                throw new ArgumentException(
                      string.Format(ErrorMessages.InvalidFirstNameFirstLetter, arg));
            }
        }
    }
}
