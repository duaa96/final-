using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public class Studnets
{
    private string Connectionstring = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();

    public int AddStudnets(string StudentName, int UniversityID, string Signature, string Password, string mager, int SectionID, string Phone, int AcademicAdvisorID)
    {
        string Query = "INSERT INTO Studnets( StudentName, UniversityID  , Signature ,Password , mager,SectionID,Phone,AcademicAdvisorID )VALUES(@StudentName, @UniversityID  , @Signature ,@Password , @mager,@SectionID,@Phone,@AcademicAdvisorID ) ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@StudentName", StudentName);//This is Parameter
        Command.Parameters.AddWithValue("@UniversityID", UniversityID);
        Command.Parameters.AddWithValue("@Signature", Signature);
        Command.Parameters.AddWithValue("@Password", Password);
        Command.Parameters.AddWithValue("@mager", mager);
        Command.Parameters.AddWithValue("@SectionID", SectionID);
        Command.Parameters.AddWithValue("@Phone", Phone);
        Command.Parameters.AddWithValue("@AcademicAdvisorID", AcademicAdvisorID);

        int x = Command.ExecuteNonQuery();
        Connection.Close();


        return x;
    }

    public void UpptadeStudnets(int ID, string StudentName, int UniversityID, string Signature, string Password, string mager, int SectionID, string Phone, int AcademicAdvisorID)
    {
        string Query = "Update Studnets set StudentName=@StudentName, UniversityID=@UniversityID, Signature=@Signature ,Password=@Password , mager=@mager,SectionID=@SectionID,Phone=@Phone,AcademicAdvisorID=@AcademicAdvisorID where ID = @ID  ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.Parameters.AddWithValue("@StudentName", StudentName);//This is Parameter
        Command.Parameters.AddWithValue("@UniversityID", UniversityID);
        Command.Parameters.AddWithValue("@Signature", Signature);
        Command.Parameters.AddWithValue("@Password", Password);
        Command.Parameters.AddWithValue("@mager", mager);
        Command.Parameters.AddWithValue("@SectionID", SectionID);
        Command.Parameters.AddWithValue("@Phone", Phone);
        Command.Parameters.AddWithValue("@AcademicAdvisorID", AcademicAdvisorID);
        Command.ExecuteNonQuery();
        Connection.Close();
    }

    public void DeleteStudnets(int ID)
    {
        string Query = "delete from Studnets where ID = @ID  ";
        SqlConnection Connection = new SqlConnection(Connectionstring);

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.ExecuteNonQuery();
        Connection.Close();
    }

    public DataTable dtSearchStudent(int ID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select College.Name as CollageName , Section.Name as SectionName , Students.StudentName as StudentName , Students.UniversityID as UniversityID,Students.mager as Mager from Students,College,Section where Section.ID = Students.SectionID and College.ID=  Section.CollegeID    and Students.ID =" + ID + "", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }


    public DataRow drSearchStudent(int ID)
    {
        DataRow dr;
        DataTable dt = dtSearchStudent(ID);
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


    public DataTable dtSearchStudentEmail(int ID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select Password , Email from Students Where Students.ID =" + ID + "", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }


    public DataRow drSearchStudentEmail(int ID)
    {
        DataRow dr;
        DataTable dt = dtSearchStudentEmail(ID);
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





















    public DataTable dtSearchStudentLogin(int username, string Password)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from Students where UniversityID='" + username + "' and Password='" + Password + "'",Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }


    public DataRow drSearchStudentLogin(int username , string Password)
    {
        DataRow dr;
        DataTable dt = dtSearchStudentLogin(username, Password);
        if (dt.Rows.Count>0 )
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

