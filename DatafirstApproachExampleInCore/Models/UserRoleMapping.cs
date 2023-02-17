using System;
using System.Collections.Generic;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class UserRoleMapping
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public int? RoleId { get; set; }
    }
}
