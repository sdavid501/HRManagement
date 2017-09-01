using System;

namespace HRManagement.Model
{
    public class ExpenseDetail
    {
        public int Id { get; set; }
        public int ExpenseId { get; set; }
        public Expense Expense { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        // public int DescriptionId { get; set; }
        // public Description Description { get; set; }
        public DateTime Date { get; set; }
        public Decimal Amount { get; set; }
        public string Note { get; set; }
    }
}