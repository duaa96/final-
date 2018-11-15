using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public class Application
{
    private string Connectionstring = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();


    public int AddApplication(string ApplicationName, int Enable, string ExpireDate)
    {
        string Query = "INSERT INTO Application(  ApplicationName  , Enable,ExpireDate )VALUES(@ApplicationName  ,  @Enable,@ExpireDate  ) ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ApplicationName", ApplicationName);//This is Parameter
        Command.Parameters.AddWithValue("@Enable", Enable);
        Command.Parameters.AddWithValue("@ExpireDate", ExpireDate);

        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }



    public void UpdateApplication(int ApplicationID, string ApplicationName, int Enable, string ExpireDate)
    {
        string Query = "Update  Application set  ApplicationName=@ApplicationName ,Enable =@Enable ,ExpireDate=@ExpireDate  where ApplicationID = @ApplicationID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
        Command.Parameters.AddWithValue("@ApplicationName", ApplicationName);
        Command.Parameters.AddWithValue("@Enable", Enable);//This is Parameter
        Command.Parameters.AddWithValue("@ExpireDate", ExpireDate);//This is Parameter

        Command.ExecuteNonQuery();
        Connection.Close();
    }
    public void DeleteApplication(int ApplicationID)
    {
        string Query = "delete from  Application where ApplicationID = @ApplicationID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
        Command.ExecuteNonQuery();
        Connection.Close();
    }

    public DataTable dtSearchApplication(DateTime Date1)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from Application where  ExpireDate >='" + Date1 + "'", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }

    public DataTable dtSearchMyApplication()
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from Application  ", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }





    public DataTable dtSearchMyAbsenceApplication(int StudentID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from AbsenceExam,Subjects where AbsenceExam.Subject1 =Subjects.SubjectID  and StudentID= " + StudentID + "", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }

    public DataTable dtSearchDropSemesterApplication(int StudentID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from DropSemester where StudentID= " + StudentID + "", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }

    public DataTable dtSearchAlternativeSubjectApplication(int StudentID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from AlternativeSubject,Subjects where AlternativeSubject.Subject1ID =Subjects.SubjectID and StudentID= " + StudentID + "", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }

    public DataTable dtSearchShowStatusApplication(int StudentID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from ShowStatus where  StudentID= " + StudentID + "", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }

    public DataTable dtSearchPullCourseApplication(int StudentID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from PullCourse,Subjects where  PullCourse.Subject1ID =Subjects.SubjectID and StudentID= " + StudentID + "", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }





    public DataTable dtNotAcceptAliSubDeanApplication()
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from AlternativeSubject,Subjects where AlternativeSubject.Subject1ID =Subjects.SubjectID  and HeadAccept=1 and DeanAccept <> 1", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;
    }

}




