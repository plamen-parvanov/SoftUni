namespace _08.MilitaryElite.Factories
{
    using Models.Repairs;
    using Models.SpecialisedSoldiers;
    using System.Collections.Generic;
    using System.Linq;

    public static class EngineerFactory
    {
        public static Engineer CreateEmgeneer(string[] arr)
        {
            var id = arr[0];
            var firstName = arr[1];
            var lastName = arr[2];
            var salary = decimal.Parse(arr[3]);
            var corp = arr[4];
            var repairs = CreateRepairsList(arr.Skip(5).ToArray());

            return new Engineer(id, firstName, lastName, salary, corp, repairs);
        }

        private static IReadOnlyCollection<Repair> CreateRepairsList(string[] arr)
        {
            var list = new List<Repair>();

            for (int i = 0; i < arr.Length; i += 2)
            {
                var part = arr[i];
                var hours = int.Parse(arr[i + 1]);

                var currentRepair = RepairFactory.CreateRepair(part, hours);

                list.Add(currentRepair);
            }

            return list;
        }
    }
}
