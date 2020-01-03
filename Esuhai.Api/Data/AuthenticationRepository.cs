using Esuhai.Api.Dtos;
using Esuhai.Api.Models;
using Esuhai.API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esuhai.Api.Data
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly ESUHAI_HRContext _context;

        public AuthenticationRepository(ESUHAI_HRContext context)
        {
            _context = context;
        }

        public async Task<Employee> GetUserByUsername(string username)
        {
            var emp = await _context.Employee
                .Include(n => n.Department)
                .Include(n => n.Section)
                .SingleOrDefaultAsync(n => n.SpuserName.ToLower() == username);

            if (emp != null)
            {
                emp.MaNv = emp.MaNv != null ? emp.MaNv.Trim() : emp.MaNv;
            }

            return emp;
        }

        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            var list = await _context.Department.ToListAsync();
            return list;
        }

        //public async Task<UserForLoginDto> GetUserByUsername(string username)
        //{
        //    var emp = await _context.Employee
        //        .Include(n=>n.Department)
        //        .Include(n=>n.Section)
        //        .SingleOrDefaultAsync(n => n.SpuserName.ToLower() == username);

        //    if (emp == null)
        //        return null;

        //    UserForLoginDto user = new UserForLoginDto();
        //    user.FullName = emp.FullName;
        //    user.MaNV = emp.MaNv;
        //    user.EmployeeId = emp.Id;

        //    return user;
        //}
    }
}
