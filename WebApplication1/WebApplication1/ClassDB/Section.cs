using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public class Section
{
    private string Connectionstring = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();

    public int AddSection(string Name, int CollegeID)
    {
        string Query = "INSERT INTO Section( Name, CollegeID)VALUES(@Name,@CollegeID) ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@Name", Name);//This is Parameter
        Command.Parameters.AddWithValue("@CollegeID", CollegeID);

        int x = Command.ExecuteNonQuery();
        Connection.Close();
        return x;
    }
    public void UpdateSection(int ID, string Name, int CollegeID)
    {
        string Query = "Update Section set Name=@Name, CollegeID=@CollegeID where ID = @ID";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);//This is Parameter
        Command.Parameters.AddWithValue("@Name", Name);//This is Parameter
        Command.Parameters.AddWithValue("@CollegeID", CollegeID);

        Command.ExecuteNonQuery();
        Connection.Close();
    }


    public void DeleteSection(int ID)
    {
        string Query = "delete from Section where ID = @ID  ";
        SqlConnection Connection = new SqlConnection(Connectionstring);
        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.CommandType = CommandType.Text;
        Command.Parameters.AddWithValue("@ID", ID);
        Command.ExecuteNonQuery();
        Connection.Close();
    }
}