using System;
using System.Collections.Generic;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class EmployeeDetail
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int? EmpSalary { get; set; }
        public int? DeptId { get; set; }
        public string Address { get; set; }
        public DateTime? Dob { get; set; }
        public string Mobiles { get; set; }
        public bool Status { get; set; }
        public int? CreatedBy { get; set; }
        public string MobileNo { get; set; }
        public bool? Available { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string FatherName { get; set; }
        public string Location { get; set; }
        public string JobLocation { get; set; }
    }
}
