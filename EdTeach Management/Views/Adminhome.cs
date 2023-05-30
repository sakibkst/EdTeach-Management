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
    public partial class Adminhome : Form
    {
        Login user;

        public Adminhome(Login u)
        {
            InitializeComponent();
            user = u;
        }

        //public Adminhome(Login user)
        //{
        //    this.user = user;
        //}

        private void manageteacherbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manageteacher a = new Manageteacher(user);
            a.Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginView a = new LoginView();
            a.Show();
        }

        private void courselistbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Courselist a = new Courselist(user);
            a.Show();
        }

        private void studentlistbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentList a = new StudentList(user);
            a.Show();
        }

        private void profilebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile a = new Profile(user);
            a.Show();
        }

        private void changepasswordbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Changepassword a = new Changepassword(user);
            a.Show();
        }
    }
}
