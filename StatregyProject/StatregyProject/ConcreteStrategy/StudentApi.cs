using StatregyProject.Interface;
using StatregyProject.Model;

namespace StatregyProject.ConcreteStrategy
{
    public class StudentApi : IStudent
    {
        public StudentApi()
        {

        }
        public ICollection<Student> GetAllStudents()
        {
            ICollection<Student> students = new List<Student>() { new Student() { FirstName = "Lionel", LastName = "Messi", Active = true }, new Student() { FirstName = "Cristiano", LastName = "Ronaldo", Active = true }, new Student() { FirstName = "Kylian", LastName = "Mbappe", Active = false } };
            return students;
        }
    }
}
