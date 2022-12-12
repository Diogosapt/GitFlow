using Dapper;
using GitFlow.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GitFlow.Repository
{
    public class DataRepository
    {
        public SqlConnection conn;

        private void Connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            conn = new SqlConnection(constr);
        }

        public void AddEmployee(EmployeeRequest employee)
        {
            try
            {
                Connection();
                conn.Open();
                conn.Execute("AddEmployee", employee, commandType: CommandType.StoredProcedure);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}