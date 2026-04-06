using New_Project_Atten.Models;

namespace New_Project_Atten.Repo.Interface
{
    public interface IStudent
    {
        List<Student> GetAll();
        Student GetByID(int id);
        void Delete(int id);
        void Update(Student student);
        void add(Student student);

    }
}
