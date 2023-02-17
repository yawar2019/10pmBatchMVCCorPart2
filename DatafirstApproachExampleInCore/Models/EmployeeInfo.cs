using System;
using System.Collections.Generic;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class EmployeeInfo
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public int? DeptId { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}
