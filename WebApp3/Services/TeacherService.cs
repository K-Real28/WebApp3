using Microsoft.EntityFrameworkCore;
using WebApp3.Domains;
using WebApp3.Interfaces;

namespace WebApp3.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly AppDbContext _context;

        public TeacherService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Teacher>> GetTeachers()
        {
            return (await _context.Teachers.ToListAsync());
        }
        public async Task<Teacher?> GetById(int id)
        {
            return await _context.Teachers
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task Create(Teacher teacher)
        {
            _context.Add(teacher);
            await _context.SaveChangesAsync();
        }
        public async Task Edit (Teacher teacher)
        {
            _context.Update(teacher);
            await _context.SaveChangesAsync();
        }
        public async Task Delete (Teacher teacher)
        {
            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
        }
    }
}
