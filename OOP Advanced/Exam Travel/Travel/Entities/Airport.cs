﻿namespace Travel.Entities
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using Contracts;

    public class Airport : IAirport
    {
        private readonly List<IBag> confiscatedBags;
        private readonly List<IBag> checkedInBags;
        private readonly List<ITrip> trips;
        private readonly List<IPassenger> passengers;

        public Airport()
        {
            this.confiscatedBags = new List<IBag>();
            this.checkedInBags = new List<IBag>();
            this.trips = new List<ITrip>();
            this.passengers = new List<IPassenger>();
        }

        public IReadOnlyCollection<IBag> CheckedInBags => this.checkedInBags.AsReadOnly();

        public IReadOnlyCollection<IBag> ConfiscatedBags => this.confiscatedBags.AsReadOnly();

        public IReadOnlyCollection<IPassenger> Passengers => this.passengers.AsReadOnly();

        public IReadOnlyCollection<ITrip> Trips => this.trips.AsReadOnly();

        public IPassenger GetPassenger(string username)
        {
            var passenger = this.Passengers.FirstOrDefault(p => p.Username == username);
            return passenger;
        }

        public ITrip GetTrip(string id)
        {
            var trip = this.Trips.FirstOrDefault(t => t.Id == id);
            return trip;
        }

        public void AddPassenger(IPassenger passenger)
        {
            var currentPassanger = this.GetPassenger(passenger.Username);

            if (currentPassanger != null)
            {
                throw new InvalidOperationException($"Passenger {passenger.Username} already registered!");
            }

            this.passengers.Add(passenger);
        }

        public void AddTrip(ITrip trip)
        {
            this.trips.Add(trip);
        }

        public void AddCheckedBag(IBag bag)
        {
            this.checkedInBags.Add(bag);
        }

        public void AddConfiscatedBag(IBag bag)
        {
            this.confiscatedBags.Add(bag);
        }
	}
}