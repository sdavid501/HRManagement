using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HRManagement.Model
{
    public class Category
    {
        public Category()
        {
            ExpenseDetails=new Collection<ExpenseDetail>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ExpenseDetail> ExpenseDetails { get; set; }
    }
}