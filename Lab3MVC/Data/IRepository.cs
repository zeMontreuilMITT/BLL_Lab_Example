namespace Lab3MVC.Data
{
    public interface IRepository<T> where T : class
    {
        public T Get(int id);
        public ICollection<T> GetAll();
        public void Delete(T entity);
        public void Update(T entity);
        public void Create (T entity);
    }
}
