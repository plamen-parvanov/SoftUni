namespace _07.InfernoInfinity.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models.Wepons.Contracts;

    public class Repository
    {
        private readonly List<IWeapon> weapons;

        public Repository()
        {
            this.weapons = new List<IWeapon>();
        }

        public void AddWeapon(IWeapon weapon)
        {
            this.weapons.Add(weapon);
        }

        public string PrintWeapon(string weaponName)
        {
            var currentWeapon = this.weapons.FirstOrDefault(w => w.Name == weaponName);

            if (currentWeapon == null)
            {
                throw new ArgumentException("No such weapon in repository!");
            }

            return currentWeapon.ToString();
        }
    }
}
