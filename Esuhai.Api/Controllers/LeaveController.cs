using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Esuhai.Api.Dtos;
using Esuhai.Api.Helper;
using Esuhai.Api.Models;
using Esuhai.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Esuhai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LeaveController : ControllerBase
    {
        private readonly ILeaveRepository _repo;
        private readonly IMapper _mapper;

        public LeaveController(ILeaveRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery]UserParams userParams)
        {
            var leaves = await  _repo.GetAll(userParams);

            var leavesForResponse = _mapper.Map<IEnumerable<UserForLeaveDto>>(leaves);
            
            Response.AddPagination(leaves.CurrentPage, leaves.PageSize, leaves.TotalCount, leaves.TotalPages);

            return Ok(leavesForResponse);
        }
        [HttpGet("{id}")]
        public Task<Leave> Get(int id)
        {
            return _repo.Get(id);
        }
        [HttpGet("department/{id}")]
        public Task<IEnumerable<Leave>> GetByDepartment(int id)
        {
            return _repo.GetLeavesInDepartment(id);
        }
        [HttpGet("section/{id}")]
        public Task<IEnumerable<Leave>> GetBySection(int id)
        {
            return _repo.GetLeavesInSection(id);
        }
    }
}