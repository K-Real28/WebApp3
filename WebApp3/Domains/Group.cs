using System.ComponentModel.DataAnnotations.Schema;
using WebApp3.Domains.BaseModels;

namespace WebApp3.Domains
{
    public class Group : NameBaseEnity
    {
        public int Year { get; set; }

        [ForeignKey("Curator")]
        public int? CuratorId { get; set; }
        public Teacher? Curator { get; set; }

        public int? SpecialId { get; set; }
        [ForeignKey("SpecialId")]
        public Special? Special { get; set; }

        public int? CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course? Course { get; set; }

        public IList<Student> Students { get; set; } = new List<Student>();
    }
}
