using System.Collections.Generic;
using System.Threading.Tasks;
using Esuhai.Api.Models;

namespace Esuhai.API.Data
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> Get(int Id);
    }
}