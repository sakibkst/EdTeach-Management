using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Models
{
    public class Login
    {
        string id;

        public string Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string Answer { get => answer; set => answer = value; }
        public string Status { get => status; set => status = value; }

        string password;
        string role;
        string answer;
        string status;

    }
}
