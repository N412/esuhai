using Esuhai.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esuhai.Api.Dtos
{
    public class ObjectsForLeaveDto
    {
        public List<Department> ListDepartments { get; set; }
        public List<UserForLoginDto> ListEmployees { get; set; }
    }
}
