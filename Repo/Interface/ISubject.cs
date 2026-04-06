using New_Project_Atten.Models;

namespace New_Project_Atten.Repo.Interface
{
    public interface ISubject
    {
        List<Subject> GetAll();
        Subject GetByID(int id);
        void Delete(int id);
        void Update(Subject Sub);
        void add(Subject Sub);
    }
}
