using DatafirstApproachExampleInCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatafirstApproachExampleInCore.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _employeeContext;//Global variable
        public EmployeeRepository(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public List<EmployeeDetail> GetEmployeeDetails()
        {
            return _employeeContext.EmployeeDetails.ToList();
        }
    }
}
