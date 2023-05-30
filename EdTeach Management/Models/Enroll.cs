using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Models
{
    public class Enroll
    {
        string id;
        string studentid;
        string courseid;
        DateTime enrolldate;
        DateTime expiredate;
        string enrollstatus;
        string status;

        public string Id { get => id; set => id = value; }
        public string Studentid { get => studentid; set => studentid = value; }
        public string Courseid { get => courseid; set => courseid = value; }
        public DateTime Enrolldate { get => enrolldate; set => enrolldate = value; }
        public DateTime Expiredate { get => expiredate; set => expiredate = value; }
        public string Enrollstatus { get => enrollstatus; set => enrollstatus = value; }
        public string Status { get => status; set => status = value; }
    }
}
