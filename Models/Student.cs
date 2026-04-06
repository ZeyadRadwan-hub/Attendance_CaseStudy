namespace New_Project_Atten.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Attendance> Student_Attendances { get; set; }
    }
}
