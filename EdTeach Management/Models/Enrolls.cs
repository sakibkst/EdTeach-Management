using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Models
{
    public class Enrolls
    {
        public void InsertEnroll(Enroll s)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO enroll VALUES(@id,@studentid,@courseid,@enrolldate,@expiredate,@enrollstatus,@status)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", s.Id);
            cmd.Parameters.AddWithValue("@studentid", s.Studentid);
            cmd.Parameters.AddWithValue("@courseid", s.Courseid);
            cmd.Parameters.AddWithValue("@enrolldate", s.Enrolldate);
            cmd.Parameters.AddWithValue("@expiredate", s.Expiredate);
            cmd.Parameters.AddWithValue("@enrollstatus", s.Enrollstatus);
            cmd.Parameters.AddWithValue("@status", s.Status);

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public List<Enroll> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Enroll> list = new List<Enroll>();
            using (reader)
            {

                while (reader.Read())
                {
                    Enroll obj = new Enroll();
                    obj.Id = reader.GetString(0);
                    obj.Studentid = reader.GetString(1);
                    obj.Courseid = reader.GetString(2);
                    obj.Enrolldate = reader.GetDateTime(3);
                    obj.Expiredate = reader.GetDateTime(4);
                    obj.Enrollstatus = reader.GetString(5);
                    obj.Status = reader.GetString(6);

                    list.Add(obj);
                }
                reader.Close();


            }
            cmd.Connection.Close();
            return list;



        }

        public Enroll GetData1(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Enroll obj = new Enroll();
            using (reader)
            {
                while (reader.Read())
                {

                    obj.Id = reader.GetString(0);
                    obj.Studentid = reader.GetString(1);
                    obj.Courseid = reader.GetString(2);
                    obj.Enrolldate = reader.GetDateTime(3);
                    obj.Expiredate = reader.GetDateTime(4);
                    obj.Enrollstatus = reader.GetString(5);
                    obj.Status = reader.GetString(6);


                }
                reader.Close();
            }
            cmd.Connection.Close();
            return obj;
        }

        public List<Enroll> GetEnrollList()
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from enroll WHERE status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@status", "active");
            List<Enroll> enrollList = GetData(cmd);
            return enrollList;


        }

        public Enroll GetEnroll(string id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from enroll WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            Enroll lib = new Enroll();
            lib = GetData1(cmd);

            return lib;


        }


        public void DeleteEnroll(string Id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE enroll SET status=@status WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@status", "inactive");
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }

        public void ExpireEnroll(string Id, DateTime expiredate)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE enroll SET expiredate=@expiredate,enrollstatus=@status WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@expiredate", expiredate);
            cmd.Parameters.AddWithValue("@status", "expired");
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }



        public List<Enroll> GetEnrollList1(string id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from enroll WHERE studentid=@id and status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@status", "active");
            List<Enroll> enrollList = GetData(cmd);

            return enrollList;


        }
    }
}
