using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWeBMvc.Models
{
    public class SalesWeBMvcContext : DbContext
    {
        public SalesWeBMvcContext (DbContextOptions<SalesWeBMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWeBMvc.Models.Department> Department { get; set; }
    }
}
