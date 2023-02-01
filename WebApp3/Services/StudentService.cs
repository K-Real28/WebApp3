using Microsoft.EntityFrameworkCore;
using WebApp3.Controllers;
using WebApp3.Domains;
using WebApp3.Interfaces;

namespace WebApp3.Services
{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext _context;

        public StudentService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Student>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }
        public async Task<Student?> GetById(int id)
        {
            return await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task Create(Student student)
        {
            _context.Add(student);
            await _context.SaveChangesAsync();
        }
        public async Task Edit(Student student)
        {
            _context.Update(student);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(Student student)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }
    }
}
