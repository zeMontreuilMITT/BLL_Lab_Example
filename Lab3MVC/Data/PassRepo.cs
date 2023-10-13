using Lab3MVC.Models;

namespace Lab3MVC.Data
{
    public class PassRepo : IRepository<Pass>
    {
        private readonly ParkingContext _context;
        public PassRepo(ParkingContext context)
        {
            _context = context;
        }
        public void Create(Pass entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Pass entity)
        {
            throw new NotImplementedException();
        }

        public Pass Get(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Pass> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Pass entity)
        {
            throw new NotImplementedException();
        }
    }
}
