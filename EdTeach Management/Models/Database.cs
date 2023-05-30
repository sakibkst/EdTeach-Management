using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Models
{
    public class Database
    {
        Logins Logins;
        Admins Admins;
        Teachers Teachers;
        Students Students;
        Courses Courses;
        Enrolls Enrolls;

        public Logins Logins1 { get => Logins; set => Logins = value; }
        public Admins Admins1 { get => Admins; set => Admins = value; }
        public Teachers Teachers1 { get => Teachers; set => Teachers = value; }
        public Students Students1 { get => Students; set => Students = value; }
        public Courses Courses1 { get => Courses; set => Courses = value; }
        public Enrolls Enrolls1 { get => Enrolls; set => Enrolls = value; }

        public Database()
        {
            Logins = new Logins();
            Admins = new Admins();
            Teachers = new Teachers();
            Students = new Students();
            Courses = new Courses();
            Enrolls = new Enrolls();

        }
    }
}
