using Entities.DAos;

namespace Application.BusinessLogic;

public interface IDepartmentLogic
{
    IEnumerable<Department> GetAll();
    Department? GetById(int did);
    int Create(Department D);
    int Update(Department D);
    int Delete(int did);
}
