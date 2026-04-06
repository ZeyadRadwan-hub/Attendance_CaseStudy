namespace New_Project_Atten.Models
{
    public class ViewModel
    {
        public int Id { get; set; }
        public List<Student> Students = new List<Student>();
        public int StudentId { get; set; }
        public List<Subject> Subjects = new List<Subject>();
        public int SubjectId { get; set; }
        public string status { get; set; }
        public DateTime Date { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}