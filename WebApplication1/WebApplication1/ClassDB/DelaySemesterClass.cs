using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public class DelaySemesterClass
{
    private string Connectionstring = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();

    public int  AddDelaySemester(int StudentID, string Year, string Semester, string Description, string Date, string RegestrationDescr,int RegestrationAccept, string RegestrationDate, string DeanDescription,int DeanAccept, string Decision, int ApplicationID)
    {
        string Query = "INSERT INTO DelaySemester(StudentID  ,Year , Semester ,  Description ,  Date ,   RegestrationDescr , RegestrationAccept, RegestrationDate ,   DeanDescription ,DeanAccept, Decision, ApplicationID )VALUES(@StudentID ,  @Year , @Semester , @Description ,  @Date ,  @RegestrationDescr ,@RegestrationAccept,  @RegestrationDate ,  @DeanDescription ,@DeanAccept, @Decision, @ApplicationID) ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@StudentID", StudentID);//This is Parameter
        Command.Parameters.AddWithValue("@Year", Year);
        Command.Parameters.AddWithValue("@Semester", Semester);
        Command.Parameters.AddWithValue("@Description", Description);
        Command.Parameters.AddWithValue("@Date", Date);
        Command.Parameters.AddWithValue("@RegestrationDescr", RegestrationDescr);
        Command.Parameters.AddWithValue("@RegestrationAccept", RegestrationAccept);

        Command.Parameters.AddWithValue("@RegestrationDate", RegestrationDate);

        Command.Parameters.AddWithValue("@DeanDescription", DeanDescription);
        Command.Parameters.AddWithValue("@DeanAccept", DeanAccept);

        Command.Parameters.AddWithValue("@Decision", Decision);
        Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


        int x=Command.ExecuteNonQuery();
        Connection.Close();
        return x;

    }




    public void UpdateDelaySemester(int ID, int StudentID, string Year, string Semester, string Description, string Date, string RegestrationDescr, string RegestrationDate, string DeanDescription, string Decision, int ApplicationID)

    {
        string Query = "Update  DelaySemester set  StudentID=@StudentID ,Year =@Year ,Semester=@Semester ,Description =@Description,Date=@Date ,RegestrationDescr =@RegestrationDescr,DeanDescription=@DeanDescription ,Decision =@Decision,ApplicationID=@ApplicationID   where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.Parameters.AddWithValue("@StudentID", StudentID);//This is Parameter
        Command.Parameters.AddWithValue("@Year", Year);
        Command.Parameters.AddWithValue("@Semester", Semester);
        Command.Parameters.AddWithValue("@Description", Description);
        Command.Parameters.AddWithValue("@Date", Date);
        Command.Parameters.AddWithValue("@RegestrationDescr", RegestrationDescr);
        Command.Parameters.AddWithValue("@RegestrationDate", RegestrationDate);

        Command.Parameters.AddWithValue("@DeanDescription", DeanDescription);
        Command.Parameters.AddWithValue("@Decision", Decision);
        Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);



        Command.ExecuteNonQuery();
        Connection.Close();
    }
    public void DeleteDelaySemester(int ID)
    {
        string Query = "delete from  DelaySemester where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.ExecuteNonQuery();
        Connection.Close();
    }






}