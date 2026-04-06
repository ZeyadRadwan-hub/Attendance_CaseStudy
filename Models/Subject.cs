namespace New_Project_Atten.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public List<Attendance> Subject_Attendances { get; set; }
    }
}
