using System;
using System.Collections.Generic;
using System.Linq;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.Infrastructure.Implementations
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<Employee> _EmployeesTable;

        public InMemoryEmployeesData()
        {
            _EmployeesTable = new List<Employee>
            {
                new Employee { id = 1, Name = "John", Lastname = "Wick", Patronymic = "Petrovich", Age = 53, email = "john@company.com" },
                new Employee { id = 2, Name = "Alexander", Lastname = "Makarov", Patronymic = "Sidorovich", Age = 23, email = "alex@company.com" },
                new Employee { id = 3, Name = "Nikolay", Lastname = "Valuev", Patronymic = "Ivanovich", Age = 32, email = "niko@company.com" }
            };
        }

        public void CreateEmployee(Employee employee)
        {
            employee.id = _EmployeesTable.Max(e => e.id) + 1;
            _EmployeesTable.Add(employee);
        }

        public void DeleteEmployee(int id)
        {
            var employee = GetByID(id);
            if(employee != null)
            {
                _EmployeesTable.Remove(employee);
            }
        }

        public void Commit()
        {
            // TODO:
        }

        public IEnumerable<Employee> GetAll()
        {
            return _EmployeesTable;
        }

        public Employee GetByID(int id)
        {
            return _EmployeesTable.FirstOrDefault(e => e.id.Equals(id));
        }
    }
}
