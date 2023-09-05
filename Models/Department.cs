using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class Department
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="You have to provide a valid name.")]
        [MinLength(2,ErrorMessage = "Name mustn't be less than 2 characters.")]
        [MaxLength(20,ErrorMessage ="Name mustn't exceed 20 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You have to provide a valid name.")]
        [MinLength(10, ErrorMessage = "Name mustn't be less than 10 characters.")]
        [MaxLength(50, ErrorMessage = "Name mustn't exceed 50 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage ="You have to provide a valid annual budget.")]
        [Range(0,500000,ErrorMessage ="Annual Budget must be between 0 EGP and 500000 EGP.")]
        public decimal AnnualBudget { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }
    }
}
