using WebApp3.Domains.BaseModels;

namespace WebApp3.Domains
{
    public class Special : NameBaseEnity
    {
        public IList<Group> Groups { get; set; } = new List<Group>();
    }
}
