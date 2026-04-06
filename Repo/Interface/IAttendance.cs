using New_Project_Atten.Models;

namespace New_Project_Atten.Repo.Interface
{
    public interface IAttendance
    {
        List<Attendance> GetAll();
        Attendance GetByID(int id);
        void Delete(int id);
        void Update(Attendance Att);
        void add(Attendance Att);
    }
}
