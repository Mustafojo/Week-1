using Infrastructure.DataContex;
using Dapper;
using Domain.Models;
using Npgsql;
namespace Infrastructure.Services;

public class GroupService
{
     private readonly DapperContext _contex;
    public GroupService()
    {
        _contex = new DapperContext();
    }

     public List<Groups> GetGroups()
    {
        var sql = "select * from Groups";
        var cat = _contex.Connection().Query<Groups>(sql).ToList();
        return cat;
    }
    public void AddGroups(Groups groups)
    {
        var sql = "insert into Groups (name) values (@name)";
        _contex.Connection().Execute(sql , groups);
    }

    public void UpdateGroup(Groups groups)
    {
        var sql = "update Groups set name = @name where id = @id";
        _contex.Connection().Execute(sql, groups);
    }
    
    public void DeleteGroup(int id)
    {
        var sql = "delete from Groups where id = @id";
        _contex.Connection().Execute(sql, new {Id = id});
    }

    public List<Groups> GetGroupsByStuntyId(Groups groups)
    {
        var sql = @"select s.Id as StudentId,g.Id as GroupId,g.Name 
                  from Groups as g  
                  join Students as s on s.Id = g.StudentId where studentid = 1";
        var cat = _contex.Connection().Query<Groups>(sql ,groups).ToList();
        return cat;   
    }

    

}
