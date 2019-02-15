namespace _05.BorderControl.Models
{
    using Contracts;

    public class Citizen : IId, IBirthdate, IBuyer
    {
        private static int FOOD_INCREASE = 10;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
            this.Food = 0;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += FOOD_INCREASE;
        }
    }
}
