﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public class PullCourseClass
{
    private string Connectionstring = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();

    public int AddPullCourse(int StudentID, int Subject1ID, int Subject2ID, int Subject3ID, string Date, string Description, string Course1time,string Course2time,string Course3time,int NumHourRegester, int NumAfterPull, string HeadDescription, string HeadDate, int HeadAccept, string DeanDescription, string DeanDate, int DeanAccept, int RegestrationAccept, int ApplicationID)
    {
        string Query = "INSERT INTO PullCourse(StudentID,Subject1ID,Subject2ID,Subject3ID,Date ,Description,Course1time,Course2time,Course3time,NumHourRegester,NumAfterPull, HeadDescription, HeadDate,HeadAccept,DeanDescription,DeanDate, DeanAccept, RegestrationAccept, ApplicationID)VALUES(@StudentID,@Subject1ID,@Subject2ID,@Subject3ID,@Date ,@Description,@Course1time,@Course2time,@Course2time,@NumHourRegester,@NumAfterPull,@HeadDescription,@HeadDate,@HeadAccept,@DeanDescription,@DeanDate,@DeanAccept,@RegestrationAccept,@ApplicationID) ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@StudentID", StudentID);//This is Paramete
        Command.Parameters.AddWithValue("@Subject1ID", Subject1ID);
        Command.Parameters.AddWithValue("@Subject2ID", Subject2ID);
        Command.Parameters.AddWithValue("@Subject3ID", Subject3ID);
        Command.Parameters.AddWithValue("@Date", Date);
        Command.Parameters.AddWithValue("@Description", Description);
        Command.Parameters.AddWithValue("@Course1time", Course1time);
        Command.Parameters.AddWithValue("@Course2time", Course2time);
        Command.Parameters.AddWithValue("@Course3time", Course3time);

        Command.Parameters.AddWithValue("@NumHourRegester", NumHourRegester);
        Command.Parameters.AddWithValue("@NumAfterPull", NumAfterPull);

        Command.Parameters.AddWithValue("@HeadDescription", HeadDescription);
        Command.Parameters.AddWithValue("@HeadDate", HeadDate);
        Command.Parameters.AddWithValue("@HeadAccept", HeadAccept);
        Command.Parameters.AddWithValue("@DeanDescription", DeanDescription);
        Command.Parameters.AddWithValue("@DeanDate", DeanDate);
        Command.Parameters.AddWithValue("@DeanAccept", DeanDate);
        Command.Parameters.AddWithValue("@RegestrationAccept", RegestrationAccept);
        Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }
    public int  UpdatePullCourse(int ID, int StudentID, int Subject1ID, int Subject2ID, int Subject3ID, string Date, string Description, string Course1time, string Course2time, string Course3time, int NumHourRegester, int NumAfterPull, string HeadDescription, string HeadDate, int HeadAccept, string DeanDescription, string DeanDate, int DeanAccept, int RegestrationAccept, int ApplicationID)
    {
        string Query = "Update PullCours set StudentID=@StudentID,Subject1ID=@Subject1ID,Subject2ID=@Subject2ID,Subject3ID=@Subject3ID,Date=@Date ,Description=@Description,Course1time=@Course1time, Course2time=@Course2time,Course3time=@Course3time,NumHourRegester=@NumHourRegester,NumAfterPull=@NumAfterPull, HeadDescription=@HeadDescription, HeadDate=@HeadDate,HeadAccept=@HeadAccept,DeanDescription=@DeanDescription,DeanDate=@DeanDate, DeanAccept=@DeanAccept, RegestrationAccept=@RegestrationAccept, ApplicationID=@ApplicationID where ID = @ID";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.Parameters.AddWithValue("@StudentID", StudentID);//This is Parameter
        Command.Parameters.AddWithValue("@Subject1ID", Subject1ID);
        Command.Parameters.AddWithValue("@Subject2ID", Subject2ID);
        Command.Parameters.AddWithValue("@Subject3ID", Subject3ID);
        Command.Parameters.AddWithValue("@Date", Date);
        Command.Parameters.AddWithValue("@Description", Description);
        Command.Parameters.AddWithValue("@Course1time", Course1time);
        Command.Parameters.AddWithValue("@Course2time", Course2time);
        Command.Parameters.AddWithValue("@Course3time", Course3time);

        Command.Parameters.AddWithValue("@NumHourRegester", NumHourRegester);
        Command.Parameters.AddWithValue("@NumAfterPull", NumAfterPull);
        Command.Parameters.AddWithValue("@HeadDescription", HeadDescription);
        Command.Parameters.AddWithValue("@HeadDate", HeadDate);
        Command.Parameters.AddWithValue("@HeadAccept", HeadAccept);
        Command.Parameters.AddWithValue("@DeanDescription", DeanDescription);
        Command.Parameters.AddWithValue("@DeanDate", DeanDate);
        Command.Parameters.AddWithValue("@RegestrationAccept", RegestrationAccept);
        Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

       int x=Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }

    public void DeletePullCourse(int ID)
    {
        string Query = "delete from PullCourse where ID = @ID  ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.ExecuteNonQuery();
        Connection.Close();
    }

    public int DeletePullCourseSelected(int ID)
    {
        string Query = "delete from PullCourse where RegestrationAccept=0 and ID = "+ID;
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }


    /// Head getData Application
    public DataTable dtViewStudents( int ID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from PullCourse where StudentID= "+ID, Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;
    }


    public DataTable dtNotPullCourseHeadApplication()
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from PullCourse,Subjects where PullCourse.Subject1ID =Subjects.SubjectID  and (HeadAccept=0 OR HeadAccept IS null)", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;
    }
    public int AcceptHeadPullCourse(int ID)
    {
        string Query = "Update  PullCourse set HeadAccept =1 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }

    public int NotAcceptHeadPullCourse(int ID)
    {
        string Query = "Update  PullCourse set HeadAccept =2 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }

    /// Regestration getData Application
    public DataTable dtNotPullCourseRegApplication()
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from PullCourse,Subjects where PullCourse.Subject1ID =Subjects.SubjectID  and DeanAccept<>0 and DeanAccept IS not null and (RegestrationAccept=0 OR RegestrationAccept IS null)", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;
    }

    public int AcceptRegPullCourse(int ID)
    {
        string Query = "Update  PullCourse set RegestrationAccept =1 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }

    public int NotAcceptRegPullCourse(int ID)
    {
        string Query = "Update  PullCourse set RegestrationAccept =2 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }


    // Dean getData Application

    public DataTable dtNotAcceptDeanPullCourseApplication()
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from PullCourse,Subjects where PullCourse.Subject1ID =Subjects.SubjectID  and  HeadAccept<>0 and HeadAccept IS not Null and (DeanAccept = 0 OR DeanAccept IS null)", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;


    }
    public int AcceptDeanPullCourse(int ID)
    {
        string Query = "Update  PullCourse set DeanAccept =1 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }

    public int NotAcceptDeanPullCourse(int ID)
    {
        string Query = "Update  PullCourse set DeanAccept =2 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }


    public DataTable dteditform(int ID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from PullCourse where HeadAccept=0 and ID="+ID, Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }


    public DataRow dreditform(int ID)
    {
        DataRow dr;
        DataTable dt = dteditform(ID);
        if (dt.Rows.Count > 0)
        {
            dr = dt.Rows[0];

          
        }
        else
        {
            dr = null;
        }
        return dr;

    }

    public DataTable dtgetform(int ID)
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from PullCourse where ID=" + ID, Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }


    public DataRow drgetform(int ID)
    {
        DataRow dr;
        DataTable dt = dtgetform(ID);
        if (dt.Rows.Count > 0)
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
