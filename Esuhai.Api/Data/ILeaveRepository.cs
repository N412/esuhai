using System.Collections.Generic;
using System.Threading.Tasks;
using Esuhai.Api.Helper;
using Esuhai.Api.Models;

namespace Esuhai.API.Data
{
    public interface ILeaveRepository
    {
        Task<PagedList<Leave>> GetAll(UserParams userParams);
        //Task<IEnumerable<Leave>> GetAll();
        Task<Leave> Get(int Id);
        Task<IEnumerable<Leave>> GetLeavesInDepartment(int DepartmentId);
        Task<IEnumerable<Leave>> GetLeavesInSection(int SectionId);
    }
}