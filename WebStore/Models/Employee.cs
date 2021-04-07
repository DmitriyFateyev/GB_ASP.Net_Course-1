using System.ComponentModel.DataAnnotations;

namespace WebStore.Models
{
    public class Employee
    {
        public int id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name field is required")]
        [Display(Name = "Name")]
        [StringLength(maximumLength:100, MinimumLength = 2, ErrorMessage = "Name length is incorrect. Minimum: 2 Maximum: 100 symbols allowed.")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Lastname field is required")]
        [Display(Name = "Lastname")]
        public string Lastname { get; set; }

        [Display(Name = "Patronymic")]
        public string Patronymic { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Age field is required")]
        [Display(Name = "Age:")]
        public int Age { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Incorrect format")]
        [Display(Name = "e-mail")]
        public string email { get; set; }
    }
}
