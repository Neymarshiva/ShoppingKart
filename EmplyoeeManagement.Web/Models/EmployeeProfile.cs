using EmplyoeeManagementModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace EmplyoeeManagement.Web.Models
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Emplyoee, EditEmployeeModel>()
                .ForMember(dest => dest.ConfirmEmail,
                opt => opt.MapFrom(src => src.Email));

            CreateMap<EditEmployeeModel, Emplyoee>();
        }
    }
}
