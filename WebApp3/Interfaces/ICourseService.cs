using WebApp3.Domains;

namespace WebApp3.Interfaces
{
    public interface ICourseService
    {
        Task<List<Course>> GetCourses();
        Task<Course?> GetById(int id);
        Task Create(Course course);
        Task Edit(Course course);
        Task Delete(Course course);
    }
}
