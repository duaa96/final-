using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public class DropSemester
{
    private string Connectionstring = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();


    public int AddDropSemester(int StudentID, string Description, string Date, string AcademicAdvisor_Descr, int AcademicAdvisorAccept, string HeadDescription, int HeadAccept, string DeanDescription, int DeanAccept, string DeputyAcademic_Descr, int DeputyAcademicAccept, string RegestrationDescr, int ApplicationID)
    {
        string Query = "INSERT INTO DropSemester (  StudentID,Description, Date, AcademicAdvisor_Descr, AcademicAdvisorAccept, HeadDescription, HeadAccept, DeanDescription, DeanAccept, DeputyAcademic_Descr, DeputyAcademicAccept, RegestrationDescr, ApplicationID) VALUES( @StudentID,@Description, @Date,@AcademicAdvisor_Descr, @AcademicAdvisorAccept, @HeadDescription, @HeadAccept, @DeanDescription, @DeanAccept, @DeputyAcademic_Descr, @DeputyAcademicAccept, @RegestrationDescr, @ApplicationID  ) ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@StudentID", StudentID);//This is Parameter
        Command.Parameters.AddWithValue("@Date", Date);//This is Parameter
        Command.Parameters.AddWithValue("@Description", Description);//This is Parameter
        Command.Parameters.AddWithValue("@AcademicAdvisor_Descr", AcademicAdvisor_Descr);//This is Parameter
        Command.Parameters.AddWithValue("@AcademicAdvisorAccept", AcademicAdvisorAccept);//This is Parameter
        Command.Parameters.AddWithValue("@HeadDescription", HeadDescription);//This is Parameter
        Command.Parameters.AddWithValue("@HeadAccept", HeadAccept);//This is Parameter
        Command.Parameters.AddWithValue("@DeanDescription", DeanDescription);//This is Parameter
        Command.Parameters.AddWithValue("@DeanAccept", DeanAccept);//This is Parameter
        Command.Parameters.AddWithValue("@DeputyAcademic_Descr", DeputyAcademic_Descr);//This is Parameter
        Command.Parameters.AddWithValue("@DeputyAcademicAccept", DeputyAcademicAccept);//This is Parameter
        Command.Parameters.AddWithValue("@RegestrationDescr", RegestrationDescr);//This is Parameter
        Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);//This is Parameter

        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }
    public void UpdateDropSemester(int ID, int StudentID, string Description, string Date, string AcademicAdvisor_Descr, int AcademicAdvisorAccept, string HeadDescription, int HeadAccept, string DeanDescription, int DeanAccept, string DeputyAcademic_Descr, int DeputyAcademicAccept, string RegestrationDescr, int ApplicationID)
    {
        string Query = "Update  DropSemester set  Position =@Position   where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.Parameters.AddWithValue("@StudentID", StudentID);//This is Parameter
        Command.Parameters.AddWithValue("@Description", Description);//This is Parameter
        Command.Parameters.AddWithValue("@AcademicAdvisor_Descr", AcademicAdvisor_Descr);//This is Parameter
        Command.Parameters.AddWithValue("@AcademicAdvisorAccept", AcademicAdvisorAccept);//This is Parameter
        Command.Parameters.AddWithValue("@HeadDescription", HeadDescription);//This is Parameter
        Command.Parameters.AddWithValue("@HeadAccept", HeadAccept);//This is Parameter
        Command.Parameters.AddWithValue("@DeanDescription", DeanDescription);//This is Parameter
        Command.Parameters.AddWithValue("@DeanAccept", DeanAccept);//This is Parameter
        Command.Parameters.AddWithValue("@DeputyAcademic_Descr", DeputyAcademic_Descr);//This is Parameter
        Command.Parameters.AddWithValue("@DeputyAcademicAccept", DeputyAcademicAccept);//This is Parameter
        Command.Parameters.AddWithValue("@RegestrationDescr", RegestrationDescr);//This is Parameter
        Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);//This is Parameter



        Command.ExecuteNonQuery();
        Connection.Close();
    }
    public void DeleteDropSemester(int ID)
    {
        string Query = "delete from  DropSemester where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.ExecuteNonQuery();
        Connection.Close();
    }

    // Head get data Application
    public DataTable dtNotAcceptDropSemesterHeadApplication()
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from DropSemester where  AcademicAdvisorAccept <> 0 AND AcademicAdvisorAccept IS NOT null AND (HeadAccept = 0 OR HeadAccept IS null)", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;
    }


    public int AcceptHeadDropSemester(int ID)
    {
        string Query = "Update  DropSemester set HeadAccept =1 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }

    public int NotAcceptHeadDropSemester(int ID)
    {
        string Query = "Update  DropSemester set HeadAccept =2 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }

    //Regestration GetData Application 
    public DataTable dtNotAcceptDropSemesterRegApplication()
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from DropSemester where  DeputyAcademicAccept <> 0 AND DeputyAcademicAccept IS NOT null AND (RegestrationDescr = 0 OR RegestrationDescr IS null)", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;
    }


    public int AcceptRegDropSemester(int ID)
    {
        string Query = "Update  DropSemester set RegestrationDescr =1 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }

    public int NotAcceptRegDropSemester(int ID)
    {
        string Query = "Update  DropSemester set RegestrationDescr =2 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }



    //DeputyAcademic GetData Application 
    public DataTable dtNotAcceptDropSemesterDeputyAcademicApplication()
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from DropSemester where  DeanAccept <> 0 AND DeanAccept IS NOT null AND (DeputyAcademicAccept = 0 OR DeputyAcademicAccept IS null)", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;
    }


    public int AcceptDeputyAcademicDropSemester(int ID)
    {
        string Query = "Update  DropSemester set DeputyAcademicAccept =1 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }

    public int NotAcceptDeputyAcademicDropSemester(int ID)
    {
        string Query = "Update  DropSemester set DeputyAcademicAccept =2 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }




    //AcademicAdvisorAccept GetData Application 
    public DataTable dtNotAcceptDropSemesterAcademicAdvisorApplication()
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from DropSemester where  (AcademicAdvisorAccept = 0 OR AcademicAdvisorAccept IS null)", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;
    }


    public int AcceptAcademicAdvisorDropSemester(int ID)
    {
        string Query = "Update  DropSemester set AcademicAdvisorAccept =1 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }

    public int NotAcceptAcademicAdvisorDropSemester(int ID)
    {
        string Query = "Update  DropSemester set AcademicAdvisorAccept =2 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }



    //Dean get Data Application
    public DataTable dtNotAcceptDropSemesterDeanApplication()
    {
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter("select * from DropSemester where  HeadAccept<>0 and HeadAccept IS not Null and (DeanAccept = 0 OR DeanAccept IS null)", Connection);
        DA.Fill(dt);
        Connection.Close();
        return dt;
    }

    public int AcceptDeanDropSemester(int ID)
    {
        string Query = "Update  DropSemester set DeanAccept =1 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }

    public int NotAcceptDeanDropSemester(int ID)
    {
        string Query = "Update  DropSemester set DeanAccept =2 where ID = @ID ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        Connection.Open();
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }

}