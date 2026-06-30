namespace WebApplication2.Models.Repository
{
    public class CourseRepo:ICourseRepo
    {
        company context;

        public CourseRepo(company _context)
        {
            context = _context;
        }
        public void Add(course entity)
        {
            context.Courses.Add(entity);
        }

        public List<course> GetAll()
        {
            return context.Courses.ToList();
        }

        public course GetById(int id)
        {
            course crs = context.Courses.FirstOrDefault(e => e.Id == id);
            return crs;
        }

        public void Save()
        {
            context.SaveChanges();
        }


    }
}
