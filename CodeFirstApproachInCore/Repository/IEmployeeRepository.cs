using CodeFirstApproachInCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproachInCore.Repository
{
    public interface IEmployeeRepository
    {
        List<EmployeeModel> GetAllEmployees();
    }
}
