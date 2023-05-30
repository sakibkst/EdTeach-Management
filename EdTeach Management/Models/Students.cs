using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Models
{
    public class Students
    {
        public void InsertStudent(Student s)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO student VALUES(@id,@name,@email,@phoneno,@gender,@address,@institution,@status)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", s.Id);
            cmd.Parameters.AddWithValue("@name", s.Name);
            cmd.Parameters.AddWithValue("@email", s.Email);
            cmd.Parameters.AddWithValue("@phoneno", s.Phoneno);
            cmd.Parameters.AddWithValue("@gender", s.Gender);
            cmd.Parameters.AddWithValue("@address", s.Address);
            cmd.Parameters.AddWithValue("@institution", s.Institution);
            cmd.Parameters.AddWithValue("@status", s.Status);

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public List<Student> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> list = new List<Student>();
            using (reader)
            {

                while (reader.Read())
                {
                    Student obj = new Student();
                    obj.Id = reader.GetString(0);
                    obj.Name = reader.GetString(1);
                    obj.Email = reader.GetString(2);
                    obj.Phoneno = reader.GetString(3);
                    obj.Gender = reader.GetString(4);
                    obj.Address = reader.GetString(5);
                    obj.Institution = reader.GetString(6);
                    obj.Status = reader.GetString(7);
                    list.Add(obj);
                }
                reader.Close();


            }
            cmd.Connection.Close();
            return list;



        }

        public Student GetData1(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Student obj = new Student();
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
                    obj.Institution = reader.GetString(6);
                    obj.Status = reader.GetString(7);


                }
                reader.Close();
            }
            cmd.Connection.Close();
            return obj;
        }

        public List<Student> GetStudentList()
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from student WHERE status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@status", "active");
            List<Student> studentList = GetData(cmd);
            return studentList;


        }

        public Student GetStudent(string id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from student WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            Student lib = new Student();
            lib = GetData1(cmd);

            return lib;


        }


        public void DeleteStudent(string Id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE student SET status=@status WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@status", "inactive");
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }

        public void UpdateStudent(String Id, string name, string ins)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE student SET name=@name, institution=@ins WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@ins", ins);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public void UpdateStudentSelf(String Id, string email, string Phoneno, string address)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE student SET email=@email,phoneno=@Phoneno,address=@address WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@Phoneno", Phoneno);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }



        public List<Student> GetStudentList1(string name)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from student WHERE name=@name and status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@status", "active");
            List<Student> studentList = GetData(cmd);

            return studentList;


        }
    }
}
