namespace DefiningClasses.Units
{
    using System.Text;

    public class Engine
    {
        private string power;
        private string displacement = "n/a";
        private string efficiency = "n/a";

        public Engine(string model, string power)
        {
            this.Model = model;
            this.power = power;
        }

        public Engine(string model, string power, string displacement, string efficiency)
            : this(model, power)
        {
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public Engine(string model, string power, string argument) 
            :this(model, power)
        {
            if (char.IsDigit(argument[0]))
            {
                this.displacement = argument;
            }
            else
            {
                this.efficiency = argument;
            }
        }

        public string Model { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"  {this.Model}:");
            sb.AppendLine($"    Power: {this.power}");
            sb.AppendLine($"    Displacement: {this.displacement}");
            sb.AppendLine($"    Efficiency: {this.efficiency}");

            return sb.ToString().TrimEnd();
        }
    }
}
