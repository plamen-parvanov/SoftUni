namespace _08.MilitaryElite.Factories
{
    using Models.Spldiers;

    public static class SpyFactory
    {
        public static Spy CreateSpy(string[] arr)
        {
            var id = arr[0];
            var firstName = arr[1];
            var lastName = arr[2];
            var codeNumber = int.Parse(arr[3]);

            return new Spy(id, firstName,lastName, codeNumber);
        }
    }
}
