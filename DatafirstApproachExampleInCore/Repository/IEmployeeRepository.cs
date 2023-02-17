using DatafirstApproachExampleInCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatafirstApproachExampleInCore.Repository
{
    public interface IEmployeeRepository
    {
        List<EmployeeDetail> GetEmployeeDetails();
    }
}
