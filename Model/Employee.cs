using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace HRManagement.Model
{
    public class Employee
    {
        public Employee()
        {
            Expenses=new Collection<Expense>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public bool Status { get; set; }
        [Required]
        [StringLength(255)]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }
        public ICollection<Expense> Expenses { get; set; }

    }
}