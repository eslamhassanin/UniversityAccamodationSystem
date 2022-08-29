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
    public partial class ViewFeedbackstatus : Form
    {
        public ViewFeedbackstatus()
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
            SQLiteDataAdapter sqlDA = new SQLiteDataAdapter("Select * from Feedback", sqlite_conn);
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
                    String id = dtb1.Rows[i]["StdID"].ToString();
                    String request = dtb1.Rows[i]["Request"].ToString();
                    String desc = dtb1.Rows[i]["Description"].ToString();
                    String status = dtb1.Rows[i]["Status"].ToString();
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvFeedback);  // this line was missing
                    row.Cells[0].Value = id;
                    row.Cells[1].Value = request;
                    row.Cells[2].Value = desc;
                    row.Cells[3].Value = status;
                    dgvFeedback.Rows.Add(row);
                }

            }
        }

        private void ViewFeedbackstatus_Load(object sender, EventArgs e)
        {
            ShowData_Load();
        }
    }
}
