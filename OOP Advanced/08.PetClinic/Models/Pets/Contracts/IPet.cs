namespace _08.PetClinic.Models.Pets.Contracts
{
    public interface IPet
    {
        string Name { get; }

        int Age { get; }

        string Kind { get; }
    }
}
