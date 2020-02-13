using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeDmanagement.Models;

namespace EmployeeDmanagement.Data
{
    public class EmployeeDmanagementContext : DbContext
    {
        public EmployeeDmanagementContext (DbContextOptions<EmployeeDmanagementContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeDmanagement.Models.Employee> Employee { get; set; }
    }
}
