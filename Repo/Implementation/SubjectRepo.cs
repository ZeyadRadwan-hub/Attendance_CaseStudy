using New_Project_Atten.Models;
using New_Project_Atten.Repo.Interface;

namespace New_Project_Atten.Repo.Implementation
{
    public class SubjectRepo : ISubject
    {
        public readonly Context Con;
        public SubjectRepo() { 
        this.Con = new Context();
        }
        public List<Subject> GetAll()
        {
            return Con.Subjects.ToList();
        }

        public Subject GetByID(int id)
        {
            return Con.Subjects.Find(id);
        }

        public void Delete(int id)
        {
            var RemId = Con.Subjects.Find(id);
            if (RemId != null)
            {
                Con.Subjects.Remove(RemId);
                Con.SaveChanges();
            }
        }

        public void Update(Subject Sub)
        {
            Con.Subjects.Update(Sub);
            Con.SaveChanges();
        }

        public void add(Subject Sub)
        {
            Con.Subjects.Add(Sub);
            Con.SaveChanges();
        }

    }
}