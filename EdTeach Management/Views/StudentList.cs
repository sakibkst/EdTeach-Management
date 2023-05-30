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
    public partial class StudentList : Form
    {
        Login user;

        public StudentList(Login u)
        {
            InitializeComponent();
            user = u;
        }

        private void studentlistdatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminhome a = new Adminhome(user);
            a.Show();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            studentlistdatagridview.DataSource = StudentController.GetStudentList();
        }
    }
}
