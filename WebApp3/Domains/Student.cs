namespace WebApp3.Domains
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int phone { get; set; }
        public string photo { get; set; }

        public Group? Group { get; set; }
    }
}
