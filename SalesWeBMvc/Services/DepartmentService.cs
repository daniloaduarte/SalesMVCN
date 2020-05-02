using SalesWeBMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeBMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWeBMvcContext _context;

        public DepartmentService(SalesWeBMvcContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
