using CodeFirstApproachInCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproachInCore.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _db;
        public EmployeeRepository(EmployeeContext db)
        {
            _db = db;
        }
        public List<EmployeeModel> GetAllEmployees()
        {
            return _db.EmployeeModels.ToList();
        }
    }
}
