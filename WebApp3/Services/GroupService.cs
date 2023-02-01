using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;


namespace WebApp3.Services
{
    public class GroupService // : IGroupService
    {
        private readonly AppDbContext _context;

        public GroupService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Group?>> GetGroups()
        {
            var appDbContext = _context.Groups.Include(i => i.Course).Include(i => i.Curator).Include(i => i.Special);
            return null;
                //View(await appDbContext.ToListAsync());
        }
        public async Task<Group?> GetById(int id)
        {
            return await _context.Groups
                .Include(i => i.Course)
                .Include(i => i.Curator)
                .Include(i => i.Special)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task Create(Group group)
        {
            _context.Add(group);
            await _context.SaveChangesAsync();
        }
    }
}
