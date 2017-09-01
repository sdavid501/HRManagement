using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HRManagement.Controllers.Resources;
using HRManagement.DAL;
using HRManagement.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly HRMDbContext context;
        private readonly IMapper _imapper;
        public EmployeesController(HRMDbContext context, IMapper _imapper)
        {
            this._imapper = _imapper;
            this.context = context;

        }
        [HttpGet("/api/employees")]
        public async Task<IEnumerable<EmployeeResource>> GetEmployees()
        {
            var employees = await context.Employees.Include(e => e.UserType).ToListAsync();
            return _imapper.Map<List<Employee>, List<EmployeeResource>>(employees);
        }
    }
}