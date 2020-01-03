using System.Collections.Generic;
using System.Threading.Tasks;
using Esuhai.Api.Dtos;
using Esuhai.Api.Models;

namespace Esuhai.API.Data
{
    public interface IAuthenticationRepository
    {
        Task<Employee> GetUserByUsername(string username);
        Task<IEnumerable<Department>> GetAllDepartments();
    }
}