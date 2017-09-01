using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace HRManagement.Model
{
    public class Purpose
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        public Purpose()
        {
            Expenses=new Collection<Expense>();
        }
    }
}