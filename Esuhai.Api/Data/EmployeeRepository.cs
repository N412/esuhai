using System.Collections.Generic;
using System.Threading.Tasks;
using Esuhai.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Esuhai.API.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ESUHAI_HRContext _context;
        public EmployeeRepository(ESUHAI_HRContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Employee>> GetAll()
        {
            var ds = await _context.Employee.ToListAsync();
            
            return ds;
        }
        public async Task<Employee> Get(int Id)
        {
            var emp = await _context.Employee
                    .SingleOrDefaultAsync(n =>n.Id == Id);
            
            return emp;
        }
    }
}