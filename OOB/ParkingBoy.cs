using System.Collections.Generic;

namespace OOB
{
    public class ParkingBoy
    {
        private List<ParkingLot> parkingLots;
        
        public ParkingBoy(List<ParkingLot> parkingLots)
        {
            this.parkingLots = parkingLots;
        }

        public Ticket Park(Car car)
        {
            if (car == null) return null;
            for (int i = 0; i < parkingLots.Count; i++)
            {
                if (!parkingLots[i].IsFull)
                {
                    return parkingLots[i].Park(car);
                }
            }

            return null;
        }

        public Car Pick(Ticket ticket)
        {
            if (ticket == null) return null;
            for (int i = 0; i < parkingLots.Count; i++)
            {
                if(parkingLots[i] != null)
                {
                    return parkingLots[i].Pick(ticket);
                }
            }

            return null;
        }
    }
}