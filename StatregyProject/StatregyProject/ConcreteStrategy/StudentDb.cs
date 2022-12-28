using StatregyProject.Interface;
using StatregyProject.Model;

namespace StatregyProject.ConcreteStrategy
{
    public class StudentDb : IStudent
    {
        public StudentDb()
        {

        }
        public ICollection<Student> GetAllStudents()
        {
            ICollection<Student> students = new List<Student>() { new Student() { FirstName = "Neymar", LastName = "Junior", Active = true }, new Student() { FirstName = "Luka", LastName = "Modric", Active = true } };
            return students;
        }
    }
}
