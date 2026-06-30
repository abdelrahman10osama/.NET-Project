namespace WebApplication2.Models
{
    public interface IRepo<T>
    {
        public List<T> GetAll();
        public T GetById(int id);
        
        public void Save();

    }
}
