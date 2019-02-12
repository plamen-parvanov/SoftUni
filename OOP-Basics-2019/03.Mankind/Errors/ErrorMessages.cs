namespace _03.Mankind.Errors
{
    public static class ErrorMessages
    {
        public static string InvalidFirstNameFirstLetter =>
            "Expected upper case letter! Argument: {0}";

        public static string InvalidFirstNameLenght =>
            "Expected length at least {0} symbols! Argument: {1}";

        public static string InvalidFacultyNumber =>
            "Invalid faculty number!";

        public static string InvalidWorkerArgument =>
            "Expected value mismatch! Argument: {0}";
    }
}
