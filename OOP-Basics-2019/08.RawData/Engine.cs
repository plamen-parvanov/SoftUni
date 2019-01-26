namespace DefiningClasses
{
    public class Engine
    {
        public int EngineSpeed { get; private set; }
        public int EnginePower { get; private set; }

        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }
    }
}
