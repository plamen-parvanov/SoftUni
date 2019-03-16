namespace _08.PetClinic.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models.Clinics;
    using Models.Clinics.Contracts;
    using Models.Pets;
    using Models.Pets.Contracts;

    public class CommandInterpreter
    {
        private readonly IList<IPet> pets;
        private readonly IList<IClinic> clinics;

        public CommandInterpreter()
        {
            this.pets = new List<IPet>();
            this.clinics = new List<IClinic>();
        }

        public void CreatePet(string name, int age, string kind)
        {
            var currentPet = new Pet(name, age, kind);

            this.pets.Add(currentPet);
        }

        public void CreateClinic(string name, int rooms)
        {
            var currentClinic = new Clinic(name, rooms);

            this.clinics.Add(currentClinic);
        }

        public bool Add(string petName, string clinicName)
        {
            var currentPet = GetPet(petName);

            var currentClinic = GetClinic(clinicName);

            return currentClinic.Add(currentPet);
        }

        public bool Release(string clinicName)
        {
            var currentClinic = GetClinic(clinicName);

            return currentClinic.Release();
        }

        public bool HasEmptyRooms(string clinicName)
        {
            var currentClinic = GetClinic(clinicName);

            return currentClinic.HasEmptyRooms;
        }

        public void Print(string clinicName)
        {
            var currentClinic = GetClinic(clinicName);

            Console.WriteLine(currentClinic);
        }

        public void Print(string clinicName, int room)
        {
            var currentClinic = GetClinic(clinicName);

            var result = currentClinic.Print(room - 1);

            Console.WriteLine(result);
        }

        private IPet GetPet(string petName)
        {
            var result = this.pets.FirstOrDefault(p => p.Name == petName);

            if (result == null)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            return result;
        }

        private IClinic GetClinic(string clinicName)
        {
            var result = this.clinics.FirstOrDefault(c => c.Name == clinicName);

            if (result == null)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            return result;
        }
    }
}
