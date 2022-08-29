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
    public partial class WardenLogin : Form
    {
        public WardenLogin()
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dtb1 = new DataTable();
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            SQLiteCommand sqlcmd;
            SQLiteDataAdapter sqlDA;
            try
            {
                sqlcmd = new SQLiteCommand("Select * from warden where username=@name and password=@pass", sqlite_conn);
                sqlDA = new SQLiteDataAdapter(sqlcmd);
                sqlcmd.Parameters.AddWithValue("@name", textusername.Text);
                sqlcmd.Parameters.AddWithValue("@pass", textPasssword.Text);
                sqlDA.Fill(dtb1);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("No Data Found!" + ex.Message);
            }
           
            if (dtb1.Rows.Count > 0)
            {
                WardenDashboard wardenDashboard = new WardenDashboard();
                wardenDashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Error");
            }
        }
    }
}
