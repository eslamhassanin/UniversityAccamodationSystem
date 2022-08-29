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
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void btnWriteFeedback_Click(object sender, EventArgs e)
        {
            WriteFeedback writeFeedback = new WriteFeedback();
            writeFeedback.Show();
        }

        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            ViewFeedbackstatus viewFeedbackstatus = new ViewFeedbackstatus();
            viewFeedbackstatus.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
