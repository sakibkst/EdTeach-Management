using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Models
{
    public class Logins
    {
        public Login getUser(string userId, string password)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from login WHERE id= '" + userId + "' and password='" + password + "'");
            Login user = new Login();
            user = GetData(cmd);
            return user;

        }

        Login GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Login obj = new Login();
            using (reader)
            {
                while (reader.Read())
                {
                    obj.Id = reader.GetString(0);
                    obj.Password = reader.GetString(1);
                    obj.Role = reader.GetString(2);
                    obj.Answer = reader.GetString(3);
                    obj.Status = reader.GetString(4);

                }
                reader.Close();
            }
            cmd.Connection.Close();
            return obj;
        }




        public void InsertUser(Login user)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO login VALUES(@id,@password,@role,@answer,@status)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Parameters.AddWithValue("@answer", user.Answer);
            cmd.Parameters.AddWithValue("@status", user.Status);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void DeleteUser(string userId)
        {

            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE login SET status=@status WHERE id=@userid");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userid", userId);
            cmd.Parameters.AddWithValue("@status", "inactive");
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }


        public Login FindUser(string userid, string security)
        {

            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from login WHERE id='" + userid + "' and answer='" + security + "'");
            Login user = new Login();
            user = GetData(cmd);
            return user;



        }

        public void Update_Password(string user_id, string password)
        {

            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE login SET password=@password  WHERE id=@user_id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@user_id", user_id);
            cmd.Connection.Open();


            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }


    }

}
