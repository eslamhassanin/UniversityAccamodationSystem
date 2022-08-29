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
    public partial class DeleteRoom : Form
    {
        public DeleteRoom()
        {
            InitializeComponent();
            cmbBlockDelete.SelectedIndex = 0;
            cmbRoomDelete.SelectedIndex = 0;
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
        public Boolean isAvailable(String Block, String Room)
        {
            Boolean roomisavailable = true;
            DataTable dtb1 = new DataTable();
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            SQLiteCommand sqlcmd;
            SQLiteDataAdapter sqlDA;
            try
            {
                sqlcmd = new SQLiteCommand("Select * from AccomodationBooking", sqlite_conn);
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
                    if (dtb1.Rows[i]["RoomID"].ToString() == Room && dtb1.Rows[i]["Block"].ToString() == Block)
                    {
                        roomisavailable = false;
                    }
                }
            }
            return roomisavailable;
        }
        public void deleteRoom(String Block, String Room)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "delete from AccomodationBooking where RoomID=@roomid and Block=@block";
            sqlite_cmd.Parameters.AddWithValue("@roomid", Room);
            sqlite_cmd.Parameters.AddWithValue("@block", Block);

            int res = 0;
            try
            {
                res = sqlite_cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlite_conn.Close();
            }
            if (res > 0)
            {
                MessageBox.Show("Room Deleted Successfully.", "Message");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(isAvailable(cmbBlockDelete.Text,cmbRoomDelete.Text)==false)
            {
                deleteRoom(cmbBlockDelete.Text, cmbRoomDelete.Text);
            }
            else
            {
                MessageBox.Show("Room is not Allocated Before", "Error");
            }
        }

        private void cmbRoomDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
