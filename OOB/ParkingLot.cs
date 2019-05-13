using System;
using System.Collections.Generic;

namespace OOB
{
    public class ParkingLot
    {
        public bool IsFull
        {
            get => (capacity - cars.Count) <= 0;
        }

        private int capacity; 

        private Dictionary<Ticket, Car> cars;

        public ParkingLot(int capacity)
        {
            if(capacity < 0) return;
            this.capacity = capacity;
            cars = new Dictionary<Ticket, Car>();
        }
        
        public Ticket Park(Car car)
        {
            if (IsFull) return null;
            var ticket = new Ticket();
            cars.Add(ticket, car);
            
            return ticket;
        }

        public Car Pick(Ticket ticket)
        {
            Car car;
            if (ticket == null) return null;
            cars.TryGetValue(ticket, out car);
            cars.Remove(ticket);
            
            return car;
        }
    }
}