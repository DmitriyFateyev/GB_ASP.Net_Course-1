using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> _Employees = new()
        {
            new Employee { id = 1, Name = "John",      Lastname = "Wick",      Patronymic = "Petrovich",  Age = 53 },
            new Employee { id = 2, Name = "Alexander", Lastname = "Makarov",   Patronymic = "Sidorovich", Age = 23 },
            new Employee { id = 3, Name = "Nikolay",   Lastname = "Valuev",    Patronymic = "Ivanovich",  Age = 32 }
        };

        public IActionResult Index() => View();

        public IActionResult SecondAction() => Content("Second action method");

        public IActionResult Employees() => View(_Employees);
    }
}
