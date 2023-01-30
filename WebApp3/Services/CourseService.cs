using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp3.Domains;

namespace WebApp3.Services
{
    public class CourseService // : ICourseService
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


    }
}
