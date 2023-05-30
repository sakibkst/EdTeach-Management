using EdTeach_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Controllers
{
    public class StudentController
    {


        static Database db = new Database();

        static public void InsertStudent(Student s)
        {

            db.Students1.InsertStudent(s);


        }

        static public List<Student> GetStudentList()
        {
            List<Student> studentList = db.Students1.GetStudentList();
            return studentList;

        }

        static public Student GetStudent(string id)
        {
            Student a = new Student();
            a = db.Students1.GetStudent(id);
            return a;

        }

        static public void UpdateStudent(String Id, string name, string ins)
        {

            db.Students1.UpdateStudent(Id, name, ins);


        }

        static public void DeleteStudent(string Id)
        {
            db.Students1.DeleteStudent(Id);


        }

        static public void UpdateStudentSelf(String Id, string email, string Phoneno, string address)
        {

            db.Students1.UpdateStudentSelf(Id, email, Phoneno, address);


        }

        static public List<Student> GetStudentList1(String name)
        {
            List<Student> studentList = db.Students1.GetStudentList1(name);
            return studentList;

        }
    }
}
