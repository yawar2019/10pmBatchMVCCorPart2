using System;
using System.Collections.Generic;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class DepartmentTable
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public int? BranchId { get; set; }

        public virtual BranchTable Branch { get; set; }
    }
}
