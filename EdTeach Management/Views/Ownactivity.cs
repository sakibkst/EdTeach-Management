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
    public partial class Ownactivity : Form
    {
        Login user;
        public Ownactivity(Login u)
        {
            InitializeComponent();
            user = u;
        }

       
        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studenthome a = new Studenthome(user);
            a.Show();
        }

        private void Ownactivity_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EnrollController.GetEnrollList1(user.Id);
        }
    }
}
