namespace _08.MilitaryElite.Factories
{
    using Models.Missions;

    public static class MissionFactory
    {
        public static Mission CreateMission(string name, string state)
        {
            return new Mission(name, state);
        }
    }
}
