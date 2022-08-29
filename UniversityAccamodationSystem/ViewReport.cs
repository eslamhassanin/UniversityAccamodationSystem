using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace UniversityAccamodationSystem
{
    public partial class ViewReport : Form
    {
        public ViewReport()
        {
            InitializeComponent();
        }

        SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=DBUniAccomodation.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return sqlite_conn;
        }
        DataTable dtb1;
        public void ShowData_Load()
        {
            dgvFeedback.Rows.Clear();
            dgvFeedback.Refresh();
            dtb1 = new DataTable();
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            SQLiteDataAdapter sqlDA = new SQLiteDataAdapter("Select * from AccomodationBooking", sqlite_conn);
            try
            {
                sqlDA.Fill(dtb1);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("No Data Found!" + ex.Message);
            }
            if (dtb1.Rows.Count > 0)
            {
                for (int i = 0; i < dtb1.Rows.Count; i++)
                {
                    String Id = dtb1.Rows[i]["StudentID"].ToString();
                    String stdName = dtb1.Rows[i]["StudentName"].ToString();
                    String startDate = dtb1.Rows[i]["startDate"].ToString();
                    String endDate = dtb1.Rows[i]["endDate"].ToString();
                    String status = dtb1.Rows[i]["status"].ToString();
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvFeedback);  // this line was missing
                    row.Cells[0].Value = Id;
                    row.Cells[1].Value = stdName;
                    row.Cells[2].Value = startDate;
                    row.Cells[3].Value = endDate;
                    row.Cells[4].Value = status;
                    dgvFeedback.Rows.Add(row);
                }

            }
        }

        private void ViewReport_Load(object sender, EventArgs e)
        {
            ShowData_Load();
        }

        private void dgvFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
