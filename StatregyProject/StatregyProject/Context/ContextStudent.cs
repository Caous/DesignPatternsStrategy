using StatregyProject.Interface;
using StatregyProject.Model;

namespace StatregyProject.Context
{
    public class ContextStudent
    {
        IStudent student;
        public ContextStudent()
        {

        }

        public void SetStrategy(IStudent _student)
        {
            this.student = _student;
        }

        public ICollection<Student> ExecuteStrategy()
        {
            return student.GetAllStudents();
        }
    }
}
