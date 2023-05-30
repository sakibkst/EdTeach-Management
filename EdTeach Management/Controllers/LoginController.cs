using EdTeach_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdTeach_Management.Controllers
{
    public class LoginController
    {
        static Database db = new Database();

        static public dynamic getUser(string userid, string password)
        {

            var obj = db.Logins1.getUser(userid, password);
            return obj;

        }

        static public void InsertUser(Login user)
        {
            db.Logins1.InsertUser(user);

        }

        static public void DeleteUser(string userid)
        {
            db.Logins1.DeleteUser(userid);

        }
        static public Login FindUser(string id, string security)
        {
            Login obj = db.Logins1.FindUser(id, security);
            return obj;

        }

        static public void UpdatePassword(string userid, string Password)
        {
            db.Logins1.Update_Password(userid, Password);

        }
    }
}
