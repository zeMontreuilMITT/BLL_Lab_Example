using Lab3MVC.Models;

namespace Lab3MVC.Data
{
    public class VehicleRepo : IRepository<Reservation>
    {
        private readonly ParkingContext _context;
        public VehicleRepo(ParkingContext context)
        {
            _context = context;
        }
        public void Create(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public Reservation Get(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Reservation> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
