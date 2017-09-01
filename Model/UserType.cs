using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace HRManagement.Model
{
    public class UserType
    {
        public UserType()
        {
            Employees=new Collection<Employee>();
        }
        public int Id{get; set;}
        [Required]
        public string Name{get; set;}
        public ICollection<Employee> Employees { get; set; }
    }
}