using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp3.Domains;
using WebApp3.Interfaces;

namespace WebApp3.Services
{
    public class CourseService : ICourseService
    {
        private readonly AppDbContext _context;

        public CourseService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Course>> GetCourses()
        {
            return (await _context.Courses.ToListAsync());
        }
        public async Task<Course?> GetById(int id)
        {
            return await _context.Courses
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task Create(Course course)
        {
            _context.Add(course);
            await _context.SaveChangesAsync();
        }
        public async Task Edit(Course course)
        {
            _context.Update(course);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(Course course)
        {
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
        }
    }
}
