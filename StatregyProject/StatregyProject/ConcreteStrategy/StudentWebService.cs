using StatregyProject.Interface;
using StatregyProject.Model;

namespace StatregyProject.ConcreteStrategy
{
    public class StudentWebService : IStudent
    {
        public StudentWebService()
        {

        }
        public ICollection<Student> GetAllStudents()
        {
            return null;
        }

    }
}
