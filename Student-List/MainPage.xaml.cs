using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Student_List.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Student_List
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Student> ListStudent;
        public MainPage()
        {
            this.InitializeComponent();
            ListStudent = StudentManage.GetStudents();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            var student = new Student();
            student.Name = NameTextBox.Text;
            student.BirthDay= BirthDayTextBox.Text;
            student.ConverImage = AvatarTextBox.Text;
            ListStudent.Add(student);
            ListStudent.Add(new Student { Name = "Nguyen van C", BirthDay = "10/06/2021", ConverImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/User_icon_2.svg/220px-User_icon_2.svg.png" });
        }
    }
}
