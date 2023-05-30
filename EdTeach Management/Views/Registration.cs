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
    public partial class Registration : Form
    {
        public string Id;
        public Registration()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginView a = new LoginView();
            a.Show();
        }
        public string CreateId()
        {
            Random xx = new Random();
            int y = xx.Next(0, 10000000);
            string a = "S-" + y;
            return a;

        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            if ((nametextbox.Text != "") && (phonenotextbox.Text != ""))
            {
                if (emailtextbox.Text != "")
                {
                    if ((maleradiobutton.Checked) || (femaleradiobutton.Checked))
                    {
                        if ((answertextbox.Text != "") && (passwordtextbox.Text != "") && (addresstextbox.Text != "") && (institutiontextbox.Text != ""))
                        {
                            Student o = new Student();
                            o.Id = CreateId();
                            o.Name = nametextbox.Text;
                            o.Email = emailtextbox.Text;
                            try
                            {

                                o.Phoneno = phonenotextbox.Text;

                                if (maleradiobutton.Checked)
                                {
                                    o.Gender = "male";

                                }

                                else if (femaleradiobutton.Checked)
                                {
                                    o.Gender = "Female";

                                }

                                o.Address = addresstextbox.Text;
                                o.Institution = institutiontextbox.Text;

                                o.Status = "active";

                                Login u = new Login();
                                u.Id = o.Id;
                                u.Password = passwordtextbox.Text;
                                u.Status = "active";
                                u.Role = "student";
                                u.Answer = answertextbox.Text;

                                StudentController.InsertStudent(o);
                                LoginController.InsertUser(u);
                                MessageBox.Show("Student Inserted.student id" + o.Id, "Add student", MessageBoxButtons.OK);
                                nametextbox.Clear();
                                emailtextbox.Clear();
                                phonenotextbox.Clear();
                                addresstextbox.Clear();
                                institutiontextbox.Clear();
                                answertextbox.Clear();
                                passwordtextbox.Clear();
                                Id = null;






                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("failed", "Add student", MessageBoxButtons.OK);
                                nametextbox.Clear();
                                emailtextbox.Clear();
                                phonenotextbox.Clear();
                                addresstextbox.Clear();
                                institutiontextbox.Clear();
                                answertextbox.Clear();
                                passwordtextbox.Clear();
                                Id = null;

                            }

                        }

                    }


                }

            }
            else
            {
                MessageBox.Show("failed", "Registration");
            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            nametextbox.Clear();
            emailtextbox.Clear();
            phonenotextbox.Clear();
            addresstextbox.Clear();
            institutiontextbox.Clear();
            answertextbox.Clear();
            passwordtextbox.Clear();
            Id = null;
        }
    }
}
