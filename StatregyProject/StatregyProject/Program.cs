// See https://aka.ms/new-console-template for more information
using StatregyProject.ConcreteStrategy;
using StatregyProject.Context;
using StatregyProject.Model;

Console.WriteLine("Welcome to implementation design patterns Strategy");

ContextStudent contextStudent = new ContextStudent();

ICollection<Student> students;

StudentWebService studentWebService = new StudentWebService();

contextStudent.SetStrategy(studentWebService);

students = contextStudent.ExecuteStrategy();

if (students != null)
    foreach (var student in students)
        Console.WriteLine(student.ToString());

StudentApi studentApi = new StudentApi();

contextStudent.SetStrategy(studentApi);

students = contextStudent.ExecuteStrategy();

if (students != null)
    foreach (var student in students)
        Console.WriteLine(student.ToString());


