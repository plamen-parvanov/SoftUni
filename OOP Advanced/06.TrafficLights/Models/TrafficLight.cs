namespace _06.TrafficLights.Models
{
    using Contracts;

    public class TrafficLight : ITrafficLight
    {
        public TrafficLight(Signal[] signals)
        {
            this.Signals = signals;
        }

        public Signal[] Signals { get; private set; }

        public void ChangeSignal()
        {
            for (int i = 0; i < this.Signals.Length; i++)
            {
                this.Signals[i] = CallNext(this.Signals[i]);
            }
        }

        public string Print()
        {
            return string.Join(" ", this.Signals);
        }

        private Signal CallNext(Signal signal)
        {
            if (signal == Signal.Yellow)
            {
                return signal = Signal.Red;
            }

            return ++signal;

        }
    }
}
