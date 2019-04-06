namespace _06.TrafficLights.Models.Contracts
{
    public interface ITrafficLight
    {
        Signal[] Signals { get; }

        void ChangeSignal();

        string Print();
    }
}
