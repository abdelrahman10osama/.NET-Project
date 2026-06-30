namespace WebApplication2.Models.Repository
{
    public interface ICourseRepo:IRepo<course>
    {

        public void Add(course entity);
        
    }
}
        