namespace _07.InfernoInfinity.Data.Contracts
{
    using Models.Wepons.Contracts;

    public interface IRepository
    {
        void Add(IWeapon weapon);

        string PrintWeapon(string weaponName);
    }
}
