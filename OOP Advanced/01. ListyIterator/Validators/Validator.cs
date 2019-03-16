namespace _01._ListyIterator.Validators
{
    using System;

    public static class Validator
    {
        public static void CheckForEmptyCollection(int count)
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }
    }
}
