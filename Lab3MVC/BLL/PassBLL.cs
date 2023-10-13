using Lab3MVC.Data;
using Lab3MVC.Models;

namespace Lab3MVC.BLL
{
    public class PassBLL
    {
        // INVERSION OF CONTROL
        private readonly IRepository<Vehicle> _vehicleRepo;
        private readonly IRepository<Pass> _passRepo;

        public PassBLL(IRepository<Vehicle> vehicleRepo, IRepository<Pass> passRepo)
        {
            _vehicleRepo = vehicleRepo;
            _passRepo = passRepo;
        }

        public Pass CreatePass(int capacity, string purchaser, bool premium)
        {
            Pass newPass = new Pass { Capacity = capacity, Purchaser = purchaser, Premium = premium };
            _passRepo.Create(newPass);
            return newPass;
        }

        public Vehicle AddVehicleToPass(Vehicle vehicle, Pass pass)
        {
            int VehiclesOnPass = _vehicleRepo.GetAll().Where(v => v.PassID == pass.ID).Count();

            if (VehiclesOnPass < pass.Capacity && vehicle.PassID != pass.ID)
            {
                vehicle.PassID = pass.ID;
                _vehicleRepo.Update(vehicle);
                return vehicle;
            } else
            {
                throw new InvalidOperationException();
            }


        }

    }
}
