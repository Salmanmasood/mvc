using loaddatamvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace loaddatamvc.ModelClass
{
    public class employeeviewmodel
    {
        string cs=ConfigurationManager.ConnectionStrings["test"].ConnectionString;
        public List<employees> getallemployees()
        {
            List<employees> li = new List<employees>();

            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("showemployess", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                employees emp = new employees();
                emp.emp_id = int.Parse(rdr["empid"].ToString());
                emp.emp_name = rdr["emp_name"].ToString();
                emp.emp_email = rdr["emp_email"].ToString();
                li.Add(emp);
            }

            return li;


        }//method end....................

        public string insert_loginmethod(employees emp)
        {
            string s = "";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("insert_employees", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@emp_name", SqlDbType.NVarChar, 50).Value = emp.emp_name;
                cmd.Parameters.Add("@emp_email", SqlDbType.NVarChar, 50).Value = emp.emp_email;
                conn.Open();
                cmd.ExecuteNonQuery();


                s = "DATA record has been inserted successfully.....";

            }
            catch (Exception)
            {
                s = "data is not inserted !!!";

            }

            finally
            {
                conn.Close();
            }

            return s;

        } //method end...........

        public string update_loginmethod(employees emp)
        {
            string s = "";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("update_employee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@emp_name", SqlDbType.NVarChar, 50).Value = emp.emp_name;
                cmd.Parameters.Add("@emp_email", SqlDbType.NVarChar, 50).Value = emp.emp_email;
                cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = emp.emp_id;

                conn.Open();
                cmd.ExecuteNonQuery();


                s = "DATA record has been updated successfully.....";

            }
            catch (Exception)
            {
                s = "data is not updated !!!";

            }

            finally
            {
                conn.Close();
            }

            return s;

        } //method end...........


        public string delete_loginmethod(employees emp)
        {
            string s = "";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("delete_employee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = emp.emp_id;

                conn.Open();
                cmd.ExecuteNonQuery();


                s = "DATA record has been delete successfully.....";

            }
            catch (Exception)
            {
                s = "data is not delete!!!";

            }

            finally
            {
                conn.Close();
            }

            return s;

        } //method end...........

        
        public employees getallemployeesbyid(int id)
        {
            employees emp = new employees();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from employees where empid="+id, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            emp.emp_id=int.Parse(rdr["empid"].ToString());
            emp.emp_name = rdr["emp_name"].ToString();
            emp.emp_email = rdr["emp_email"].ToString();

            return emp;
        }



    }
}