using WebApp3.Domains.BaseModels;

namespace WebApp3.Domains
{
    public class Student : NameBaseEnity
    {
        public int phone { get; set; }
        public string photo { get; set; }

        public Group? Group { get; set; }
    }
}
