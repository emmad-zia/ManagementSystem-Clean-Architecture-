using Entities.DAos;

namespace Application.BusinessLogic;

public interface IEmployeeLogic
{
    IEnumerable<Employee> GetAll();
    Employee? GetById(int eid);
    IEnumerable<Employee> GetAllByDid(int did);
    bool Create(Employee E);
    bool Update(Employee E, int eid);
    bool Delete(int eid);
}
