using Entities.DAos;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BusinessLogic
{
    public class EmployeeLogic : IEmployeeLogic
    {
        IEmployeeRepo employeeDb;
        public EmployeeLogic()
        {
            employeeDb = new EmployeeRepo();
        }
        public bool Create(Employee E)
        {
            //Age Of Employee should be grater than 18
            //
            var Age = DateTime.Now.Year - E.DOB.Year;
            if(Age < 18)
            {
                throw new Exception("Employee is Under Age");
            }

            var count = employeeDb.Create(E);

            return (count != 0) ? true : false;

        }

        public bool Delete(int eid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllByDid(int did)
        {
            throw new NotImplementedException();
        }

        public Employee? GetById(int eid)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee E, int eid)
        {
            throw new NotImplementedException();
        }
    }
}
