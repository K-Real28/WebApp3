using WebApp3.Domains;

namespace WebApp3.Interfaces
{
    public interface ITeacherService
    {
        Task<List<Teacher>> GetTeachers();
        Task<Teacher?> GetById(int id);
        Task Create(Teacher teacher);
        Task Edit(Teacher teacher);
        Task Delete(Teacher teacher);
    }
}
