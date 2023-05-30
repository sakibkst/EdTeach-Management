using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Models
{
    public class Teachers
    {
        public void InsertTeacher(Teacher teacher)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO teacher VALUES(@id,@name,@email,@phoneno,@gender,@address,@salary,@status)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", teacher.Id);
            cmd.Parameters.AddWithValue("@name", teacher.Name);
            cmd.Parameters.AddWithValue("@email", teacher.Email);
            cmd.Parameters.AddWithValue("@phoneno", teacher.Phoneno);
            cmd.Parameters.AddWithValue("@gender", teacher.Gender);
            cmd.Parameters.AddWithValue("@address", teacher.Address);
            cmd.Parameters.AddWithValue("@salary", teacher.Salary);
            cmd.Parameters.AddWithValue("@status", teacher.Status);

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public List<Teacher> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Teacher> list = new List<Teacher>();
            using (reader)
            {

                while (reader.Read())
                {
                    Teacher obj = new Teacher();
                    obj.Id = reader.GetString(0);
                    obj.Name = reader.GetString(1);
                    obj.Email = reader.GetString(2);
                    obj.Phoneno = reader.GetString(3);
                    obj.Gender = reader.GetString(4);
                    obj.Address = reader.GetString(5);
                    obj.Salary = reader.GetString(6);
                    obj.Status = reader.GetString(7);
                    list.Add(obj);
                }
                reader.Close();


            }
            cmd.Connection.Close();
            return list;



        }

        public Teacher GetData1(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Teacher obj = new Teacher();
            using (reader)
            {
                while (reader.Read())
                {

                    obj.Id = reader.GetString(0);
                    obj.Name = reader.GetString(1);
                    obj.Email = reader.GetString(2);
                    obj.Phoneno = reader.GetString(3);
                    obj.Gender = reader.GetString(4);
                    obj.Address = reader.GetString(5);
                    obj.Salary = reader.GetString(6);
                    obj.Status = reader.GetString(7);


                }
                reader.Close();
            }
            cmd.Connection.Close();
            return obj;
        }

        public List<Teacher> GetTeacherList()
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from teacher WHERE status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@status", "active");
            List<Teacher> teacherList = GetData(cmd);
            return teacherList;


        }

        public Teacher GetTeacher(string id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from teacher WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            Teacher lib = new Teacher();
            lib = GetData1(cmd);

            return lib;


        }


        public void DeleteTeacher(string Id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE teacher SET status=@status WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@status", "inactive");
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }

        public void UpdateTeacher(String Id, string name, string salary)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE teacher SET name=@name, salary=@salary WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public void UpdateTeacherSelf(String Id, string email, string Phoneno, string address)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE teacher SET email=@email,phoneno=@Phoneno,address=@address WHERE id=@id");
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
