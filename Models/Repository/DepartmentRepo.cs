namespace WebApplication2.Models.Repository
{
    public class DepartmentRepo:IDepartmentRepo
    {
        company context;

        public DepartmentRepo(company _context)
        {
            context = _context;
        }

        public List<department> GetAll()
        {
            return context.Departments.ToList();
        }

        public department GetById(int id)
        {
            return context.Departments.FirstOrDefault(d => d.ID == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

    }
}
