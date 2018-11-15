using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public class AbsenceExam
{
    private string Connectionstring = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();


    public int AddAbsenceExam(int StudentID, int Subject1, string Date1, int Subject2, string Date2, int Subject3, string Date3, int Subject4, string Date4, int Subject5, string Date5, string Description, string Attachment1, string Attachment2, int ApplicationID)
    {
        string Query = "INSERT INTO AbsenceExam(StudentID  ,  Subject1 , Date1 , Subject2 ,  Date2 ,  Subject3 ,  Date3 ,  Subject4 , Date4, Subject5,  Date5, Description, Attachment1, Attachment2, ApplicationID )VALUES(@StudentID  ,  @Subject1 , @Date1 , @Subject2 ,  @Date2 ,  @Subject3 ,  @Date3 ,  @Subject4 , @Date4, @Subject5,  @Date5, @Description, @Attachment1, @Attachment2, @ApplicationID) ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@StudentID", StudentID);//This is Parameter
        Command.Parameters.AddWithValue("@Subject1", Subject1);
        Command.Parameters.AddWithValue("@Date1", Date1);
        Command.Parameters.AddWithValue("@Subject2", Subject2);
        Command.Parameters.AddWithValue("@Date2", Date2);
        Command.Parameters.AddWithValue("@Subject3", Subject3);
        Command.Parameters.AddWithValue("@Date3", Date3);
        Command.Parameters.AddWithValue("@Subject4", Subject4);//This is Parameter
        Command.Parameters.AddWithValue("@Date4", Date4);
        Command.Parameters.AddWithValue("@Subject5", Subject5);
        Command.Parameters.AddWithValue("@Date5", Date5);
        Command.Parameters.AddWithValue("@Description", Description);
        Command.Parameters.AddWithValue("@Attachment1", Attachment1);
        Command.Parameters.AddWithValue("@Attachment2", Attachment2);
        Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }






    public void UpdateAbsenceExam(int ID, int StudentID, int Subject1, string Date1, int Subject2, string Date2, int Subject3, string Date3, int Subject4, string Date4, int Subject5, string Date5, string Description, string Attachment1, string Attachment2, int ApplicationID)
    {
        string Query = "Update  AbsenceExam set StudentID = @StudentID ,Subject1 = @Subject1  , Date1= @Date1 ,Subject2 = @Subject2 ,Date2 =@Date2,Subject3 = @Subject3  , Date3= @Date3 ,Subject4 = @Subject4 ,Date4 =@Date4 ,Subject5 = @Subject5 ,Date5 =@Date5,Description = @Description  , Attachment1= @Attachment1 ,Attachment2 = @Attachment2 ,ApplicationID =@ApplicationID where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.Parameters.AddWithValue("@StudentID", StudentID);//This is Parameter
        Command.Parameters.AddWithValue("@Subject1", Subject1);
        Command.Parameters.AddWithValue("@Date1", Date1);
        Command.Parameters.AddWithValue("@Subject2", Subject2);
        Command.Parameters.AddWithValue("@Date2", Date2);
        Command.Parameters.AddWithValue("@Subject3", Subject3);
        Command.Parameters.AddWithValue("@Date3", Date3);
        Command.Parameters.AddWithValue("@Subject4", Subject4);
        Command.Parameters.AddWithValue("@Date4", Date4);
        Command.Parameters.AddWithValue("@Subject5", Subject5);
        Command.Parameters.AddWithValue("@Date5", Date5);
        Command.Parameters.AddWithValue("@Description", Description);
        Command.Parameters.AddWithValue("@Attachment1", Attachment1);
        Command.Parameters.AddWithValue("@Attachment2 ", Attachment2);
        Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


        Command.ExecuteNonQuery();
        Connection.Close();
    }

    public void DeleteAbsenceExam(int ID)
    {
        string Query = "delete from  AbsenceExam where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.ExecuteNonQuery();
        Connection.Close();
    }

    public int AcceptAbsenceExam(int ID)
    {
        string Query = "Update  AbsenceExam set DeanAccept =1 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }

    public int NotAcceptAbsenceExam(int ID)
    {
        string Query = "Update  AbsenceExam set DeanAccept =2 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }

    public DataTable dtNotAcceptApsenceApplication()
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from AbsenceExam,Subjects where AbsenceExam.Subject1 =Subjects.SubjectID  and (DeanAccept = 0 OR DeanAccept IS null ) ", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;

    }

}