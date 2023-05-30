using EdTeach_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdTeach_Management.Views
{
    public partial class Teacherhome : Form
    {
         Login user;

        public Teacherhome(Login u)
        {
            InitializeComponent();
            user= u;    
        }

        

        private void managestudentbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Managestudent a = new Managestudent(user);
            a.Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginView a = new LoginView();
            a.Show();
        }

        private void managecoursebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Managecourse a = new Managecourse(user);
            a.Show();
        }

        private void manageenrollcoursebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manageenrollcourse a = new Manageenrollcourse(user);
            a.Show();
        }

        private void profilebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacherprofile a = new Teacherprofile(user);
            a.Show();
        }

        private void changepasswordbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherchangepassword a = new teacherchangepassword(user);
            a.Show();
        }
    }
}
