using Esuhai.Api.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esuhai.Api.Helper
{
    public static class Extensions
    {
        public static void AddPagination(this HttpResponse response, int currentPage, int itemsPerPage, int totalItems, int totalPages)
        {
            var paginationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPages);
            response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader));
            response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }

        public static void AddDepartments(this HttpResponse response, List<Department> depts)
        {
            response.Headers.Add("Departments", JsonConvert.SerializeObject(depts));
            //response.Headers.Add("Access-Control-Expose-Headers", "Departments");
        }
    }
}
