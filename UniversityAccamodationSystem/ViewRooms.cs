using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityAccamodationSystem
{
    public partial class ViewRooms : Form
    {
        public ViewRooms()
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

        private void ViewRooms_Load(object sender, EventArgs e)
        {
            string startupPath = Environment.CurrentDirectory;
            string path1 = @startupPath + "\\House.jpg";
            pictureBox1.ImageLocation = path1;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.ImageLocation = path1;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.ImageLocation = path1;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.ImageLocation = path1;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.ImageLocation = path1;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.ImageLocation = path1;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox7.ImageLocation = path1;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.ImageLocation = path1;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.ImageLocation = path1;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.ImageLocation = path1;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.ImageLocation = path1;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.ImageLocation = path1;
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;

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
                    string path2 = @startupPath + "\\House2.png";
                    if (dtb1.Rows[i]["RoomID"].ToString()=="1" && dtb1.Rows[i]["Block"].ToString()=="A")
                    {
                        pictureBox1.ImageLocation = path2;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (dtb1.Rows[i]["RoomID"].ToString() == "2" && dtb1.Rows[i]["Block"].ToString() == "A")
                    {
                        pictureBox2.ImageLocation = path2;
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (dtb1.Rows[i]["RoomID"].ToString() == "3" && dtb1.Rows[i]["Block"].ToString() == "A")
                    {
                        pictureBox3.ImageLocation = path2;
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (dtb1.Rows[i]["RoomID"].ToString() == "4" && dtb1.Rows[i]["Block"].ToString() == "A")
                    {
                        pictureBox4.ImageLocation = path2;
                        pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (dtb1.Rows[i]["RoomID"].ToString() == "5" && dtb1.Rows[i]["Block"].ToString() == "A")
                    {
                        pictureBox5.ImageLocation = path2;
                        pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (dtb1.Rows[i]["RoomID"].ToString() == "6" && dtb1.Rows[i]["Block"].ToString() == "A")
                    {
                        pictureBox6.ImageLocation = path2;
                        pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    }



                    if (dtb1.Rows[i]["RoomID"].ToString() == "1" && dtb1.Rows[i]["Block"].ToString() == "B")
                    {
                        pictureBox7.ImageLocation = path2;
                        pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (dtb1.Rows[i]["RoomID"].ToString() == "2" && dtb1.Rows[i]["Block"].ToString() == "B")
                    {
                        pictureBox8.ImageLocation = path2;
                        pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (dtb1.Rows[i]["RoomID"].ToString() == "3" && dtb1.Rows[i]["Block"].ToString() == "B")
                    {
                        pictureBox9.ImageLocation = path2;
                        pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (dtb1.Rows[i]["RoomID"].ToString() == "4" && dtb1.Rows[i]["Block"].ToString() == "B")
                    {
                        pictureBox10.ImageLocation = path2;
                        pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (dtb1.Rows[i]["RoomID"].ToString() == "5" && dtb1.Rows[i]["Block"].ToString() == "B")
                    {
                        pictureBox11.ImageLocation = path2;
                        pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (dtb1.Rows[i]["RoomID"].ToString() == "6" && dtb1.Rows[i]["Block"].ToString() == "B")
                    {
                        pictureBox12.ImageLocation = path2;
                        pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
