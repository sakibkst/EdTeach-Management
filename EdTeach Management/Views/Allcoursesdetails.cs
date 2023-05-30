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
    public partial class Allcoursesdetails : Form
    {
        Login user;
        public Allcoursesdetails(Login u)
        {
            InitializeComponent();
            user = u;   
        }
        private void Allcoursesdetails_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CourseController.GetCourseList();
        }

        private void searchtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studenthome a = new Studenthome(user);
            a.Show();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (searchtextbox.Text != "")
            {

                dataGridView1.DataSource = CourseController.GetCourseList1(searchtextbox.Text);
            }
        }
    }
}
