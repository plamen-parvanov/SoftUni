namespace _05.BorderControl.Models
{
    using Contracts;

    public class Rebel : IBuyer
    {
        private static int FOOD_INCREASE = 5;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = 0;
        }

        public int Food { get; private set; }

        public int Age { get; private set; }

        public string Group { get; private set; }

        public string Name { get; private set; }

        public void BuyFood()
        {
            this.Food += FOOD_INCREASE;
        }
    }
}
