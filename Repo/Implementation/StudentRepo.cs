using New_Project_Atten.Models;
using New_Project_Atten.Repo.Interface;

namespace New_Project_Atten.Repo.Implementation
{
    public class StudentRepo : IStudent
    {
        public readonly Context Con;
        public StudentRepo()
        {
            Con = new Context();
        }

        public List<Student> GetAll()
        {
            return Con.Students.ToList();
        }

     
        public Student GetByID(int id)
        {
            return Con.Students.Find(id);
        }

        public void Delete(int id)
        {
            var RemId = Con.Students.Find(id);
            if (RemId != null)
            {
                Con.Students.Remove(RemId);
                Con.SaveChanges();
            }
        }

        public void Update(Student student)
        {
            Con.Students.Update(student);
            Con.SaveChanges();
        }

        public void add(Student student)
        {
            Con.Students.Add(student);
            Con.SaveChanges();
        }

    }
}