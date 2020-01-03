using AutoMapper;
using Esuhai.Api.Dtos;
using Esuhai.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esuhai.Api.Helper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Employee, UserForLoginDto>();
            CreateMap<Leave, UserForLeaveDto>();
        }
    }
}
