using Esuhai.Api.Helper;
using Esuhai.Api.Models;
using Esuhai.API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esuhai.Api.Data
{
    public class LeaveRepository : ILeaveRepository
    {
        private readonly ESUHAI_HRContext _context;

        public LeaveRepository(ESUHAI_HRContext context)
        {
            _context = context;
        }
        public async Task<PagedList<Leave>> GetAll(UserParams userParams)
        {
            var leaves = _context.Leave
                .Include(n => n.NhanVienNghiPhep).ThenInclude(m => m.Department)
                .Include(n => n.NhanVienNghiPhep).ThenInclude(m => m.Section)
                .Include(n => n.NhanVienThayThe)
                .Where(n => n.isCancel != true)
                .AsQueryable();

            if (userParams.DepartmentId > 0)
                leaves = leaves.Where(n => n.NhanVienNghiPhep.DepartmentId == userParams.DepartmentId);

            if (userParams.EmployeeId > 0)
                leaves = leaves.Where(n => n.EmployeeId == userParams.EmployeeId);

            if (userParams.StartDate.HasValue)
                leaves = leaves.Where(n => n.StartTime >= userParams.StartDate);

            if (userParams.EndDate.HasValue)
                leaves = leaves.Where(n => n.EndTime <= userParams.EndDate);

            if (!string.IsNullOrEmpty(userParams.FilterBy))
            {
                switch(userParams.FilterBy)
                {
                    case "HRApproved":
                        leaves = leaves.Where(n => n.HRApprovalStatus == "Approved");
                        break;
                    case "HRRejected":
                        leaves = leaves.Where(n => n.HRApprovalStatus == "Rejected");
                        break;
                    case "WaitingHR":
                        leaves = leaves.Where(n => string.IsNullOrEmpty(n.HRApprovalStatus) == true && n.TruongPhongApprovalStatus == "Approved");
                        break;
                    case "WaitingTPTB":
                        leaves = leaves.Where(n => string.IsNullOrEmpty(n.HRApprovalStatus) == true);
                        break;
                }
            }


            return await PagedList<Leave>.CreateAsync(leaves, userParams.PageNumber, userParams.PageSize);
        }

        public async Task<Leave> Get(int Id)
        {
            var leave = await _context.Leave.SingleOrDefaultAsync(n => n.Id == Id);
            return leave;
        }

        

        public async Task<IEnumerable<Leave>> GetLeavesInDepartment(int DepartmentId)
        {
            var leaves = await _context.Leave.ToListAsync();
            return leaves;
        }

        public async Task<IEnumerable<Leave>> GetLeavesInSection(int SectionId)
        {
            var leaves = await _context.Leave.ToListAsync();
            return leaves;
        }
    }
}
