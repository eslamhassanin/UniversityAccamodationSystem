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
    public partial class WriteFeedback : Form
    {
        public WriteFeedback()
        {
            InitializeComponent();
            cmbRequest.SelectedIndex = 0;
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
        public void checkAvailibility()
        {
            Boolean isAvailable = true;
            DataTable dtb1 = new DataTable();
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            SQLiteCommand sqlcmd;
            SQLiteDataAdapter sqlDA;
            try
            {
                sqlcmd = new SQLiteCommand("Select * from Student", sqlite_conn);
                sqlDA = new SQLiteDataAdapter(sqlcmd);
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
                    if (dtb1.Rows[i]["StdID"].ToString() == textstdID.Text)
                    {
                        isAvailable = false;
                    }
                }
                if (isAvailable == false)
                {
                    if (textstdID.Text != "" && cmbRequest.Text != "" && textDescription.Text!="")
                    {
                            SQLiteCommand sqlite_cmd;
                            sqlite_cmd = sqlite_conn.CreateCommand();
                            sqlite_cmd.CommandText = "insert into Feedback (StdID, Request,Description,Status) VALUES($param1,$param2,$param3,$param4)";
                            sqlite_cmd.Parameters.AddWithValue("$param1", textstdID.Text);
                            sqlite_cmd.Parameters.AddWithValue("$param2", cmbRequest.Text);
                            sqlite_cmd.Parameters.AddWithValue("$param3", textDescription.Text);
                            sqlite_cmd.Parameters.AddWithValue("$param4", "Pending");
                            int res = sqlite_cmd.ExecuteNonQuery();
                            if (res > 0)
                            {
                                MessageBox.Show("Request Posted Successfully", "Message");
                            }
                    }
                    else
                    {
                        MessageBox.Show("Fill Up all fields.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("This Roll# is not in list\nWrite Correct Roll#", "Message");
                }
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            checkAvailibility();
        }

        private void textstdID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
