using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HRManagement.Controllers.Resources
{
    public class UserTypeResource
    {
        public UserTypeResource()
        {
            Employees = new Collection<EmployeeResource>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<EmployeeResource> Employees { get; set; }
    }
}