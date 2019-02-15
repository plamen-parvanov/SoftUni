namespace _08.MilitaryElite.Factories
{
    using Models.Missions;
    using Models.Spldiers.SpecialisedSoldiers;
    using System.Collections.Generic;
    using System.Linq;

    public static class CommandoFactory
    {
        public static Commando CreateCommando(string[] arr)
        {
            var id = arr[0];
            var firstName = arr[1];
            var lastName = arr[2];
            var salary = decimal.Parse(arr[3]);
            var corp = arr[4];
            var missions = CreateMissionsList(arr.Skip(5).ToArray());

            return new Commando(id, firstName, lastName, salary, corp, missions);
        }

        private static IReadOnlyCollection<Mission> CreateMissionsList(string[] arr)
        {
            var list = new List<Mission>();

            for (int i = 0; i < arr.Length; i += 2)
            {
                var name = arr[i];
                var state = arr[i + 1];

                try
                {
                    var currentMission = MissionFactory.CreateMission(name, state);

                    list.Add(currentMission);
                }
                catch (System.ArgumentException)
                {
                    continue;
                }
            }

            return list;
        }
    }
}
