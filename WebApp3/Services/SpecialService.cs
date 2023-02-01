using Microsoft.EntityFrameworkCore;
using WebApp3.Domains;
using WebApp3.Interfaces;

namespace WebApp3.Services
{
    public class SpecialService : ISpecialService
    {
        private readonly AppDbContext _context;

        public SpecialService (AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Special>> GetSpecials()
        {
            return await _context.Specials.ToListAsync();
        }
        public async Task<Special?> GetById(int id)
        {
            return await _context.Specials
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task Create(Special special)
        {
            _context.Add(special);
            await _context.SaveChangesAsync();
        }
        public async Task Edit (Special special)
        {
            _context.Update(special);
            await _context.SaveChangesAsync();
        }
        public async Task Delete (Special special)
        {
            _context.Specials.Remove(special);
            await _context.SaveChangesAsync();
        }
    }
}
