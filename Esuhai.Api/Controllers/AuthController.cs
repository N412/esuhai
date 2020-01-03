using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Esuhai.Api.Data;
using Esuhai.Api.Dtos;
using Esuhai.Api.Models;
using Esuhai.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Esuhai.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationRepository _repo;
        private readonly IMapper _mapper;
        private readonly IServicesRepository _services;

        public AuthController(IAuthenticationRepository repo, IMapper mapper, IServicesRepository services)
        {
            _repo = repo;
            _mapper = mapper;
            _services = services;
        }

        [HttpGet("currentuser")]
        public async Task<IActionResult> GetCurrentUser()
        {
            var uid = this.User.Identity.Name;

            if (uid == null)
                return null;

            string _username = uid.Split("\\")[1];
            string _spusername = @"esuhai\" + _username;

            var user = await _repo.GetUserByUsername(_spusername);

            if (user == null)
                return BadRequest();

            var userForResponse = _mapper.Map<UserForLoginDto>(user);

            return Ok(userForResponse);
        }
        
        [HttpGet("allobjectsforleave")]
        public async Task<IActionResult> GetAllObjectsForLeave()
        {
            var uid = this.User.Identity.Name;

            if (uid == null)
                return BadRequest();

            string _username = uid.Split("\\")[1];
            string _spusername = @"esuhai\" + _username;

            var user = await _repo.GetUserByUsername(_spusername);

            if (user.isHR == true)
            {
                ObjectsForLeaveDto cfl = new ObjectsForLeaveDto();

                var ListDepartments = await _services.GetAllDepartments();
                cfl.ListDepartments = ListDepartments.ToList();
                cfl.ListDepartments.Insert(0, new Department() { Id = 0, DeptName = "Tất cả" });

                var ListEmployees = await _services.GetAllEmployees();
                cfl.ListEmployees = ListEmployees.ToList();

                return Ok(cfl);
            }
            else
            {
                ObjectsForLeaveDto cfl = new ObjectsForLeaveDto();

                List<Department> departments = new List<Department>();
                departments.Add(user.Department);
                cfl.ListDepartments = departments;

                var ListEmployees = await _services.GetEmployeesInDepartment((int)user.DepartmentId);
                cfl.ListEmployees = ListEmployees.ToList();

                return Ok(cfl);
            }

        }

    }
}
