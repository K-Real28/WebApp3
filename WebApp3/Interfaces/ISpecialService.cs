using WebApp3.Domains;

namespace WebApp3.Interfaces
{
    public interface ISpecialService
    {
        Task<List<Special>> GetSpecials();
        Task<Special?> GetById(int id);
        Task Create(Special special);
        Task Edit(Special special);
        Task Delete(Special special);
    }
}
