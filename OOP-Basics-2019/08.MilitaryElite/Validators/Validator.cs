namespace _08.MilitaryElite.Validators
{
    using System;

    public static class Validator
    {
        public static void ValidateCorps(string value)
        {
            if (value != "Airforces" && value != "Marines")
            {
                throw new ArgumentException();
            }
        }

        public static void ValidateMission(string value)
        {
            if (value != "inProgress" && value != "Finished")
            {
                throw new ArgumentException();
            }
        }
    }
}
