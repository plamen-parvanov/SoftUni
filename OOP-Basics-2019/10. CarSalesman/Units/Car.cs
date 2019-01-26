namespace DefiningClasses.Units
{ 
    using System.Text;

    public class Car
    {
        private string model;
        private Engine engine;
        private string weight = "n/a";
        private string color = "n/a";

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
        }

        public Car(string model, Engine engine, string weight, string color)
            : this(model, engine)
        {
            this.weight = weight;
            this.color = color;
        }

        public Car(string model, Engine engine, string argument)
            : this(model, engine)
        {
            if (char.IsDigit(argument[0]))
            {
                this.weight = argument;
            }
            else
            {
                this.color = argument;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.model}:");
            sb.AppendLine(this.engine.ToString());
            sb.AppendLine($"  Weight: {this.weight}");
            sb.AppendLine($"  Color: {this.color}");

            return sb.ToString().TrimEnd();
        }
    }
}
