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
    public partial class Teacherprofile : Form
    {
         Login user;

        public Teacherprofile(Login u)
        {
            InitializeComponent();
            user = u;
        }

       

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacherhome a = new Teacherhome(user);
            a.Show();
        }

        private void Teacherprofile_Load(object sender, EventArgs e)
        {
            Teacher m = new Teacher();
            m = TeacherController.GetTeacher(user.Id);
            useridtextbox.Text = m.Id;
            nametextbox.Text = m.Name;
            emailtextbox.Text = m.Email;
            phonenotextbox.Text = m.Phoneno;
            addresstextbox.Text = m.Address;
            salarytextbox.Text = m.Salary;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if ((emailtextbox.Text != "") && (phonenotextbox.Text != "") && (addresstextbox.Text != ""))
            {

                TeacherController.UpdateTeacherSelf(useridtextbox.Text, emailtextbox.Text, phonenotextbox.Text, addresstextbox.Text);
                MessageBox.Show("Email,Phone number and Address updated", "update", MessageBoxButtons.OK);

            }

            else
            {
                MessageBox.Show("Please fill Email,phone number And Address box", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
