using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace mvcvrdtest.DAL
{
    public class Employee1
    {
        public int AddEmpoyee(Models.Employee e)
        {
            SqlConnection con = new SqlConnection("user id =balaji;password=balaji;database=Balaji;data source=.");
            con.Open();
            string query = "insert into Employee values('" + e.Name + "', '" + e.Email + "', '" + e.Salary + "', '" + e.Designaton + "')";
            SqlCommand sc = new SqlCommand(query, con);
            int i = sc.ExecuteNonQuery();
            con.Close();
            return i;

        }

        public int DeleteEmpoyee(Models.Employee e)
        {
            SqlConnection con = new SqlConnection("user id =balaji;password=balaji;database=Balaji;data source=.");
            con.Open();
            string query = "delete from emp where eno='" + e.Id + "'')";
            SqlCommand sc = new SqlCommand(query, con);
            int i = sc.ExecuteNonQuery();
            con.Close();
            return i;

        }
    }
}