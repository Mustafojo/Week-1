using Dapper;
using Domain.Models;
using Infrastructure.DataContex;

namespace Infrastructure.Services;

public class CourceGroupService
{
     private readonly DapperContext _contex;
    public CourceGroupService()
    {
        _contex = new DapperContext();
    }
  
  
    }

