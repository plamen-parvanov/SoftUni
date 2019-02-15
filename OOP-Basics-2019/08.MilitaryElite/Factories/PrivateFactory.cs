namespace _08.MilitaryElite.Factories
{
    using Models;

    public static class PrivateFactory
    {
        public static Private CreatePrivate(string[] arr)
        {
            var id = arr[0];
            var firstName = arr[1];
            var lastName = arr[2];
            var salary = decimal.Parse(arr[3]);

            return new Private(id, firstName, lastName, salary);
        }
    }
}
