using EdTeach_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Controllers
{
    public class TeacherController
    {
        static Database db = new Database();

        static public void InsertTeacher(Teacher teacher)
        {

            db.Teachers1.InsertTeacher(teacher);


        }

        static public List<Teacher> GetTeacherList()
        {
            List<Teacher> teacherList = db.Teachers1.GetTeacherList();
            return teacherList;

        }

        static public Teacher GetTeacher(string id)
        {
            Teacher a = new Teacher();
            a = db.Teachers1.GetTeacher(id);
            return a;

        }

        static public void UpdateTeacher(String Id, string name, string salary)
        {

            db.Teachers1.UpdateTeacher(Id, name, salary);


        }

        static public void DeleteTeacher(string Id)
        {
            db.Teachers1.DeleteTeacher(Id);


        }

        static public void UpdateTeacherSelf(String Id, string email, string Phoneno, string address)
        {

            db.Teachers1.UpdateTeacherSelf(Id, email, Phoneno, address);


        }
    }
}
