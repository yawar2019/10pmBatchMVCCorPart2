using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproachInCore.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<EmployeeModel> EmployeeModels { get; set; }
    }
}
