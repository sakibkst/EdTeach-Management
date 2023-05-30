using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EdTeach_Management.Controllers;
using EdTeach_Management.Models;

namespace EdTeach_Management.Views
{

    public partial class Studentchangepassword : Form
    {
        Login user;
        public Studentchangepassword(Login u)
        {
            InitializeComponent();
            user = u;
        }

        

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (newpasswordtextbox.Text != "")
            {
                LoginController.UpdatePassword(user.Id, newpasswordtextbox.Text);
                newpasswordtextbox.Clear();

                MessageBox.Show("password Change", "Change Password", MessageBoxButtons.OK);
                this.Hide();
                LoginView a = new LoginView();
                a.Show();


            }
            else
            {
                MessageBox.Show("please give new password", "Change Password", MessageBoxButtons.OK);

            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studenthome a = new Studenthome(user);
            a.Show();
        }
    }
}
