using System;
using System.Collections.Generic;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class BranchTable
    {
        public BranchTable()
        {
            DepartmentTables = new HashSet<DepartmentTable>();
        }

        public int BranchId { get; set; }
        public string BranchName { get; set; }

        public virtual ICollection<DepartmentTable> DepartmentTables { get; set; }
    }
}
