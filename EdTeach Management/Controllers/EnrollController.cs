using EdTeach_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Controllers
{
    internal class EnrollController
    {
        static Database db = new Database();

        static public void InsertEnroll(Enroll s)
        {

            db.Enrolls1.InsertEnroll(s);


        }

        static public List<Enroll> GetEnrollList()
        {
            List<Enroll> enrollList = db.Enrolls1.GetEnrollList();
            return enrollList;

        }

        static public Enroll GetEnroll(string id)
        {
            Enroll a = new Enroll();
            a = db.Enrolls1.GetEnroll(id);
            return a;

        }

        static public void Expireenroll(String Id, DateTime expiredate)
        {

            db.Enrolls1.ExpireEnroll(Id, expiredate);


        }

        static public void DeleteEnroll(string Id)
        {
            db.Enrolls1.DeleteEnroll(Id);


        }



        static public List<Enroll> GetEnrollList1(String name)
        {
            List<Enroll> enrollList = db.Enrolls1.GetEnrollList1(name);
            return enrollList;

        }
    }
}
