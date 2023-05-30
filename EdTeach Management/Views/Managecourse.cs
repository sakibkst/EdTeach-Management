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
    public partial class Managecourse : Form
    {
        Login user;
        public string Id;
        public Managecourse(Login u)
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

        private void Managecourse_Load(object sender, EventArgs e)
        {
            manageteacherdatagridview.DataSource = CourseController.GetCourseList();
        }

        private void manageteacherdatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = manageteacherdatagridview.SelectedRows[0].Cells[0].Value.ToString();
            titletextbox.Text = manageteacherdatagridview.SelectedRows[0].Cells[1].Value.ToString();
            instructortextbox.Text = manageteacherdatagridview.SelectedRows[0].Cells[2].Value.ToString();
            batchtextbox.Text = manageteacherdatagridview.SelectedRows[0].Cells[3].Value.ToString();
            typecombobox.Text = manageteacherdatagridview.SelectedRows[0].Cells[4].Value.ToString();
            durationtextbox.Text = manageteacherdatagridview.SelectedRows[0].Cells[5].Value.ToString();
            noofpricetextbox.Text = manageteacherdatagridview.SelectedRows[0].Cells[6].Value.ToString();
            levelcombobox.Text = manageteacherdatagridview.SelectedRows[0].Cells[7].Value.ToString();
            lecturestextbox.Text = manageteacherdatagridview.SelectedRows[0].Cells[8].Value.ToString();

        }
        public string CreateId()
        {
            Random xx = new Random();
            int y = xx.Next(0, 10000000);
            string a = "B-" + y;
            return a;

        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            if ((titletextbox.Text != "") && (instructortextbox.Text != ""))
            {
                if (batchtextbox.Text != "")
                {
                    if ((typecombobox.Text != ""))
                    {
                        if ((durationtextbox.Text != "") && (noofpricetextbox.Text != "") && (levelcombobox.Text != "") && (lecturestextbox.Text != ""))
                        {
                            Course o = new Course();
                            o.Id = CreateId();
                            o.Title = titletextbox.Text;
                            o.Instructor = instructortextbox.Text;
                            try
                            {

                                o.Batch = batchtextbox.Text;
                                o.Type = typecombobox.Text;



                                o.Duration = durationtextbox.Text;
                                o.Price  = noofpricetextbox.Text;
                                o.Lvel = levelcombobox.Text;
                                o.Lectures = lecturestextbox.Text;

                                o.Status = "active";



                                CourseController.InsertCourse(o);

                                MessageBox.Show("Course Inserted.Course id" + o.Id, "Add Course", MessageBoxButtons.OK);
                                titletextbox.Clear();
                                instructortextbox.Clear();
                                batchtextbox.Clear();
                                typecombobox.Text = "";
                                durationtextbox.Clear();
                                noofpricetextbox.Clear();
                                lecturestextbox.Clear();
                                Id = null;
                                levelcombobox.Text = "";

                                manageteacherdatagridview.DataSource = CourseController.GetCourseList();




                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("failed", "Add course", MessageBoxButtons.OK);
                                titletextbox.Clear();
                                instructortextbox.Clear();
                                batchtextbox.Clear();
                                typecombobox.Text = "";
                                durationtextbox.Clear();
                                noofpricetextbox.Clear();
                                lecturestextbox.Clear();
                                Id = null;
                                levelcombobox.Text = "";

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
                CourseController.UpdateCourse(Id, titletextbox.Text, noofpricetextbox.Text);



                titletextbox.Clear();
                instructortextbox.Clear();
                batchtextbox.Clear();
                typecombobox.Text = "";
                durationtextbox.Clear();
                noofpricetextbox.Clear();
                lecturestextbox.Clear();
                Id = null;
                levelcombobox.Text = "";

                manageteacherdatagridview.DataSource = CourseController.GetCourseList();
                MessageBox.Show("course updatetd", "update course", MessageBoxButtons.OK);


            }

            else
            {
                MessageBox.Show("please select a Course", "update course", MessageBoxButtons.OK);

            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            titletextbox.Clear();
            instructortextbox.Clear();
            batchtextbox.Clear();
            typecombobox.Text = "";
            durationtextbox.Clear();
            noofpricetextbox.Clear();
            lecturestextbox.Clear();
            Id = null;
            levelcombobox.Text = "";
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                CourseController.DeleteCourse(Id);



                titletextbox.Clear();
                instructortextbox.Clear();
                batchtextbox.Clear();
                typecombobox.Text = "";
                durationtextbox.Clear();
                noofpricetextbox.Clear();
                lecturestextbox.Clear();
                Id = null;
                levelcombobox.Text = "";

                manageteacherdatagridview.DataSource = CourseController.GetCourseList();
                MessageBox.Show("Course deleted", "delete Course", MessageBoxButtons.OK);


            }

            else
            {
                MessageBox.Show("please select a Course", "delete course", MessageBoxButtons.OK);

            }
        }
    }
}
