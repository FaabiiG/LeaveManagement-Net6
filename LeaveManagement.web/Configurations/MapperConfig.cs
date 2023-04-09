using AutoMapper;
using LeaveManagement.web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
