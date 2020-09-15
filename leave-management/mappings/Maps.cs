using AutoMapper;
using leave_management.Data;
using leave_management.Models;

namespace leave_management.mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<LeaveType, CreateLeaveTypeViewModel>().ReverseMap();
            CreateMap<LeaveType, DetailsLeaveTypeViewModel>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryViewModel>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationViewModel>().ReverseMap();
            CreateMap<Employee, EmployeeViewModel>().ReverseMap(); ;

        }
    }
}
