using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproachInCore.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmpId { get; set; }

        [Display(Name = "Employee Name")]
        public string EmpName { get; set; }
        public string Country { get; set; }
        public int EmpSalary { get; set; }
    }



    public enum StaffEnum
    {

        Nazrin=11,
        [Display(Name ="Payal Thakur")]
        Payal=21,
        Kishor=34,
        PAto=76,
        Jagdish=88,
        Rahul=99
    }

    public class RegistrationModel
    {
      
        [Required(ErrorMessage ="UserName cannot empty")]
        public string UserName { get; set; }
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password and Confirm Password Not Match")]
        public string ConfirmPwd { get; set; }
        [Range(10,40,ErrorMessage ="10-40 is valid")]
        public string age { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

    }
}
