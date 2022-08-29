using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityAccamodationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWarden_Click(object sender, EventArgs e)
        {
            WardenLogin wardenLogin = new WardenLogin();
            wardenLogin.Show();
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentDashboard studentDashboard = new StudentDashboard();
            studentDashboard.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
