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
    public partial class Manageteacher : Form
    {
        Login user;
        public string Id;

        public Manageteacher(Login u)
        {
            InitializeComponent();
            user = u;
        }

       
        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminhome a = new Adminhome(user);
            a.Show();
        }

        private void Manageteacher_Load(object sender, EventArgs e)
        {
            manageteacherdatagridview.DataSource = TeacherController.GetTeacherList();
        }

        private void manageteacherdatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = manageteacherdatagridview.SelectedRows[0].Cells[0].Value.ToString();
            nametextbox.Text = manageteacherdatagridview.SelectedRows[0].Cells[1].Value.ToString();
            emailtextbox.Text = manageteacherdatagridview.SelectedRows[0].Cells[2].Value.ToString();
            phonenotextbox.Text = manageteacherdatagridview.SelectedRows[0].Cells[3].Value.ToString();
            addresstextbox.Text = manageteacherdatagridview.SelectedRows[0].Cells[5].Value.ToString();
            salarytextbox.Text = manageteacherdatagridview.SelectedRows[0].Cells[6].Value.ToString();

            passwordtextbox.Clear();
            answertextbox.Clear();
        }
        public string CreateId()
        {
            Random xx = new Random();
            int y = xx.Next(0, 10000000);
            string a = "T-" + y;
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
                        if ((answertextbox.Text != "") && (passwordtextbox.Text != "") && (addresstextbox.Text != "") && (salarytextbox.Text != ""))
                        {
                            Teacher o = new Teacher();
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
                                o.Salary = salarytextbox.Text;

                                o.Status = "active";

                                Login u = new Login();
                                u.Id = o.Id;
                                u.Password = passwordtextbox.Text;
                                u.Status = "active";
                                u.Role = "teacher";
                                u.Answer = answertextbox.Text;

                                TeacherController.InsertTeacher(o);
                                LoginController.InsertUser(u);
                                MessageBox.Show("Teacher Inserted.Teacher id" + o.Id, "Add Teacher", MessageBoxButtons.OK);
                                nametextbox.Clear();
                                emailtextbox.Clear();
                                phonenotextbox.Clear();
                                addresstextbox.Clear();
                                salarytextbox.Clear();
                                answertextbox.Clear();
                                passwordtextbox.Clear();
                                Id = null;

                                manageteacherdatagridview.DataSource = TeacherController.GetTeacherList();




                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("failed", "Add Teacher", MessageBoxButtons.OK);
                                nametextbox.Clear();
                                emailtextbox.Clear();
                                phonenotextbox.Clear();
                                addresstextbox.Clear();
                                salarytextbox.Clear();
                                answertextbox.Clear();
                                passwordtextbox.Clear();
                                Id = null;

                            }

                        }

                    }


                }

            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            nametextbox.Clear();
            emailtextbox.Clear();
            phonenotextbox.Clear();
            addresstextbox.Clear();
            salarytextbox.Clear();
            answertextbox.Clear();
            passwordtextbox.Clear();
            Id = null;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                TeacherController.UpdateTeacher(Id, nametextbox.Text, salarytextbox.Text);



                nametextbox.Clear();
                emailtextbox.Clear();
                phonenotextbox.Clear();
                addresstextbox.Clear();
                salarytextbox.Clear();
                answertextbox.Clear();
                passwordtextbox.Clear();
                Id = null;

                manageteacherdatagridview.DataSource = TeacherController.GetTeacherList();
                MessageBox.Show("Teacher updatetd", "update Teacher", MessageBoxButtons.OK);


            }

            else
            {
                MessageBox.Show("please select an Teacher", "update Teacher", MessageBoxButtons.OK);

            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                TeacherController.DeleteTeacher(Id);
                LoginController.DeleteUser(Id);


                nametextbox.Clear();
                emailtextbox.Clear();
                phonenotextbox.Clear();
                addresstextbox.Clear();
                salarytextbox.Clear();
                answertextbox.Clear();
                passwordtextbox.Clear();
                Id = null;

                manageteacherdatagridview.DataSource = TeacherController.GetTeacherList();
                MessageBox.Show("Teacher deleted", "delete Teacher", MessageBoxButtons.OK);


            }

            else
            {
                MessageBox.Show("please select an Teacher", "delete Teacher", MessageBoxButtons.OK);

            }
        }
    }
}
