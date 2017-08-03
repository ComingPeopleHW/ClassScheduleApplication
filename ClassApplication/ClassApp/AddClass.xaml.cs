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

        private Login FatherWindow { get; set; }

        public event ChangeLableTextHandler ChangeLableEvent;

        public event VisibilityHandler VisibilityEvent;

        public AddClass(string userName,string classTime,string weekDay,Login fatherWindow)
        {
            InitializeComponent();
            UserName = userName;
            WeekDay = weekDay;
            ClassTime = classTime;
            FatherWindow = fatherWindow;
        }

        private void addClassButton_Click(object sender, RoutedEventArgs e)
        {
            if (classNameTextBox.Text.Length > 20)
            {
                MessageBox.Show("课程名长度不能超过20个字母或10个汉字");
            }
            else if(classNameTextBox.Text.Length <=0)
            {
                MessageBox.Show("课程名长度不能小于0个字母或汉字");
            }
            else
            {
                SqlConnection sqlCon = new SqlConnection()
                {
                    ConnectionString = @"server=119.29.217.67;DataBase=Csharp;User Id=csharp;Password=csharp;"
                };
                SqlCommand sqlCmd = new SqlCommand($"insert into {UserName}_ClassTime (UserName,WeekDay,ClassTime,ClassName,ClassRoomes,ClassTeacher) values(\'{UserName}\',\'{WeekDay}\',\'{ClassTime}\',\'{classNameTextBox.Text}\',\'{classRoomTextBox.Text}\',\'{classTeacherTextBox.Text}\')", sqlCon);
                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();

                if (ChangeLableEvent != null && VisibilityEvent != null)
                {
                    ChangeLableEvent();
                    VisibilityEvent();
                }

                FatherWindow.DeleteButtonVisibility();
                sqlCon.Close();
                this.Close();
            }
        }

        private void classNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (classNameTextBox.Text.Length > 20)
            {
                PromptInformationLable.Foreground=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF0606"));
                PromptInformationLable.Content = "课程名长度不能超过20个字母或10个汉字";
            }
            else if(classNameTextBox.Text.Length <=0)
            {
                PromptInformationLable.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF0606"));
                PromptInformationLable.Content = "课程名长度不能小于0个字母或汉字";
            }
            else
            {
                PromptInformationLable.Content = "";
            }
        }
    }
}
