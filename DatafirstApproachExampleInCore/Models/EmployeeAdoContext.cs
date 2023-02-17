using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace DatafirstApproachExampleInCore.Models
{
    public class EmployeeAdoContext
    {
        

        public List<Employee> GetEmployees(string Constr) {

            List<Employee> listEmp = new List<Employee>();
            SqlConnection con = new SqlConnection(Constr);
            SqlCommand cmd = new SqlCommand("sp_employee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Employee obj = new Employee();
                obj.Id = Convert.ToInt32(dr[0]);
                obj.EmpName = dr[1].ToString();
                obj.EmpSalary = Convert.ToInt32(dr[2]);
                listEmp.Add(obj);
            }
            return listEmp;
            
        }
    }
}
