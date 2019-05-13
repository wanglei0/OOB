using System.Collections.Generic;
using OOB;
using Xunit;

namespace OOBTest
{
    public class ParkingBoyTest
    {
        [Fact]
        public void should_park_car_and_get_ticket_when_parkinglots_is_not_full()
        {
            List<ParkingLot> parkingLots = new List<ParkingLot>(){new ParkingLot(1)};
            ParkingBoy parkingBoy = new ParkingBoy(parkingLots);
            Car car = new Car();
            var ticket = parkingBoy.Park(car);
            
            Assert.Equal(typeof(Ticket), ticket.GetType());
        }
        
        [Fact]
        public void should_pick_the_same_car_with_the_ticket_generated_by_parkingboy()
        {
            List<ParkingLot> parkingLots = new List<ParkingLot>(){new ParkingLot(1)};
            ParkingBoy parkingBoy = new ParkingBoy(parkingLots);
            Car car = new Car();
            var ticket = parkingBoy.Park(car);
            
            Assert.Same(car, parkingBoy.Pick(ticket));
        }
        
        [Fact]
        public void should_pick_the_same_car_using_the_ticket_generated_by_parkinglot()
        {
            ParkingLot parkingLot = new ParkingLot(1);
            List<ParkingLot> parkingLots = new List<ParkingLot>(){parkingLot};
            ParkingBoy parkingBoy = new ParkingBoy(parkingLots);
            Car car = new Car();
            var ticket = parkingLot.Park(car);
            
            Assert.Same(car, parkingBoy.Pick(ticket));
        }
        
        [Fact]
        public void should_park_car_when_one_parkinglot_is_full_and_the_other_one_is_not()
        {
            ParkingLot lotA = new ParkingLot(0);
            ParkingLot lotB = new ParkingLot(1);
            List<ParkingLot> parkingLots = new List<ParkingLot>(){lotA, lotB};
            ParkingBoy parkingBoy = new ParkingBoy(parkingLots);
            Car car = new Car();
            var ticket = parkingBoy.Park(car);
            
            Assert.Equal(typeof(Ticket), ticket.GetType());
        }
        
        [Fact]
        public void should_park_car_to_the_first_parkinglot_when_both_parkinglots_are_not_full()
        {
            ParkingLot lotA = new ParkingLot(1);
            ParkingLot lotB = new ParkingLot(1);
            List<ParkingLot> parkingLots = new List<ParkingLot>(){lotA, lotB};
            ParkingBoy parkingBoy = new ParkingBoy(parkingLots);
            Car car = new Car();
            var ticket = parkingBoy.Park(car);
            
            Assert.Same(car, lotA.Pick(ticket));
            Assert.Null(lotB.Pick(ticket));
        }
        
        [Fact]
        public void should_not_pick_car_when_ticket_doesnt_match()
        {
            ParkingLot lot = new ParkingLot(0);
            List<ParkingLot> parkingLots = new List<ParkingLot>(){lot};
            ParkingBoy parkingBoy = new ParkingBoy(parkingLots);
            Car car = new Car();
            parkingBoy.Park(car);
            var ticket = new Ticket();
            
            Assert.Null(parkingBoy.Pick(ticket));
        }
        
        [Fact]
        public void should_not_park_car_when_parkinglots_are_full()
        {
            ParkingLot lotA = new ParkingLot(0);
            ParkingLot lotB = new ParkingLot(0);
            List<ParkingLot> parkingLots = new List<ParkingLot>(){lotA, lotB};
            ParkingBoy parkingBoy = new ParkingBoy(parkingLots);
            Car car = new Car();
            var ticket = parkingBoy.Park(car);
            
            Assert.Null(ticket);
        }
        
        [Fact]
        public void should_not_park_car_when_can_not_find_car_by_ticket()
        {
            ParkingLot lot = new ParkingLot(1);
            List<ParkingLot> parkingLots = new List<ParkingLot>(){lot};
            ParkingBoy parkingBoy = new ParkingBoy(parkingLots);
            var ticket = parkingBoy.Park(null);
            
            Assert.Null(ticket);
        }
        
//        [Fact]
//        public void should_not_park_car_when_car_is_null()
//        {
//            ParkingLot lot = new ParkingLot(1);
//            List<ParkingLot> parkingLots = new List<ParkingLot>(){lot};
//            ParkingBoy parkingBoy = new ParkingBoy(parkingLots);
//            var ticket = parkingBoy.Park(null);
//            
//            Assert.Null(ticket);
//        }
        
        [Fact]
        public void should_pick_corresponding_car_with_specific_ticket()
        {
            List<ParkingLot> parkingLots = new List<ParkingLot>(){new ParkingLot(2)};
            ParkingBoy parkingBoy = new ParkingBoy(parkingLots);
            Car carA = new Car();
            Car carB = new Car();
            var ticketA = parkingBoy.Park(carA);
            var ticketB = parkingBoy.Park(carB);
            
            Assert.Same(carA, parkingBoy.Pick(ticketA));
            Assert.Same(carB, parkingBoy.Pick(ticketB));
        }
    }
}