using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityAccamodationSystem
{
    public partial class AssignRoom : Form
    {
        public AssignRoom()
        {
            InitializeComponent();
            cmbBlock.SelectedIndex = 0;
            cmbRoomNo.SelectedIndex = 0;
            startdate.Format = DateTimePickerFormat.Short;
            enddate.Format = DateTimePickerFormat.Short;
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
        public Boolean checkAvailibilityStdID()
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
                    if (dtb1.Rows[i]["StdID"].ToString() == textStdID.Text)
                    {
                        isAvailable = false;
                    }
                }

            }
            return isAvailable;
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
                    if (dtb1.Rows[i]["RoomID"].ToString() == cmbRoomNo.Text && dtb1.Rows[i]["Block"].ToString() == cmbBlock.Text)
                    {
                        isAvailable = false;
                    }
                }
                if (isAvailable == true)
                {
                    DateTime startDate = startdate.Value;
                    DateTime endDate = enddate.Value;
                    if (textStdID.Text != "" && textStdName.Text != "")
                    {
                        if (startDate < endDate)
                    {
                            if(checkAvailibilityStdID()==false)
                            {
                                SQLiteCommand sqlite_cmd;
                                sqlite_cmd = sqlite_conn.CreateCommand();
                                sqlite_cmd.CommandText = "insert into AccomodationBooking (RoomID, StudentID, StudentName,Block,Status,startDate,endDate) VALUES($param1,$param2,$param3,$param4,$param5,$param6,$param7)";
                                sqlite_cmd.Parameters.AddWithValue("$param1", cmbRoomNo.Text);
                                sqlite_cmd.Parameters.AddWithValue("$param2", textStdID.Text);
                                sqlite_cmd.Parameters.AddWithValue("$param3", textStdName.Text);
                                sqlite_cmd.Parameters.AddWithValue("$param4", cmbBlock.Text);
                                sqlite_cmd.Parameters.AddWithValue("$param5", "Occupied");
                                sqlite_cmd.Parameters.AddWithValue("$param6", startdate.Value);
                                sqlite_cmd.Parameters.AddWithValue("$param7", enddate.Value);
                                int res = sqlite_cmd.ExecuteNonQuery();
                                if (res > 0)
                                {
                                    MessageBox.Show("Room Allocated Successfully", "Message");
                                }
                            }
                       else
                            {
                                MessageBox.Show("No student exsist against this Roll Number", "Error");
                            }
                    }
                    else
                    {
                        MessageBox.Show("Start Date is Less then End Date.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Fill Up all fields.", "Error");
                }


            }
                else
                {
                    MessageBox.Show("This Room is not Available","Message");
                }
            }
            else
            {
                if (isAvailable == true)
                {
                    DateTime startDate = startdate.Value;
                    DateTime endDate = enddate.Value;
                    if (textStdID.Text != "" && textStdName.Text != "")
                    {
                        if (startDate < endDate)
                        {
                            SQLiteCommand sqlite_cmd;
                            sqlite_cmd = sqlite_conn.CreateCommand();
                            sqlite_cmd.CommandText = "insert into AccomodationBooking (RoomID, StudentID, StudentName,Block,Status,startDate,endDate) VALUES($param1,$param2,$param3,$param4,$param5,$param6,$param7)";
                            sqlite_cmd.Parameters.AddWithValue("$param1", cmbRoomNo.Text);
                            sqlite_cmd.Parameters.AddWithValue("$param2", textStdID.Text);
                            sqlite_cmd.Parameters.AddWithValue("$param3", textStdName.Text);
                            sqlite_cmd.Parameters.AddWithValue("$param4", cmbBlock.Text);
                            sqlite_cmd.Parameters.AddWithValue("$param5", "Occupied");
                            sqlite_cmd.Parameters.AddWithValue("$param6", startdate.Value);
                            sqlite_cmd.Parameters.AddWithValue("$param7", enddate.Value);
                            int res = sqlite_cmd.ExecuteNonQuery();
                            if (res > 0)
                            {
                                MessageBox.Show("Room Allocated Successfully", "Message");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Start Date is Less then End Date.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fill Up all fields.", "Error");
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkAvailibility();
        }

        private void cmbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
