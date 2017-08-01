using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ClassApp
{
    public delegate void ChangeLableTextHandler();

    public delegate void VisibilityHandler();

    /// <summary>
    /// AddClass.xaml 的交互逻辑
    /// </summary>
    public partial class AddClass : Window
    {
        private string UserName { get; set; }

        private string WeekDay { get; set; }

        private string ClassTime { get; set; }

        public event ChangeLableTextHandler ChangeLableEvent;

        public event VisibilityHandler VisibilityEvent;

        public AddClass(string userName,string classTime,string weekDay)
        {
            InitializeComponent();
            UserName = userName;
            WeekDay = weekDay;
            ClassTime = classTime;
        }

        private void addClassButton_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection()
            {
                ConnectionString = @"server=119.29.217.67;DataBase=Csharp;User Id=csharp;Password=csharp;"
            };
            SqlCommand sqlCmd = new SqlCommand($"insert into {UserName}_ClassTime (UserName,WeekDay,ClassTime,ClassName,ClassRoomes,ClassTeacher) values(\'{UserName}\',\'{WeekDay}\',\'{ClassTime}\',\'{classNameTextBox.Text}\',\'{classRoomTextBox.Text}\',\'{classTeacherTextBox.Text}\')",sqlCon);
            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();

            if (ChangeLableEvent != null&& VisibilityEvent!=null)
            {
                ChangeLableEvent();
                VisibilityEvent();
            }
            sqlCon.Close();
            this.Close();
        }

    }
}
