using System;
using System.Collections.Generic;

namespace OOB
{
    public class ParkingLot
    {
        public bool IsFull { get; set; }

        private int parkingSpaceNumber; 

        private Dictionary<Ticket, Car> cars;

        public ParkingLot()
        {
            parkingSpaceNumber = 10;
            IsFull = false;
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