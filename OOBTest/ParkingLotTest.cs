using OOB;
using Xunit;

namespace OOBTest
{
    public class ParkingLotTest
    {
        [Fact]
        public void should_park_car_and_get_ticket_when_parkinglot_is_not_full()
        {
            ParkingLot parkingLot = new ParkingLot();
            parkingLot.IsFull = false;
            Car car = new Car();

            var ticket = parkingLot.Park(car);
            
            Assert.Equal(typeof(Ticket), ticket.GetType());
        }
        
//        [Fact]
//        public void should_pick_car_when_can_find_car_by_ticket()
//        {
//            ParkingLot parkingLot = new ParkingLot();
//            parkingLot.IsFull = false;
//            Car car = new Car();
//            var ticket = parkingLot.Park(car);
//
//            Assert.Same(car, parkingLot.Pick(ticket));
//        }
        
        [Fact]
        public void should_pick_the_right_car_with_a_specific_ticket()
        {
            ParkingLot parkingLot = new ParkingLot();
            parkingLot.IsFull = false;
            Car carA = new Car();
            Car carB = new Car();
            var ticketA = parkingLot.Park(carA);
            var ticketB = parkingLot.Park(carB);

            Assert.Same(carA, parkingLot.Pick(ticketA));
            Assert.Same(carB, parkingLot.Pick(ticketB));
        }
        
        [Fact]
        public void should_not_pick_car_when_can_not_find_car_by_ticket()
        {
            ParkingLot parkingLot = new ParkingLot();
            parkingLot.IsFull = false;
            Car carA = new Car();
            var ticketA = parkingLot.Park(carA);
            var ticketC = new Ticket();

            Assert.Null(parkingLot.Pick(ticketC));
        }
        
        [Fact]
        public void should_not_pick_car_without_ticket()
        {
            ParkingLot parkingLot = new ParkingLot();
            parkingLot.IsFull = false;
            Car car = new Car();
            var realTicket = parkingLot.Park(car);
            Ticket ticket = null;

            Assert.Null(parkingLot.Pick(ticket));
        }
        
        [Fact]
        public void should_not_park_car_if_parkinglot_is_full()
        {
            ParkingLot parkingLot = new ParkingLot();
            parkingLot.IsFull = true;
            Car carA = new Car();
            var ticket = parkingLot.Park(carA);

            Assert.Null(parkingLot.Pick(ticket));
        }
    }
}