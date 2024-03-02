using Domain.Models;
using Dapper;
using Npgsql;
using Infrastructure.DataContex;
using System.Security.Cryptography.X509Certificates;
namespace Infrastructure.Services;

public class CourceService
{
     private readonly DapperContext _contex;
    public CourceService()
    {
        _contex = new DapperContext();
    }

     public List<Cources> GetCource()
    {
        var sql = "select * from Cources";
        var cat = _contex.Connection().Query<Cources>(sql).ToList();
        return cat;
    }
    public void AddCource(Cources Cource)
    {
        var sql = "insert into Cources (name) values (@name)";
        _contex.Connection().Execute(sql , Cource);
    }

    public void UpdateCource (Cources cource)
    {
        var sql = "update Cources set name = @name where id = @id";
        _contex.Connection().Execute(sql);
    }
    
    public void DeleteCource(int id)
    {
        var sql = "delete from Cources where id = @id";
        _contex.Connection().Execute(sql, new {Id = id});
    }
}
