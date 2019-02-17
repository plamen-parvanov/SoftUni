namespace _03.WildFarm.Models.Foods
{
    public abstract class Food
    {
        public Food(string name,int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }

        public string Name { get; private set; }

        public int Quantity { get; private set; }
    }
}
