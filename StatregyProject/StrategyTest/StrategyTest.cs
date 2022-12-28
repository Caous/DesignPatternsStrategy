using StatregyProject.Model;
using StatregyProject.ConcreteStrategy;
using StatregyProject.Interface;
using StatregyProject.Context;

namespace StrategyTest
{
    public class StrategyTest
    {
        [Fact(DisplayName = "Method verify object instance is not null")]
        [Trait("Instance Object Concrete", "ConcreteStudentAPI")]
        public void Verify_InstanceConcreteStategyAPI_IsNotNull()
        {
            //Arrange
            StudentApi studentApi = new StudentApi();

            //Assert
            Assert.NotNull(studentApi);
        }

        [Fact(DisplayName = "Method verify object instance is not null")]
        [Trait("Instance Object Concrete", "ConcreteStudentWs")]
        public void Verify_InstanceConcreteStategyWs_IsNotNull()
        {
            //Arrange
            StudentWebService studentWs = new StudentWebService();

            //Assert
            Assert.NotNull(studentWs);
        }

        [Fact(DisplayName = "Method verify object instance is not null")]
        [Trait("Instance Object Concrete", "ConcreteStudentDB")]
        public void Verify_InstanceConcreteStategyDb_IsNotNull()
        {
            //Arrange
            StudentDb studentDb = new StudentDb();

            //Assert
            Assert.NotNull(studentDb);
        }

        [Fact(DisplayName = "Method verify object instance is not null")]
        [Trait("Instance Object Concrete", "StudentModel")]
        public void Verify_InstanceStudentModel_IsNotNull()
        {
            //Arrange
            Student student = new Student();

            //ACT
            student.FirstName = "Post";
            student.LastName = "Malone";
            student.Active = true;

            //Assert
            Assert.NotNull(student);
        }

        [Fact(DisplayName = "Method verify object instance is not null")]
        [Trait("Interface instance object", "IStudent")]
        public void Verify_InstanceStudentInterface_IsNotNull()
        {
            //Arrange
            IStudent student = new StudentApi();

            //Assert
            Assert.NotNull(student);
        }

        [Theory(DisplayName = "Test of ContextStudent")]
        [Trait("Interface instance object", "ContextStudent")]
        [InlineData("API")]
        public void Verify_InstanceImplemetationContext_IsNotNull(string system) {

            //Arrange
            ContextStudent contextStudent = new ContextStudent();
            ICollection<Student> result = new List<Student>();

            //ACT
            if (system.Equals("API"))
            {
                StudentApi studentApi = new StudentApi();
                contextStudent.SetStrategy(studentApi);
                result = contextStudent.ExecuteStrategy();
            }
            if (system.Equals("Ws"))
            {
                StudentWebService studentWs = new StudentWebService();
                contextStudent.SetStrategy(studentWs);
                result = contextStudent.ExecuteStrategy();
            }
            if (system.Equals("Db"))
            {
                StudentDb studentDb = new StudentDb();
                contextStudent.SetStrategy(studentDb);
                result = contextStudent.ExecuteStrategy();
            }

            //Assert
            Assert.NotNull(result);
        
        }
    }
}