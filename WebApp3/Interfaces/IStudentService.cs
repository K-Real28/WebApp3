using WebApp3.Domains;

namespace WebApp3.Interfaces
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudents();
        Task<Student?> GetById(int id);
        Task Create(Student student);
        Task Edit(Student student);
        Task Delete(Student student);
    }
}
