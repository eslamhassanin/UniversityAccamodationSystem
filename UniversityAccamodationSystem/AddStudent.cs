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
    public partial class AddStudent : Form
    {
        public AddStudent()
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
        

        public void addStudent(String stdid,String Name,String Dep,String Semester)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "insert into Student (StdID, StdName, Department,Semester) VALUES($param1,$param2,$param3,$param4)";
            sqlite_cmd.Parameters.AddWithValue("$param1", stdid);
            sqlite_cmd.Parameters.AddWithValue("$param2", Name);
            sqlite_cmd.Parameters.AddWithValue("$param3", Dep);
            sqlite_cmd.Parameters.AddWithValue("$param4", Semester);
            int res = sqlite_cmd.ExecuteNonQuery();
            if (res > 0)
            {
                MessageBox.Show("Student Added Successfully", "Message");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(textstdID.Text!="" && textstdName.Text!="" && textDep.Text!="" && textSemester.Text!="")
            {
                
                    Student student = new Student(textstdID.Text, textstdName.Text, textDep.Text, textSemester.Text);
                    addStudent(student.stdID, student.stdName, student.Department, student.Semester);
               
            }
            else
            {
                MessageBox.Show("Fillup all form", "Error");
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
