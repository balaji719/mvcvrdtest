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
            string query = "insert into Employee values('" + e.EmpName + "', '" + e.EmpEmail + "', '" + e.EmpSalary + "', '" + e.EmpDesignaton + "')";
            SqlCommand sc = new SqlCommand(query, con);
            int i = sc.ExecuteNonQuery();
            con.Close();
            return i;
           

        }

        public int DeleteEmpoyee(Models.Employee e)
        {
            SqlConnection con = new SqlConnection("user id =balaji;password=balaji;database=Balaji;data source=.");
            con.Open();
            string query = "delete from Employee where Id='" + e.Id + "'";
            SqlCommand sc = new SqlCommand(query, con);
            int i= sc.ExecuteNonQuery();
            con.Close();
            return i;

        }

        public int UpdateEmpoyee(Models.Employee e1)
        {
            SqlConnection con = new SqlConnection("user id =balaji;password=balaji;database=Balaji;data source=.");
            con.Open();
            string query = "update Employee SET  Name= '" + e1.EmpName +"' ,Email='"+e1.EmpEmail+"', Salary='"+e1.EmpSalary+ "' ,Designaton='" + e1.EmpDesignaton+"'  where Id='" +e1.Id+ "' ";
            SqlCommand sc = new SqlCommand(query, con);
            int i = sc.ExecuteNonQuery();
            con.Close();
            return i;

        }

        public List<Models.Employee> GetEmps()
        {
            List<Models.Employee> emps = new List<Models.Employee>();
            SqlConnection con = new SqlConnection("user id =balaji;password=balaji;database=Balaji;data source=.");
            con.Open();
            string query = "select * from Employee";
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader dr = sc.ExecuteReader();
            if(dr.HasRows)
            {
                while (dr.Read())
                {
                    Models.Employee e1 = new Models.Employee();
                    e1.Id = Convert.ToInt32(dr[0]);
                    e1.EmpName = dr[1].ToString();
                    e1.EmpEmail = dr[2].ToString();
                    e1.EmpSalary = Convert.ToDouble(dr[3]);
                    e1.EmpDesignaton = dr[4].ToString();
                    emps.Add(e1);
                }
            }
            con.Close();
            return emps;
        }
    }
}