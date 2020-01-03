using Esuhai.Api.Dtos;
using Esuhai.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esuhai.Api.Data
{
    public interface IServicesRepository
    {
        Task<IEnumerable<Department>> GetAllDepartments();
        Task<IEnumerable<UserForLoginDto>> GetAllEmployees();
        Task<IEnumerable<UserForLoginDto>> GetEmployeesInDepartment(int departmentId);
    }
}
