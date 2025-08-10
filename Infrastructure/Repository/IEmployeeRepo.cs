using Entities.DAos;

namespace Infrastructure.Repository;

public interface IEmployeeRepo
{
    IEnumerable<Employee> GetAll();
    Employee? GetById(int eid);
    IEnumerable<Employee> GetAllByDid(int did);
    int Create(Employee E);
    bool Update(Employee E, int eid);
    bool Delete(int eid);
}


