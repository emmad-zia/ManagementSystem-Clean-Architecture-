using Entities.DAos;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class EmployeeRepo : IEmployeeRepo
{

    OrgDbContext db;

    public EmployeeRepo()
    {
        db = new OrgDbContext();
    }

    #region Get Methods
    public IEnumerable<Employee> GetAll()
    {
        //OrganizationDbContext db = new OrganizationDbContext();
        var Emps = db.Employees.Include(x => x.DepartmentNav).ToList();
        return Emps;
    }

    public Employee? GetById(int eid)
    {
        //OrganizationDbContext db = new OrganizationDbContext();
        var E = (new OrgDbContext()).Employees.Find(eid);
        if (E != null)
        {
            return E;
        }
        return null;
    }

    public IEnumerable<Employee> GetAllByDid(int did)
    {
        var Emps = db.Employees.Where(x => x.Did == did).Include(x => x.DepartmentNav).ToList();
        return Emps;
    }
    #endregion

    #region Post,Put,Delete
    public int Create(Employee E)
    {
        
        db.Employees.Add(E);
        return db.SaveChanges();
    }


    public bool Delete(int eid)
    {
        //OrganizationDbContext db = new OrganizationDbContext();
        var E = db.Employees.Find(eid);
        if (E != null)
        {
            db.Employees.Remove(E);
            return Save();
        }
        return false;
    }

    public bool Update(Employee E, int eid)
    {
        if (E.Eid == eid)
        {
            //OrganizationDbContext db = new OrganizationDbContext();
            db.Employees.Update(E);
            return Save();
        }
        return false;
    }

    private bool Save()
    {
        return (db.SaveChanges() != 0) ? true : false;
    }
    #endregion
}

