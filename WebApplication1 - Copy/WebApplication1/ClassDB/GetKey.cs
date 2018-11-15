using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class GetKey
    {
        private string Connectionstring = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();

        public void AddKeyStudent(string Signature,int ID)
        {
            string Query = "Update Students set Signature=@Signature where ID = @ID  ";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@Signature", Signature);//This is Parameter
           
            Command.ExecuteNonQuery();
            Connection.Close();
        }
        public void AddKeyEmployee(string Signature, int ID)
        {
            string Query = "Update Employee set Signature=@Signature where ID = @ID  ";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@Signature", Signature);//This is Parameter
            Command.ExecuteNonQuery();
            Connection.Close();
        }

        public DataTable dtSearchStudentKey(int ID)
        {
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter("select Signature from Students where ID =" + ID + "", Connection);
            DA.Fill(dt);
            Connection.Close();
            return dt;

        }


        public DataRow drSearchStudentKey(int ID)
        {
            DataRow dr;
            DataTable dt = dtSearchStudentKey(ID);
            if (dt != null)
            {

                dr = dt.Rows[0];
            }
            else
            {
                dr = null;
            }
            return dr;

        }



        public DataTable dtSearchEmployeeKey(int ID)
        {
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter("select Signature  from Employee where ID =" + ID + "", Connection);
            DA.Fill(dt);
            Connection.Close();
            return dt;

        }


        public DataRow drSearchEmployeeKey(int ID)
        {
            DataRow dr;
            DataTable dt = dtSearchEmployeeKey(ID);
            if (dt != null)
            {

                dr = dt.Rows[0];
            }
            else
            {
                dr = null;
            }
            return dr;

        }




    }
}