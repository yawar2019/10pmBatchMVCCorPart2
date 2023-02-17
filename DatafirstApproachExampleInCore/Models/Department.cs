using System;
using System.Collections.Generic;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string Description { get; set; }
        public int? NoOfEmployees { get; set; }
    }
}
