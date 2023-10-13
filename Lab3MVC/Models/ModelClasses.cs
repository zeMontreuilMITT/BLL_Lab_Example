using System.Collections.Generic;

namespace Lab3MVC.Models
{
    public class Vehicle

    {

        public int ID { get; set; }

        public int PassID { get; set; }

        public virtual Pass Pass { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }

        public bool Parked { get; set; }

    }

    public class Pass

    {

        public int ID { get; set; }

        public string Purchaser { get; set; }

        public bool Premium { get; set; }

        public int Capacity { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }

    }

    public class ParkingSpot

    {

        public int ID { get; set; }

        public bool Occupied { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }

    }

    public class Reservation

    {

        public int ID { get; set; }

        public int ParkingSpotID { get; set; }

        public virtual ParkingSpot ParkingSpot { get; set; }

        public int VehicleID { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public DateTime Expiry { get; set; }

        public bool IsCurrent { get; set; }

    }

    
    /*
    public class ParkingHelper

    {

        private ParkingContext parkingContext;

        public ParkingHelper(ParkingContext context)

        {

            this.parkingContext = context;

        }

        public Pass CreatePass(string purchaser, bool premium, int capacity)

        {

            Pass newPass = new Pass();

            newPass.Purchaser = purchaser;

            newPass.Premium = premium;

            newPass.Capacity = capacity;

            parkingContext.Passes.Add(newPass);

            parkingContext.SaveChanges();

            return newPass;

        }

        public ParkingSpot CreateParkingSpot()

        {

            ParkingSpot newSpot = new ParkingSpot();

            newSpot.Occupied = false;

            parkingContext.ParkingSpots.Add(newSpot);

            return newSpot;

        }

    }
    */
}
