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
    public partial class Managestudent : Form
    {
        public string Id;
        Login user;

        public Managestudent(Login u)
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

        private void managestudentdatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = managestudentdatagridview.SelectedRows[0].Cells[0].Value.ToString();
            nametextbox.Text = managestudentdatagridview.SelectedRows[0].Cells[1].Value.ToString();
            emailtextbox.Text = managestudentdatagridview.SelectedRows[0].Cells[2].Value.ToString();
            phonenotextbox.Text = managestudentdatagridview.SelectedRows[0].Cells[3].Value.ToString();
            addresstextbox.Text = managestudentdatagridview.SelectedRows[0].Cells[5].Value.ToString();
            institutiontextbox.Text = managestudentdatagridview.SelectedRows[0].Cells[6].Value.ToString();

            passwordtextbox.Clear();
            answertextbox.Clear();
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

                                managestudentdatagridview.DataSource = StudentController.GetStudentList();




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
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                StudentController.UpdateStudent(Id, nametextbox.Text, institutiontextbox.Text);



                nametextbox.Clear();
                emailtextbox.Clear();
                phonenotextbox.Clear();
                addresstextbox.Clear();
                institutiontextbox.Clear();
                answertextbox.Clear();
                passwordtextbox.Clear();
                Id = null;

                managestudentdatagridview.DataSource = StudentController.GetStudentList();
                MessageBox.Show("student updatetd", "update student", MessageBoxButtons.OK);


            }

            else
            {
                MessageBox.Show("please select a student", "update student", MessageBoxButtons.OK);

            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                StudentController.DeleteStudent(Id);



                nametextbox.Clear();
                emailtextbox.Clear();
                phonenotextbox.Clear();
                addresstextbox.Clear();
                institutiontextbox.Clear();
                answertextbox.Clear();
                passwordtextbox.Clear();
                Id = null;

                managestudentdatagridview.DataSource = StudentController.GetStudentList();
                MessageBox.Show("student Deleted", "Delete student", MessageBoxButtons.OK);


            }

            else
            {
                MessageBox.Show("please select a student", "Delete student", MessageBoxButtons.OK);

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

        private void Managestudent_Load(object sender, EventArgs e)
        {
            managestudentdatagridview.DataSource = StudentController.GetStudentList();
        }
    }
}
