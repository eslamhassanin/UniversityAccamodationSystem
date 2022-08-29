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
    public partial class WardenDashboard : Form
    {
        public WardenDashboard()
        {
            InitializeComponent();
        }

        private void btnViewRooms_Click(object sender, EventArgs e)
        {
            ViewRooms viewRooms = new ViewRooms();
            viewRooms.Show();
        }

        private void btnAssignRoom_Click(object sender, EventArgs e)
        {
            AssignRoom assignRoom = new AssignRoom();
            assignRoom.Show();
        }

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {
            ChangeRoom changeRoom = new ChangeRoom();
            changeRoom.Show();
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            DeleteRoom deleteRoom = new DeleteRoom();
            deleteRoom.Show();
        }

        private void btnViewFeedback_Click(object sender, EventArgs e)
        {
            ResponseFeedback responseFeedback = new ResponseFeedback();
            responseFeedback.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewReport viewReport = new ViewReport();
            viewReport.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
