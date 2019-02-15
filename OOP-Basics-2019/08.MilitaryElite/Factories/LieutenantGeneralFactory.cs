namespace _08.MilitaryElite.Factories
{
    using _08.MilitaryElite.Models;
    using System.Collections.Generic;
    using System.Linq;

    public static class LieutenantGeneralFactory
    {
        public static LieutenantGeneral CreateLieutenantGeneral(string[] arr, IReadOnlyCollection<Soldier> soldiers)
        {
            var id = arr[0];
            var firstName = arr[1];
            var lastName = arr[2];
            var salary = decimal.Parse(arr[3]);

            var privates = CreatePrivatesList(arr.Skip(4).ToArray(), soldiers);

            return new LieutenantGeneral(id, firstName, lastName, salary, privates);
        }

        private static IReadOnlyCollection<Private> CreatePrivatesList(string[] arr, IReadOnlyCollection<Soldier> soldiers)
        {
            var list = new List<Private>();

            foreach (var id in arr)
            {
                var currentSoldier = soldiers.FirstOrDefault(s => s.Id == id);

                if (currentSoldier != null)
                {
                    list.Add((Private)currentSoldier);
                }
            }

            return list;
        }
    }
}
