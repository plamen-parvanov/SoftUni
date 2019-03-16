namespace AnimalCentre.Core
{
    using Models.Animals.Factory;
    using Models;
    using Models.Contracts;
    using System;
    using System.Collections.Generic;
    using Models.Procedures;
    using System.Linq;
    using System.Text;

    public class AnimalCentre
    {
        private static Hotel hotel;
        private static Dictionary<string, Procedure> procedures;
        private static Dictionary<string, List<IAnimal>> adopted;

        public AnimalCentre()
        {
            hotel = new Hotel();
            procedures = new Dictionary<string, Procedure>();
            adopted = new Dictionary<string, List<IAnimal>>();
            InitializeProcedures();
        }

        public string RegisterAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            var animalFactory = new AnimalFactory();

            var animal = animalFactory.CreateAnimal(type, name, energy, happiness, procedureTime);

            hotel.Accommodate(animal);

            return $"Animal {name} registered successfully";
        }

        public string Chip(string name, int procedureTime)
        {
            var animal = hotel.GetAnimal(name);

            procedures["Chip"].DoService(animal, procedureTime);

            return $"{name} had chip procedure";
        }

        public string Vaccinate(string name, int procedureTime)
        {
            var animal = hotel.GetAnimal(name);

            procedures["Vaccinate"].DoService(animal, procedureTime);

            return $"{name} had vaccination procedure";
        }

        public string Fitness(string name, int procedureTime)
        {
            var animal = hotel.GetAnimal(name);

            procedures["Fitness"].DoService(animal, procedureTime);

            return $"{name} had fitness procedure";
        }

        public string Play(string name, int procedureTime)
        {
            var animal = hotel.GetAnimal(name);

            procedures["Play"].DoService(animal, procedureTime);

            return $"{name} was playing for {procedureTime} hours";
        }

        public string DentalCare(string name, int procedureTime)
        {
            var animal = hotel.GetAnimal(name);

            procedures["DentalCare"].DoService(animal, procedureTime);

            return $"{name} had dental care procedure";
        }

        public string NailTrim(string name, int procedureTime)
        {
            var animal = hotel.GetAnimal(name);

            procedures["NailTrim"].DoService(animal, procedureTime);

            return $"{name} had nail trim procedure";
        }

        public string Adopt(string animalName, string owner)
        {
            var animal = hotel.GetAnimal(animalName);

            hotel.Adopt(animalName, owner);

            if (!adopted.ContainsKey(owner))
            {
                adopted[owner] = new List<IAnimal>();
            }

            adopted[owner].Add(animal);

            return String.Format("{0} adopted animal {1} chip",
                                 owner, (animal.IsChipped ? "with" : "without"));
        }

        public string History(string type)
        {
            var sb = new StringBuilder();

            var procedure = procedures[type];

            sb.AppendLine(procedure.History());

            return sb.ToString().TrimEnd();
        }

        public string PrintAdoptedAnimals()
        {
            var sb = new StringBuilder();

            var oredered = adopted.OrderBy(a => a.Key);

            foreach (var owner in oredered)
            {
                sb.AppendLine($"--Owner: {owner.Key}");
                sb.Append($"    - Adopted animals:");
                owner.Value.ForEach(a => sb.Append($" {a.Name}"));
                sb.AppendLine();
            }

            return sb.ToString().TrimEnd();
        }

        private void InitializeProcedures()
        {
            procedures["Chip"] = new Chip();
            procedures["DentalCare"] = new DentalCare();
            procedures["Fitness"] = new Fitness();
            procedures["NailTrim"] = new NailTrim();
            procedures["Play"] = new Play();
            procedures["Vaccinate"] = new Vaccinate();
        }
    }
}
