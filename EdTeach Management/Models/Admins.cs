using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Models
{
    public class Admins
    {




        public Admin GetData1(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Admin obj = new Admin();
            using (reader)
            {
                while (reader.Read())
                {
                    obj.Id = reader.GetString(0);
                    obj.Name = reader.GetString(1);
                    obj.Email = reader.GetString(2);
                    obj.Phone = reader.GetString(3);
                    obj.Address = reader.GetString(4);
                    obj.Status = reader.GetString(5);

                }
                reader.Close();
            }
            cmd.Connection.Close();
            return obj;
        }



        public Admin GetAdmin(string id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from admin WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            Admin admin = new Admin();
            admin = GetData1(cmd);

            return admin;


        }




        public void UpdateAdmin(String Id, string email, string Phoneno, string address)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE admin SET email=@email,phone=@Phoneno,address=@address WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@Phoneno", Phoneno);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }
    }
}
