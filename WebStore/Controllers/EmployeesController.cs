using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _employeesData;

        public EmployeesController(IEmployeesData employeesData) => _employeesData = employeesData;

        [Route("users")]
        public IActionResult EmployeesList() => View(_employeesData.GetAll());

        //[ActionName("{id}")]                                            // not working
        [Route("{id}")]
        public IActionResult Details(int id)
        {
            var employee = _employeesData.GetByID(id);

            if (employee == null) return NotFound();


            return View(employee);
        }

        [Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            Employee employee;
            if (id.HasValue)
            {
                employee = _employeesData.GetByID(id.Value);
                if (ReferenceEquals(employee, null))
                    return NotFound();
            }
            else
            {
                employee = new Employee();
            }
            return View(employee);
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.id > 0)
                {
                    var editEmployee = _employeesData.GetByID(employee.id);

                    if (editEmployee is null)
                    {
                        return NotFound();
                    }

                    editEmployee.Name = employee.Name;
                    editEmployee.Lastname = employee.Lastname;
                    editEmployee.Patronymic = employee.Patronymic;
                    editEmployee.Age = employee.Age;
                    editEmployee.email = employee.email;
                }
                else
                {
                    _employeesData.CreateEmployee(employee);
                }
                _employeesData.Commit();

                return RedirectToAction(nameof(EmployeesList)); 
            }

            return View(employee);
        }

        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0) return BadRequest();

            var employee = _employeesData.GetByID(id);

            if (employee is null) return NotFound();

            return View(new EmployeeViewModel
            {
                id = employee.id,
                Name = employee.Name,
                Lastname = employee.Lastname,
                Patronymic = employee.Patronymic,
                Age = employee.Age,
                email = employee.email
            });
        }

        public IActionResult DeleteConfirmed(int id)
        {
            _employeesData.DeleteEmployee(id);
            return RedirectToAction("EmployeesList");
        }
    }
}