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
    public partial class Manageenrollcourse : Form
    {
        Login user;

        public string Id;

        public Manageenrollcourse(Login u)
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

        private void Manageenrollcourse_Load(object sender, EventArgs e)
        {
            enrollcoursedatagridview.DataSource = EnrollController.GetEnrollList();
        }

        private void enrollcoursedatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = enrollcoursedatagridview.SelectedRows[0].Cells[0].Value.ToString();
            studentidtextbox.Text = enrollcoursedatagridview.SelectedRows[0].Cells[1].Value.ToString();
            courseidtextbox.Text = enrollcoursedatagridview.SelectedRows[0].Cells[2].Value.ToString();
        }
        public string CreateId()
        {
            Random xx = new Random();
            int y = xx.Next(0, 10000000);
            string a = "BB-" + y;
            return a;

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
                EnrollController.DeleteEnroll(Id);



                studentidtextbox.Clear();
                courseidtextbox.Clear();

                Id = null;


                enrollcoursedatagridview.DataSource = EnrollController.GetEnrollList();
                MessageBox.Show("enroll deleted", "delete enroll", MessageBoxButtons.OK);


            }

            else
            {
                MessageBox.Show("please select a enroll", "delete enroll", MessageBoxButtons.OK);

            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

            studentidtextbox.Clear();
            courseidtextbox.Clear();

            Id = null;
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            if ((studentidtextbox.Text != "") && (courseidtextbox.Text != ""))
            {
                Enroll o = new Enroll();
                o.Id = CreateId();
                o.Studentid = studentidtextbox.Text;
                o.Courseid = courseidtextbox.Text;
                o.Enrolldate = enrolldatepicker.Value;
                o.Expiredate = new DateTime(2024,12 ,12);
                o.Enrollstatus = "enrolled";
                o.Status = "active";
                EnrollController.InsertEnroll(o);



                studentidtextbox.Clear();
                courseidtextbox.Clear();

                Id = null;


                enrollcoursedatagridview.DataSource = EnrollController.GetEnrollList();
                MessageBox.Show("enroll inserted", "Insertenroll", MessageBoxButtons.OK);


            }

            else
            {
                MessageBox.Show("please select a enroll", "delete enroll", MessageBoxButtons.OK);

            }
        }

        private void expirebutton_Click(object sender, EventArgs e)
        {
            if (Id != null)
            {
              
                EnrollController.Expireenroll(Id,DateTime.Today);



                studentidtextbox.Clear();
                courseidtextbox.Clear();

                Id = null;


                enrollcoursedatagridview.DataSource = EnrollController.GetEnrollList();
                MessageBox.Show("enroll deleted", "delete enroll", MessageBoxButtons.OK);


            }

            else
            {
                MessageBox.Show("please select a enroll", "delete enroll", MessageBoxButtons.OK);

            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (searchtextbox.Text != "")
            {
                if (studentradiobutton.Checked)
                {
                    searchdatagridview.DataSource = StudentController.GetStudentList1(searchtextbox.Text);
                }
                if (courseradiobutton.Checked)
                {
                    searchdatagridview.DataSource = CourseController.GetCourseList1(searchtextbox.Text);
                }
            }
        }
    }
}
