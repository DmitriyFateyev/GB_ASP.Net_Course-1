﻿using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult SecondAction() => Content("Second action method");

        public IActionResult Shop() => View();

        public IActionResult ProductDetails() => View();

        public IActionResult Login() => View();

        public IActionResult ContactUs() => View();

        public IActionResult Checkout() => View();

        public IActionResult Cart() => View();

        public IActionResult BlogSingle() => View();
    }
}
