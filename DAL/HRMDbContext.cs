using HRManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.DAL
{
    public class HRMDbContext: DbContext
    {
        public HRMDbContext(DbContextOptions<HRMDbContext> options)
        : base(options)
        {

        }

            public DbSet<Category> Categories { get; set; }
            public DbSet<Client> Clients { get; set; }
            public DbSet<ClientLocation> ClientLocations { get; set; }
            // public DbSet<Description> Descriptions { get; set; }
            public DbSet<Employee> Employees { get; set; }
            public DbSet<Expense> Expenses { get; set; }
            public DbSet<ExpenseDetail> ExpenseDetails { get; set; }
            public DbSet<Purpose> Purposes { get; set; }
            public DbSet<Status> Status { get; set; }
            public DbSet<UserType> UserTypes { get; set; }
    }
}