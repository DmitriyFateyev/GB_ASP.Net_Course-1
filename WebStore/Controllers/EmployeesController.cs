using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _employeesData;

        public EmployeesController(IEmployeesData employeesData) => _employeesData = employeesData;

        //[Route("users")]
        public IActionResult EmployeesList() => View(_employeesData.GetAll());

        //[ActionName("{id}")]                                            // not working
        public IActionResult Details(int id)
        {
            var employee = _employeesData.GetByID(id);

            if (employee == null) return NotFound();

            return View(employee);
        }
    }
}