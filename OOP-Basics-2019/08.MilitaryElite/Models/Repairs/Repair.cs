namespace _08.MilitaryElite.Models.Repairs
{
    public class Repair
    {
        public Repair(string part, int hours)
        {
            this.Part = part;
            this.Hours = hours;
        }

        public string Part { get; private set; }

        public int Hours { get; private set; }

        public override string ToString()
        {
            return $"Part Name: {this.Part} Hours Worked: {this.Hours}";
        }
    }
}
