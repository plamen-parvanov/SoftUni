namespace Travel.Entities.Airplanes
{
	using System;
	using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Entities.Contracts;

    public abstract class Airplane : IAirplane
    {
		private readonly List<IBag> baggageCompartment;
        private readonly List<IPassenger> passengers;

		protected Airplane(int seats, int bags)
        {
			this.passengers = new List<IPassenger>();
			this.Seats = seats;
			this.BaggageCompartments = bags;
            this.baggageCompartment = new List<IBag>();
		}

		public int Seats { get; }

		public int BaggageCompartments { get; }

		public IReadOnlyCollection<IBag> BaggageCompartment => this.baggageCompartment;

		public IReadOnlyCollection<IPassenger> Passengers => this.passengers;

		public bool IsOverbooked => this.Passengers.Count() > this.Seats;

        public void AddPassenger(IPassenger passenger)
        {
			this.passengers.Add(passenger);
		}

		public IPassenger RemovePassenger(int seatIndex)
        {
            var passenger = this.passengers[seatIndex];

            this.passengers.RemoveAt(seatIndex);

			return passenger;
		}

		public IEnumerable<IBag> EjectPassengerBags(IPassenger passenger)
        {
			var passengerBags = this.BaggageCompartment
				.Where(b => b.Owner == passenger)
				.ToArray();

            foreach (var bag in passengerBags)
            {
                this.baggageCompartment.Remove(bag);
            }

			return passengerBags;
		}

		public void LoadBag(IBag bag)
        {
            //TODO check this statement!!! maybe coutn + 1 (current bag)
			var isBaggageCompartmentFull = this.BaggageCompartment.Count > this.BaggageCompartments;

            if (isBaggageCompartmentFull)
            {
                throw new InvalidOperationException($"No more bag room in {this.GetType().ToString()}!");
            }

			this.baggageCompartment.Add(bag);
		}
	}
}