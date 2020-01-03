using System.Collections.Generic;
using System.Threading.Tasks;
using Esuhai.Api.Models;
using Esuhai.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace Esuhai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeController(IEmployeeRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public Task<IEnumerable<Employee>> GetAll()
        {
            return _repo.GetAll();
        }
        [HttpGet("{id}")]
        public Task<Employee> Get(int id)
        {
            return _repo.Get(id);
        }
    }
}