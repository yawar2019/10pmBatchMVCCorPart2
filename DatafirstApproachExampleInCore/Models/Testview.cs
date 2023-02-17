using System;
using System.Collections.Generic;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class Testview
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int? EmpSalary { get; set; }
        public int? DeptId { get; set; }
        public string Address { get; set; }
        public DateTime? Dob { get; set; }
        public bool Status { get; set; }
    }
}
