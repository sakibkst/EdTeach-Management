using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Models
{
    public class Teacher
    {
        string id;
        string name;
        string email;
        string phoneno;
        string gender;
        string address;
        string salary;
        string status;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phoneno { get => phoneno; set => phoneno = value; }
        public string Gender { get => gender; set => gender = value; }

        public string Address { get => address; set => address = value; }
        public string Salary { get => salary; set => salary = value; }
        public string Status { get => status; set => status = value; }

    }
}
