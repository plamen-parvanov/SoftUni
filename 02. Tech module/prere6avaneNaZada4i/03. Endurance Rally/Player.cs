namespace _03.Endurance_Rally
{
    using System.Linq;

    public class Player
    {
        public Player(string playerName)
        {
            this.name = playerName;
            this.fuel = (int)playerName.First();                    
        }

        private string name;
        private double fuel;
        private int trackReached;
        

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Fuel
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }

        public int TrackReached
        {
            get { return this.trackReached; }
            set { this.trackReached = value; }
        }

    }
}
