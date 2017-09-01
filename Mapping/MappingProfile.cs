using AutoMapper;
using HRManagement.Controllers.Resources;
using HRManagement.Model;

namespace HRManagement.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeResource>().ReverseMap();

        }
    }
}