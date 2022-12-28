using StatregyProject.Model;

namespace StatregyProject.Interface
{
    public interface IStudent
    {
        ICollection<Student> GetAllStudents();
    }
}
