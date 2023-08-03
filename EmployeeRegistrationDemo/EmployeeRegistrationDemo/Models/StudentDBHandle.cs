using System.Data.SqlClient;
using System.Data;
using System.Reflection.PortableExecutable;

namespace EmployeeRegistrationDemo.Models
{
    public class StudentDBHandle
    {


        private readonly IConfiguration _configuration;
        private readonly object configuration;

        public StudentDBHandle(IConfiguration config)
        {
            _configuration = config;
        }

        public List<Employee> DisplayForm()
        {
            List<Employee> Emplist = new List<Employee>();
            //con.Open();
            //sd.Fill(dt);
            //con.Close();
            string constr = _configuration["ConnectionStrings:conn"];

            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string procedureName = "spGetEmp";

                SqlCommand cmd = new SqlCommand(procedureName, con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();


                sd.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Emplist.Add(
                        new Employee
                        {   ID = Convert.ToInt32(dr["EmployeeId"]),
                            Email = Convert.ToString(dr["EmailId"]),
                            Name = Convert.ToString(dr["Name"]),
                            PhoneNo = Convert.ToString(dr["PhoneNumber"]),
                            Address = Convert.ToString(dr["Address"]),
                            Department = Convert.ToString(dr["DeptId"])
                        });
                }
                return Emplist;
            }





        }

        public bool AddEmployee(Employee employee)
        {
            string constr = _configuration["ConnectionStrings:conn"];

            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string procedureName = "InsertDataIntoTwoTables";

                SqlCommand cmd = new SqlCommand(procedureName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNo);
                cmd.Parameters.AddWithValue("@DeptId", employee.Department);
                cmd.Parameters.AddWithValue("@Address", employee.Address);

                cmd.Parameters.AddWithValue("@EmailId", employee.Email);


                int iRowAffected = cmd.ExecuteNonQuery();
                if (iRowAffected > 0)
                    return true ;

            }
            return false;
            
        }

        public bool UpdateEmployee(Employee employee)
        {
            string constr = _configuration["ConnectionStrings:conn"];

            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string procedureName = "spUpdateEmployees";

                SqlCommand cmd = new SqlCommand(procedureName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emp_Name", employee.Name);
                cmd.Parameters.AddWithValue("@Emp_phone", employee.PhoneNo);
                cmd.Parameters.AddWithValue("@Department", employee.Department);
                cmd.Parameters.AddWithValue("@Emp_Add", employee.Address);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@EmpId", employee.ID);


                int iRowAffected = cmd.ExecuteNonQuery();
                if (iRowAffected > 0)
                    return true;

            }
            return false;

        }


        public bool DeleteEmployee(int id)
        {
            string constr = _configuration["ConnectionStrings:conn"];

            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string procedureName = "DeleteData";

                SqlCommand cmd = new SqlCommand(procedureName, con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@ID", id);


                int iRowAffected = cmd.ExecuteNonQuery();
                if (iRowAffected > 0)
                    return true;

            }
            return false;

        }

    }
}
