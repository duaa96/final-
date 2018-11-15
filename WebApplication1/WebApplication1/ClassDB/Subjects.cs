using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public class Subjects
{
    private string Connectionstring = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();


    public int AddSubjects(int SubjectID, string SubjectName, int SectionID, string Type, int Hours)
    {
        string Query = "INSERT INTO Subjects(SubjectID,SubjectName  , SectionID ,Type ,Hours )VALUES(@SubjectID,@SubjectName, @SectionID,@Type ,@Hours) ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@SubjectID", SubjectID);//This is Parameter
        Command.Parameters.AddWithValue("@SubjectName", SubjectName);
        Command.Parameters.AddWithValue("@SectionID", SectionID);
        Command.Parameters.AddWithValue("@Type", Type);
        Command.Parameters.AddWithValue("@Hours", Hours);
       int x= Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }


    public void UpdateSubjects(int ID, int SubjectID, string SubjectName, int SectionID, string Type, int Hours)
    {
        string Query = "Update  Subjects set SubjectID = @SubjectID ,SubjectName = @SubjectName  , SectionID= @SectionID ,Type = @Type ,Hours =@Hours where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.Parameters.AddWithValue("@SubjectID", SubjectID);//This is Parameter
        Command.Parameters.AddWithValue("@SubjectName", SubjectName);
        Command.Parameters.AddWithValue("@SectionID", SectionID);
        Command.Parameters.AddWithValue("@Type", Type);
        Command.Parameters.AddWithValue("@Hours", Hours);
        Command.ExecuteNonQuery();
        Connection.Close();
    }

    public void DeleteSubjects(int ID)
    {
        string Query = "delete from  Subjects where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.ExecuteNonQuery();
        Connection.Close();
    }

    public DataTable dtSearchStudentSubjectNotRegester (int ID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select DISTINCT Subjects.SubjectID,SubjectName,Hours from Subjects,RegistredCourses Where Subjects.SubjectID<>RegistredCourses.SubjectID and Subjects.SubjectID NOT IN (select RegistredCourses.SubjectID from RegistredCourses Where StudentsID=" + ID+")", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }


    public DataTable dtSearchStudentSubjectTypAndHours(int SubjectID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select Type ,Hours From Subjects WHERE SubjectID="+ SubjectID +"",Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }
    public DataRow drSearchStudentSubjectTypAndHours( int SubjectID)
    {
        DataTable dt = null;
        DataRow dr = null;
         dt = dtSearchStudentSubjectTypAndHours(SubjectID);
        if (dt != null)
        {
            int xount = Convert.ToUInt16(dt.Rows.Count.ToString());
            dr = dt.Rows[0];
        }
        else
        {
            dr = null;
        }
        return dr;

    }

    public DataTable dtSearchSubjectName(int SubjectID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select SubjectName From Subjects WHERE SubjectID=" + SubjectID + "", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }
}