namespace WebApp3.Domains
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Group? Group { get; set; }
    }
}
