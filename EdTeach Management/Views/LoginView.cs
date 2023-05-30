using EdTeach_Management.Controllers;
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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            passwordtextbox.PasswordChar = '*';
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            Login user = LoginController.getUser(useridtextbox.Text, passwordtextbox.Text);
            if (user != null)
            {
                if (user.Role == "admin" && user.Status == "active")
                {
                    this.Hide();
                    Adminhome a = new Adminhome(user);
                    a.Show();

                }

                else if (user.Role == "teacher" && user.Status == "active")
                {
                    this.Hide();
                    Teacherhome a = new Teacherhome(user);
                    a.Show();

                }

                else if (user.Role == "student" && user.Status == "active")
                {
                    this.Hide();
                    Studenthome a = new Studenthome(user);
                    a.Show();

                }



                else
                {

                    MessageBox.Show("Wrong Pass or User Id", "login failed", MessageBoxButtons.OK);
                    useridtextbox.Clear();
                    passwordtextbox.Clear();
                }

            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration a = new Registration();
            a.Show();
        }

        private void showcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showcheckbox.Checked)
            {
                passwordtextbox.UseSystemPasswordChar = true;


            }
            else
            {
                passwordtextbox.UseSystemPasswordChar = false;
            }
        }
    }
}
