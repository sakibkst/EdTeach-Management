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
    public partial class Studenthome : Form
    {
        Login user;

        public Studenthome(Login u)
        {
            InitializeComponent();
            user = u;
        }



        private void allcoursebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Allcoursesdetails a = new Allcoursesdetails(user);
            a.Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginView a = new LoginView();
            a.Show();
        }

        private void ownactivitybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ownactivity a = new Ownactivity(user);
            a.Show();
        }

        

       

        private void profilebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studentprofile a = new Studentprofile(user);
            a.Show();
        }

        private void changepasswordbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studentchangepassword a = new Studentchangepassword(user);
            a.Show();
        }
    }
}
