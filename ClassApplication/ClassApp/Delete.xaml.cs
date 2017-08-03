using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ClassApp
{
    /// <summary>
    /// Delete.xaml 的交互逻辑
    /// </summary>
    public partial class Delete : Window
    {
        public delegate void ChangeLableTextHandler();
        public delegate void VisibilityHandler();
        public delegate void AddButtonVisibilityHandler();

        private string WeekDay { get; set; }

        private string ClassTime { get; set; }

        private string UserName { get; set; }

        public event ChangeLableTextHandler ChangeLableEvent;
        public event VisibilityHandler VisibilityEvent;
        public event AddButtonVisibilityHandler AddButtonEvent;
        public Delete(string classTime,string weekDay,string userName)
        {
            InitializeComponent();
            WeekDay = weekDay;
            ClassTime = classTime;
            UserName = userName;
        }

        private void classNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (classNameTextBox.Text.Length > 20)
            {
                PromptInformationLable.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF0606"));
                PromptInformationLable.Content = "课程名长度不能超过20个字母或10个汉字";
            }
            else if (classNameTextBox.Text.Length <= 0)
            {
                PromptInformationLable.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF0606"));
                PromptInformationLable.Content = "课程名长度不能小于0个字母或汉字";
            }
            else
            {
                PromptInformationLable.Content = "";
            }
        }


        private void changeClassButton_Click(object sender, RoutedEventArgs e)
        {
            string className = classNameTextBox.Text;
            string classRoomes = classRoomTextBox.Text;
            string sCmdString = string.Format(@"UPDATE {0}_ClassTime SET ClassName='{1}',ClassRoomes='{2}' WHERE WeekDay='{3}' AND ClassTime='{4}'",UserName,classNameTextBox.Text,classRoomTextBox.Text,WeekDay,ClassTime);
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
                SqlConnection sCon = new SqlConnection()
                {
                    ConnectionString = @"server=119.29.217.67;DataBase=Csharp;User Id=csharp;Password=csharp;"
                };
                SqlCommand sCmd=new SqlCommand(sCmdString,sCon);
                sCon.Open();
                sCmd.ExecuteNonQuery();
                sCon.Close();

                if(ChangeLableEvent!=null && VisibilityEvent!=null)
                {
                    ChangeLableEvent();
                    
                    VisibilityEvent();
                }
                this.Close();
            }
        }

        private void deleteClassButton_Click(object sender, RoutedEventArgs e)
        {
            //public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button);
            // caption=title
            if (MessageBox.Show("确定删除本节课程?","提示",MessageBoxButton.OKCancel)==MessageBoxResult.OK)
            {
                SqlConnection sCon = new SqlConnection()
                {
                    ConnectionString = @"server=119.29.217.67;DataBase=Csharp;User Id=csharp;Password=csharp;"
                };
                SqlCommand sCmd = new SqlCommand($@"DELETE FROM {UserName}_ClassTime WHERE ClassTime='{ClassTime}' AND WeekDay='{WeekDay}'",sCon);
                sCon.Open();
                sCmd.ExecuteNonQuery();
                sCon.Close();
                MessageBox.Show("删除成功");
                if (ChangeLableEvent != null & VisibilityEvent != null && AddButtonEvent != null)
                {
                    ChangeLableEvent();
                    AddButtonEvent();
                    VisibilityEvent();
                }
                this.Close();
                this.Close();
            }
        }
    }
}
