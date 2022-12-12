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

        public void AddPerson(PersonRequest person)
        {
            try
            {
                Connection();
                conn.Open();
                conn.Execute("AddPerson", person, commandType: CommandType.StoredProcedure);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Person> GetAllPersons()
        {
            try
            {
                Connection();
                conn.Open();
                IList<Person> EmpList = SqlMapper.Query<Person>(
                                  conn, "GetPersons").ToList();
                conn.Close();
                return EmpList.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdatePerson(Person person)
        {
            try
            {
                Connection();
                conn.Open();
                conn.Execute("UpdatePerson", person, commandType: CommandType.StoredProcedure);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeletePerson(int Id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id_Person", Id);
                Connection();
                conn.Open();
                conn.Execute("DeletePerson", param, commandType: CommandType.StoredProcedure);
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                //Log error as per your need
                throw ex;
            }
        }
    }
}