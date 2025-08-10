using Entities.DAos;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BusinessLogic;

public class DepartmentLogic : IDepartmentLogic
{
    IDepartmentRepo departmentDb;
    public DepartmentLogic()
    {
        departmentDb = new DepartmentRepo();
    }

    public IEnumerable<Department> GetAll()
    {
        var Depts = departmentDb.GetAll();

        if(Depts.Count()==0)
        {
            throw new Exception("No Records Found");
        }

        return Depts;
    }

    public Department? GetById(int did)
    {
        throw new NotImplementedException();
    }

    public int Create(Department D)
    {
        throw new NotImplementedException();
    }

    public int Delete(int did)
    {
        var D = departmentDb.GetById(did);

        if(D==null)
        {
            throw new Exception("Record Does not Exist");
        }

        return departmentDb.Delete(did);
    }

    

    public int Update(Department D)
    {
        throw new NotImplementedException();
    }
}
