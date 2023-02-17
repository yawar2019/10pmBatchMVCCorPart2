using System;
using System.Collections.Generic;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        public int? DeptId { get; set; }
    }
}
