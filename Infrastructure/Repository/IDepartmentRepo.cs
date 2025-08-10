
using Entities.DAos;

namespace Infrastructure.Repository;

    public interface IDepartmentRepo
    {
        IEnumerable<Department> GetAll();
        Department? GetById(int did);
        int Create(Department D);
        int Update(Department D);
        int Delete(int did);
    }

