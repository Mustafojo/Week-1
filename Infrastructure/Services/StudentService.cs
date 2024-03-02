using Dapper;
using Domain.Models;
using Infrastructure.DataContex;

namespace Infrastructure.Services;

public class StudentService
{
    private readonly DapperContext _contex;
    public StudentService()
    {
        _contex = new DapperContext();
    }

     public List<Students> GetStudents()
    {
        var sql = "select * from students";
        var cat = _contex.Connection().Query<Students>(sql).ToList();
        return cat;
    }
    public void AddStudents(Students students)
    {
        var sql = "insert into Students (studentname,age,groupid) values (@studentname,@age,@groupid)";
        _contex.Connection().Execute(sql , students);
    }

    public void UpdateStudent(Students students)
    {
        var sql = "update Students set name = @name,age = @age,groupid = @groupid where id = @id";
        _contex.Connection().Execute(sql);
    }
    
    public void DeleteStudent(int id)
    {
        var sql = "delete from students where id = @id";
        _contex.Connection().Execute(sql, new {Id = id});
    }
    
    public List<Students> GetStudentsByGroup(Students students)
    {
        var sql = @"select s.Id,s.studentname,s.Age,g.Id as groupId 
                  from Students as s 
                  join Groups as g on g.Id = s.GroupId where groupid = 1";
        var cat = _contex.Connection().Query<Students>(sql ,students).ToList();
        return cat;
    }

    
   


   
}
