using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class AlternativeSub
    {

        private string Connectionstring = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();

        public int AddAlternativeSubject(int StudentID, int Subject1ID, string Subject2Type, int NewSubject, string Description, int AcademicAdvisorAccept, int HeadAccept, int DeanAccept, int RegestrationAccept, int ApplicationID)
        {
            string Query = "INSERT INTO AlternativeSubject( StudentID , Subject1ID , Subject2Type ,NewSubject ,Description , AcademicAdvisorAccept ,  HeadAccept , DeanAccept,RegestrationAccept, ApplicationID )VALUES(@StudentID  ,  @Subject1ID , @Subject2Type , @NewSubject ,  @Description ,  @AcademicAdvisorAccept ,  @HeadAccept, @DeanAccept,@RegestrationAccept, @ApplicationID ) ";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@StudentID", StudentID);//This is Parameter
            Command.Parameters.AddWithValue("@Subject1ID", Subject1ID);
            Command.Parameters.AddWithValue("@Subject2Type", Subject2Type);
            Command.Parameters.AddWithValue("@NewSubject", NewSubject);
            Command.Parameters.AddWithValue("@Description", Description);
            Command.Parameters.AddWithValue("@AcademicAdvisorAccept", AcademicAdvisorAccept);
            Command.Parameters.AddWithValue("@HeadAccept", HeadAccept);
            Command.Parameters.AddWithValue("@DeanAccept", DeanAccept);//This is Parameter
            Command.Parameters.AddWithValue("@RegestrationAccept", RegestrationAccept);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            int x = Command.ExecuteNonQuery();
            Connection.Close();
            return x;
        }




        public void UpdateAlternativeSubject(int ID, int StudentID, int Subject1ID, string Subject2Type, int NewSubject, string Description, int AcademicAdvisorAccept, int HeadAccept, int DeanAccept, int RegestrationAccept, int ApplicationID)
        {
            string Query = "Update  AlternativeSubject  set StudentID = @StudentID ,Subject1ID = @Subject1ID  , Subject2Type= @Subject2Type ,NewSubject = @NewSubject ,Description =@Description ,AcademicAdvisorAccept =@AcademicAdvisorAccept ,HeadAccept = @HeadAccept ,DeanAccept =@DeanAccept ,RegestrationAccept =@RegestrationAccept,ApplicationID =@ApplicationID where ID = @ID ";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@StudentID", StudentID);
            Command.Parameters.AddWithValue("@Subject1ID", Subject1ID);//This is Parameter
            Command.Parameters.AddWithValue("@Subject2Type", Subject2Type);
            Command.Parameters.AddWithValue("@NewSubject", NewSubject);

            Command.Parameters.AddWithValue("@Description", Description);
            Command.Parameters.AddWithValue("@AcademicAdvisorAccept", AcademicAdvisorAccept);
            Command.Parameters.AddWithValue("@HeadAccept", HeadAccept);
            Command.Parameters.AddWithValue("@DeanAccept", DeanAccept);
            Command.Parameters.AddWithValue("@RegestrationAccept", RegestrationAccept);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.ExecuteNonQuery();
            Connection.Close();
        }
        public void DeleteAlternativeSubject(int ID)
        {
            string Query = "delete from  AlternativeSubject where ID = @ID ";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@ID", ID);
            Command.ExecuteNonQuery();
            Connection.Close();
        }


        ///  Head get data Application
        public DataTable dtNotAcceptAliSubHeadApplication()
        {
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter("select * from AlternativeSubject,Subjects where AlternativeSubject.Subject1ID =Subjects.SubjectID  and AcademicAdvisorAccept <> 0 AND AcademicAdvisorAccept IS NOT null and (HeadAccept=0 OR HeadAccept IS null)", Connection);
            DA.Fill(dt);
            Connection.Close();
            return dt;
        }


        public int AcceptHeadAltiSubj(int ID)
        {
            string Query = "Update  AlternativeSubject set HeadAccept =1 where ID = @ID ";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@ID", ID);
            int x = Command.ExecuteNonQuery();
            Connection.Close();
            return x;
        }

        public int NotAcceptHeadAltiSubj(int ID)
        {
            string Query = "Update  AlternativeSubject set HeadAccept =2 where ID = @ID ";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@ID", ID);
            int x = Command.ExecuteNonQuery();
            Connection.Close();
            return x;
        }

        // Regestration get data Application

        public DataTable dtNotAcceptAliSubRegApplication()
        {
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter("select * from AlternativeSubject,Subjects where AlternativeSubject.Subject1ID =Subjects.SubjectID  and DeanAccept <> 0 AND DeanAccept IS NOT null and (RegestrationAccept=0 OR RegestrationAccept IS null)", Connection);
            DA.Fill(dt);
            Connection.Close();
            return dt;
        }


        public int AcceptRegAltiSubj(int ID)
        {
            string Query = "Update  AlternativeSubject set RegestrationAccept =1 where ID = @ID ";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@ID", ID);
            int x = Command.ExecuteNonQuery();
            Connection.Close();
            return x;
        }

        public int NotAcceptRegAltiSubj(int ID)
        {
            string Query = "Update  AlternativeSubject set RegestrationAccept =2 where ID = @ID ";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@ID", ID);
            int x = Command.ExecuteNonQuery();
            Connection.Close();
            return x;
        }




        ///  AcademicAdvisor get data Application
        public DataTable dtNotAcceptAliSubAcademicAdvisorApplication()
        {
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter("select * from AlternativeSubject,Subjects where AlternativeSubject.Subject1ID =Subjects.SubjectID  and (AcademicAdvisorAccept=0 OR AcademicAdvisorAccept IS null)", Connection);
            DA.Fill(dt);
            Connection.Close();
            return dt;
        }


        public int AcceptAcademicAdvisorAltiSubj(int ID)
        {
            string Query = "Update  AlternativeSubject set AcademicAdvisorAccept =1 where ID = @ID ";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@ID", ID);
            int x = Command.ExecuteNonQuery();
            Connection.Close();
            return x;
        }

        public int NotAcceptAcademicAdvisorAltiSubj(int ID)
        {
            string Query = "Update  AlternativeSubject set AcademicAdvisorAccept =2 where ID = @ID ";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@ID", ID);
            int x = Command.ExecuteNonQuery();
            Connection.Close();
            return x;
        }



        //Dean get data Application
        public DataTable dtNotAcceptAliSubDeanApplication()
        {
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter("select * from AlternativeSubject,Subjects where AlternativeSubject.Subject1ID =Subjects.SubjectID  and HeadAccept <> 0 AND HeadAccept IS NOT null and (DeanAccept=0 OR DeanAccept IS null)", Connection);
            DA.Fill(dt);
            Connection.Close();
            return dt;
        }

        public int AcceptDeanAltiSubj(int ID)
        {
            string Query = "Update  AlternativeSubject set DeanAccept =1 where ID = @ID ";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            Connection.Open();

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.CommandType = CommandType.Text;
            Command.Parameters.AddWithValue("@ID", ID);
            int x = Command.ExecuteNonQuery();
            Connection.Close();
            return x;
        }

        public int NotAcceptDeanAltiSubj(int ID)
        {
            string Query = "Update  AlternativeSubject set DeanAccept =2 where ID = @ID ";
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


}