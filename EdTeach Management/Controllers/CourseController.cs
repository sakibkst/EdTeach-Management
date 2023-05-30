using EdTeach_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Controllers
{
    public class CourseController
    {
        static Database db = new Database();

        static public void InsertCourse(Course s)
        {

            db.Courses1.InsertCourse(s);


        }

        static public List<Course> GetCourseList()
        {
            List<Course> courseList = db.Courses1.GetCourseList();
            return courseList;

        }

        static public Course GetCourse(string id)
        {
            Course a = new Course();
            a = db.Courses1.GetCourse(id);
            return a;

        }

        static public void UpdateCourse(String Id, string title, string price)
        {

            db.Courses1.UpdateCourse(Id, title, price);


        }

        static public void DeleteCourse(string Id)
        {
            db.Courses1.DeleteCourse(Id);


        }



        static public List<Course> GetCourseList1(String name)
        {
            List<Course> courseList = db.Courses1.GetCourseList1(name);
            return courseList;

        }
    }
}
