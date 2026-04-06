using New_Project_Atten.Migrations;
using New_Project_Atten.Models;
using New_Project_Atten.Repo.Interface;

namespace New_Project_Atten.Repo.Implementation
{
    public class AttendanceRepo:IAttendance
    {
        public readonly Context Con;
        public AttendanceRepo()
        {
            this.Con = new Context();
        }
        public List<Attendance> GetAll()
        {
            return Con.Attendances.ToList();
        }

        public Attendance GetByID(int id)
        {
            return Con.Attendances.Find(id);
        }

        public void Delete(int id)
        {
            var RemId = Con.Attendances.Find(id);
            if (RemId != null)
            {
                Con.Attendances.Remove(RemId);
                Con.SaveChanges();
            }
        }

        public void Update(Attendance Sub)
        {
            Con.Attendances.Update(Sub);
            Con.SaveChanges();
        }

        public void add(Attendance Sub)
        {
            Con.Attendances.Add(Sub);
            Con.SaveChanges();
        }

    }
}
