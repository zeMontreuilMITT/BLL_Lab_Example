using Lab3MVC.Models;

namespace Lab3MVC.Data
{
    public class ParkingSpotRepo : IRepository<ParkingSpot>
    {

        private readonly ParkingContext _context;
        public ParkingSpotRepo(ParkingContext context)
        {
            _context = context;
        }
        public void Create(ParkingSpot entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ParkingSpot entity)
        {
            throw new NotImplementedException();
        }

        public ParkingSpot Get(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<ParkingSpot> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ParkingSpot entity)
        {
            throw new NotImplementedException();
        }
    }
}
