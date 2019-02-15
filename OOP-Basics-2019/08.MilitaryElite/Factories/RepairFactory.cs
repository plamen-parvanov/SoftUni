namespace _08.MilitaryElite.Factories
{
    using Models.Repairs;

    public static class RepairFactory
    {
        public static Repair CreateRepair(string part, int hours)
        {
            return new Repair(part, hours);
        }
    }
}
