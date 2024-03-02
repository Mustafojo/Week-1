using Domain.Models;
using Infrastructure.Services;

var stuser = new StudentService();
var groupser = new GroupService();


var student = new Students();
student.StudentName = "Hola";
student.Age = 32;
student.GroupId = 4;

var group = new Groups();
group.Name = "SQL";
group.StudentId = 1;

stuser.AddStudents(student);

foreach (var item in stuser.GetStudents())
{
    System.Console.WriteLine("Id : " + item.Id);
    System.Console.WriteLine("Name : " + item.StudentName);
    System.Console.WriteLine("Age : " + item.Age);
    System.Console.WriteLine("-----------------------------");
}

System.Console.WriteLine("*******************************************");

foreach (var item in stuser.GetStudentsByGroup(student))
{
    System.Console.WriteLine("Id : " + item.Id);
    System.Console.WriteLine("StudentName : " + item.StudentName);
    System.Console.WriteLine("Age : " + item.Age);
    System.Console.WriteLine("GroupId : " + item.GroupId);
    System.Console.WriteLine("-------------------------------");
}

foreach (var item in groupser.GetGroupsByStuntyId(group))
{
    System.Console.WriteLine("Id : " + item.StudentId);
    System.Console.WriteLine("Name : " + item.Name);
    System.Console.WriteLine("Id : " + item.Id);
}






