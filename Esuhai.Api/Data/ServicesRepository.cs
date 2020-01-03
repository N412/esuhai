using AutoMapper;
using Esuhai.Api.Dtos;
using Esuhai.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esuhai.Api.Data
{
    public class ServicesRepository : IServicesRepository
    {
        private readonly ESUHAI_HRContext _context;
        private readonly IMapper _mapper;

        public ServicesRepository(ESUHAI_HRContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            var depts = await _context.Department.ToListAsync();
            return depts;
        }

        public async Task<IEnumerable<UserForLoginDto>> GetAllEmployees()
        {
            var emps = await _context.Employee.Where(n => !n.NotActive == true).ToListAsync();

            if(emps!=null)
            {
                var employees = _mapper.Map<IEnumerable<UserForLoginDto>>(emps);
                return employees;
            }

            return null;
        }

        public async Task<IEnumerable<UserForLoginDto>> GetEmployeesInDepartment(int departmentId)
        {
            var emps = await _context.Employee.Where(n => n.DepartmentId == departmentId).ToListAsync();

            if (emps != null)
            {
                var employees = _mapper.Map<IEnumerable<UserForLoginDto>>(emps);
                return employees;
            }

            return null;
        }
    }
}
