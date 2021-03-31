using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private static readonly List<Employee> _Employees = new()
        {
            new Employee { id = 1, Name = "John", Lastname = "Wick", Patronymic = "Petrovich", Age = 53, email = "john@company.com" },
            new Employee { id = 2, Name = "Alexander", Lastname = "Makarov", Patronymic = "Sidorovich", Age = 23, email = "alex@company.com" },
            new Employee { id = 3, Name = "Nikolay", Lastname = "Valuev", Patronymic = "Ivanovich", Age = 32, email = "niko@company.com" }
        };


        //[Route("users")]
        public IActionResult EmployeesList() => View(_Employees);

        //[ActionName("{id}")]                                            // not working
        public IActionResult Details(int id)
        {
            var employee = _Employees.FirstOrDefault(e => e.id == id);

            if (employee == null) return NotFound();

            return View(employee);
        }
    }
}
