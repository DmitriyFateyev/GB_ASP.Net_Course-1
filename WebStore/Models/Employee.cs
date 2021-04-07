﻿using System.ComponentModel.DataAnnotations;

namespace WebStore.Models
{
    public class Employee
    {
        [HiddenInput(DisplayValue = false)]
        public int id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public string email { get; set; }
    }
}
