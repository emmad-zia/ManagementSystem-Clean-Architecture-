
using Entities.DAos;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;
public class DepartmentRepo : IDepartmentRepo
{

    OrgDbContext db;

    public DepartmentRepo()
    {
        db = new OrgDbContext();
    }

    public IEnumerable<Department> GetAll() => db.Departments.Include(x => x.Employees).ToList();


    public Department? GetById(int did) => db.Departments.Find(did);


    public int Create(Department D)
    {
        db.Departments.Add(D);
        return db.SaveChanges();
    }

    public int Delete(int did)
    {
        var D = db.Departments.Find(did);
        db.Departments.Remove(D!);
        return db.SaveChanges();
    }

    public int Update(Department D)
    {
        db.Departments.Update(D);
        return db.SaveChanges();
    }
}

