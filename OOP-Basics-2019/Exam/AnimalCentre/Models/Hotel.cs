namespace AnimalCentre.Models
{
    using System.Collections.Generic;
    using Validators;
    using Contracts;
    using Animals;

    public class Hotel : IHotel
    {
        private int capacity;
        private Dictionary<string, IAnimal> animals;

        private const int CAPACITY = 10;

        public Hotel()
        {
            this.animals = new Dictionary<string, IAnimal>();
            this.capacity = CAPACITY;
        }

        public IReadOnlyDictionary<string, IAnimal> Animals => this.animals;

        public void Accommodate(IAnimal animal)
        {
            Validator.IsThereEnoughCapacity(this.capacity, this.Animals.Count);

            Validator.DoesAnimalAlreadyExist(this.animals, animal.Name);

            this.animals[animal.Name] = animal;
        }

        public void Adopt(string animalName, string owner)
        {
            var animal = GetAnimal(animalName);

            animal.IsAdopt = true;
            animal.Owner = owner;

            this.animals.Remove(animalName);
        }

        public Animal GetAnimal(string animalName)
        {
            Validator.AnimalDoesNotExist(this.animals, animalName);

            return Animals[animalName] as Animal;
        }
    }
}
