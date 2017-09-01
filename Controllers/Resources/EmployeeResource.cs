using System.Collections.Generic;
using System.Collections.ObjectModel;
using HRManagement.Model;

namespace HRManagement.Controllers.Resources
{
    public class EmployeeResource
    {
        public EmployeeResource()
        {
            Expenses=new Collection<Expense>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }
}