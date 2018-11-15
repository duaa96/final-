using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public class RegistredCourses
{
    private string Connectionstring = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();

    public int AddRegistredCourses(int SubjectID, int StudentsID, int TeacherID, string Time, string Year, string Semester)
    {
        string Query = "INSERT INTO RegistredCourses( SubjectID,StudentsID,TeacherID,Time,Year,Semester)VALUES(@SubjectID,@StudentsID,@TeacherID,@Time,@Year,@Semester) ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@SubjectID", SubjectID);//This is Parameter
        Command.Parameters.AddWithValue("@StudentsID", StudentsID);
        Command.Parameters.AddWithValue("@TeacherID", TeacherID);
        Command.Parameters.AddWithValue("@Time", Time);
        Command.Parameters.AddWithValue("@Year", Year);
        Command.Parameters.AddWithValue("@Semester", Semester);

        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }




    public void UpdateRegistredCourses(int ID, int SubjectID, int StudentsID, int TeacherID, string Time, string Year, string Semester)
    {
        string Query = "Update RegistredCourses set  SubjectID=@SubjectID,StudentsID=@StudentsID,TeacherID=@TeacherID,Time=@Time,Year=@Year,Semester=@Semester where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.Parameters.AddWithValue("@SubjectID", SubjectID);//This is Parameter
        Command.Parameters.AddWithValue("@StudentsID", StudentsID);
        Command.Parameters.AddWithValue("@TeacherID", TeacherID);
        Command.Parameters.AddWithValue("@Time", Time);
        Command.Parameters.AddWithValue("@Year", Year);
        Command.Parameters.AddWithValue("@Semester", Semester);

        Command.ExecuteNonQuery();
        Connection.Close();
    }




    public void DeleteRegistredCourses(int ID)
    {

        string Query = "delete from RegistredCourses where ID = @ID  ";
        SqlConnection Connection = new SqlConnection(Connectionstring);

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.ExecuteNonQuery();
        Connection.Close();
    }
    public DataTable dtSearchRegisterSubject(int StudentsID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select*  from RegistredCourses,Subjects WHERE Subjects.SubjectID  = RegistredCourses.SubjectID AND StudentsID =" + StudentsID + "", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }


    public DataRow drSearchRegisterSubject(int ID)
    {
        DataRow dr;
        DataTable dt = dtSearchRegisterSubject(ID);
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
    public DataTable dtSearchRegisterSubjectTeacher(int StudentsID, int SubjectID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select*  from RegistredCourses,employees WHERE employees.ID  = RegistredCourses.TeacherID AND StudentsID =" + StudentsID + " and SubjectID = " + SubjectID + "", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }


    public DataRow drSearchRegisterSubjectTeacher(int StudentsID, int SubjectID)
    {
        DataRow dr = null;
        DataTable dt = dtSearchRegisterSubjectTeacher(StudentsID, SubjectID);
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

    public DataTable dtSearchNotRegisterSubject(int StudentsID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select Subjects.SubjectName ,S1.SubjectID ,Subjects.Type,Subjects.Hours from (select SubjectID From Subjects WHERE SubjectID IN(select Subjects.SubjectID From Subjects, Students, RegistredCourses WHERE  ID =" + StudentsID + "and Subjects.SectionID = Students.SectionID))AS S1, Subjects WHERE S1.SubjectID NOT IN(select SubjectID from RegistredCourses WHERE StudentsID =" + StudentsID + ")" + "AND S1.SubjectID = Subjects.SubjectID", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }
}