namespace _08.PetClinic.Models.Clinics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Contracts;
    using Pets.Contracts;

    public class Clinic : IClinic
    {
        private readonly IPet[] rooms;
        private int roomNumber;

        public Clinic(string name, int roomNumber)
        {
            this.Name = name;
            this.RoomNumber = roomNumber;
            this.rooms = new IPet[this.RoomNumber];
        }

        public string Name { get; private set; }

        public int RoomNumber
        {
            get
            {
                return this.roomNumber;
            }
            private set
            {
                if (value % 2 == 0)
                {
                    throw new InvalidOperationException("Invalid Operation!");
                }

                this.roomNumber = value;
            }
        }

        public IReadOnlyCollection<IPet> Rooms => Array.AsReadOnly(this.rooms);

        public bool HasEmptyRooms => this.rooms.Any(p => p == null);

        public bool IsEmpty => this.Rooms.All(p => p == null);

        public bool Add(IPet pet)
        {
            if (!HasEmptyRooms)
            {
                return false;
            }

            this.AddPetToRoom(pet);

            return true;
        }

        public string Print(int room)
        {
            if (room < 0 || room >= this.rooms.Count())
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            var currentRoom = this.rooms[room];

            if (currentRoom == null)
            {
                return "Room empty";
            }

            return this.rooms[room].ToString();
        }

        public bool Release()
        {
            if (this.IsEmpty)
            {
                return false;
            }

            RealeaseRoom();

            return true;
        }

        private void RealeaseRoom()
        {
            var length = this.rooms.Length;
            var startIndex =  length / 2;

            for (int i = startIndex; i < length; i++)
            {
                if (this.rooms[i] != null)
                {
                    this.rooms[i] = null;
                    return;
                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                if (this.rooms[i] != null)
                {
                    this.rooms[i] = null;
                    return;
                }
            }
        }

        private void AddPetToRoom(IPet pet)
        {
            var currentIndex = this.rooms.Length / 2;


            if (TryToAddPetInRoom(currentIndex, pet))
            {
                return;
            }

            var leftIndex = currentIndex - 1;
            var rightIndex = currentIndex + 1;
            var lenght = this.Rooms.Count;

            while (rightIndex < lenght)
            {
                if (TryToAddPetInRoom(leftIndex, pet))
                {
                    break;
                }

                leftIndex--;

                if (TryToAddPetInRoom(rightIndex, pet))
                {
                    break;
                }

                rightIndex++;
            }
        }

        private bool TryToAddPetInRoom(int index, IPet pet)
        {
            if (this.rooms[index] == null)
            {
                this.rooms[index] = pet;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var room in this.Rooms)
            {
                sb.AppendLine(room == null ? "Room empty": room.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
