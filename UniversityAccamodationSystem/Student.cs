using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityAccamodationSystem
{
    class Student
    {
        public String stdID { get; set; }
        public String stdName { get; set; }
        public String Department { get; set; }
        public String Semester { get; set; }

        public Student(String stdID,String stdName,String Department,String Semester)
        {
            this.stdID = stdID;
            this.stdName = stdName;
            this.Department = Department;
            this.Semester = Semester;
        }


    }
}
