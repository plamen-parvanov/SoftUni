namespace _08.PetClinic.Models.Clinics.Contracts
{
    using System.Collections.Generic;

    using Pets.Contracts;

    public interface IClinic
    {
        string Name { get; }

        int RoomNumber { get; }

        IReadOnlyCollection<IPet> Rooms { get; }

        bool HasEmptyRooms { get; }

        bool IsEmpty { get; }

        bool Add(IPet pet);

        bool Release();

        string Print(int room);
    }
}
