using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_List.Models
{
    public class Student
    {
        public string ConverImage { get; set; }
        public string Name { get; set; }
        public string BirthDay { get; set; }
    }
    public class StudentManage
    {
        public static List<Student> GetStudents()
        {
            var students = new List<Student>();
            students.Add(new Student { Name = "Nguyen van a",BirthDay="10/06/2021",ConverImage= "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/User_icon_2.svg/220px-User_icon_2.svg.png"});
            students.Add(new Student { Name = "Nguyen van B",BirthDay="10/06/2021",ConverImage= "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/User_icon_2.svg/220px-User_icon_2.svg.png"});
            students.Add(new Student { Name = "Nguyen van C",BirthDay="10/06/2021",ConverImage= "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/User_icon_2.svg/220px-User_icon_2.svg.png"});
            return students;
        }
    }


}
