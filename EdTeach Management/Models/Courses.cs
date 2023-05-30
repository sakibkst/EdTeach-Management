using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdTeach_Management.Views;

namespace EdTeach_Management.Models
{
    public class Courses
    {
        public void InsertCourse(Course s)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO course VALUES(@id,@title,@instructor,@batch,@type,@duration,@price,@lvel,@lectures,@status)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", s.Id);
            cmd.Parameters.AddWithValue("@title", s.Title);
            cmd.Parameters.AddWithValue("@instructor", s.Instructor);
            cmd.Parameters.AddWithValue("@batch", s.Batch);
            cmd.Parameters.AddWithValue("@type", s.Type);
            cmd.Parameters.AddWithValue("@duration", s.Duration);
            cmd.Parameters.AddWithValue("@price", s.Price);
            cmd.Parameters.AddWithValue("@lvel", s.Lvel);
            cmd.Parameters.AddWithValue("@lectures", s.Lectures);
            cmd.Parameters.AddWithValue("@status", s.Status);

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public List<Course> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Course> list = new List<Course>();
            using (reader)
            {

                while (reader.Read())
                {
                    Course obj = new Course();
                    obj.Id = reader.GetString(0);
                    obj.Title = reader.GetString(1);
                    obj.Instructor = reader.GetString(2);
                    obj.Batch = reader.GetString(3);
                    obj.Type = reader.GetString(4);
                    obj.Duration = reader.GetString(5);
                    obj.Price = reader.GetString(6);
                    obj.Lvel = reader.GetString(7);
                    obj.Lectures = reader.GetString(8);
                    obj.Status = reader.GetString(9);
                    list.Add(obj);
                }
                reader.Close();


            }
            cmd.Connection.Close();
            return list;



        }

        public Course GetData1(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Course obj = new Course();
            using (reader)
            {
                while (reader.Read())
                {

                    obj.Id = reader.GetString(0);
                    obj.Title = reader.GetString(1);
                    obj.Instructor = reader.GetString(2);
                    obj.Batch = reader.GetString(3);
                    obj.Type = reader.GetString(4);
                    obj.Duration = reader.GetString(5);
                    obj.Price = reader.GetString(6);
                    obj.Lvel = reader.GetString(7);
                    obj.Lectures = reader.GetString(8);
                    obj.Status = reader.GetString(9);


                }
                reader.Close();
            }
            cmd.Connection.Close();
            return obj;
        }

        public List<Course> GetCourseList()
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from course WHERE status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@status", "active");
            List<Course> courseList = GetData(cmd);
            return courseList;


        }

        public Course GetCourse(string id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from course WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            Course lib = new Course();
            lib = GetData1(cmd);

            return lib;


        }


        public void DeleteCourse(string Id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE course SET status=@status WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@status", "inactive");
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }

        public void UpdateCourse(String Id, string title, string price)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE course SET title=@title, price=@price WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }





        public List<Course> GetCourseList1(string name)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from course WHERE title=@name and status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@status", "active");
            List<Course> courseList = GetData(cmd);

            return courseList;


        }
    }
}
