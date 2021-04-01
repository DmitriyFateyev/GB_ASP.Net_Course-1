using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Infrastructure.Interfaces
{
    public interface IEmployeesData
    {
        IEnumerable<Employee> GetAll();

        Employee GetByID(int id);

        void EditEmployee();    //Commit

        void CreateEmployee(Employee employee); // AddNew

        void DeleteEmployee(int id);
    }
}
