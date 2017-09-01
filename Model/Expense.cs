using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace HRManagement.Model
{
    public class Expense
    {
        public Expense()
        {
            ExpenseDetails=new Collection<ExpenseDetail>();
        }
        public int Id { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int LocationId { get; set; }
        public ClientLocation ClientLocation { get; set; }
        public int PurposeId { get; set; }
        public Purpose Purpose { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public ICollection<ExpenseDetail> ExpenseDetails { get; set; }
    }
}