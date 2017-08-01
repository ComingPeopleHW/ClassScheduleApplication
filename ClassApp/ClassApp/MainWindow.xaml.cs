using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace ClassApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Class";
            TextBox1.Text = "admin";
            PasswordBox.Password = "admin";
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string userName = ""; //Sql->UserName
            int week = -1;  //Sql->Week
            int id = 0;  //Sql->ID
            int accountNumberState = 0;  //账号登录状态
            SqlConnection sqlCon = new SqlConnection() //连接数据库
            {
                ConnectionString = @"server=xxxxxx;DataBase=xxxxx;User Id=xxxxx;Password=xxxxx;"
            };
            SqlCommand sqlCmd = new SqlCommand("select * from dbo.UserInformation", sqlCon);
            sqlCon.Open();
            SqlDataReader sdr = sqlCmd.ExecuteReader();
            if (TextBox1.Text == "")
            {
                MessageBox.Show("账号不可为空!");
            }
            else
            {
                while (sdr.Read())
                {
                    if (TextBox1.Text == sdr["UserName"].ToString().Trim() && PasswordBox.Password.Trim()==sdr["PassWord"].ToString().Trim())
                    {
                        //accountNumber Week&ID
                        week = Convert.ToInt32(sdr["Week"].ToString());
                        id = Convert.ToInt32(sdr["ID"].ToString());
                        userName = sdr["UserName"].ToString();
                        accountNumberState = 1;
                        MessageBox.Show("登录成功");
                        break;
                    }
                }
                
                if (accountNumberState == 0)
                {
                    MessageBox.Show("账号或密码错误");
                }
            }
            if(accountNumberState==1)
            {
                MessageBox.Show("登录成功");
                ////初始过程中传入账号ID等
                //Login loginWindow = new Login(week,id,userName);
                //sqlCon.Close();
                //loginWindow.Show();
                //this.Close();
            }
            else
            {
                sqlCon.Close();
       
            }
        }

        private void registeredButton_Click(object sender, RoutedEventArgs e)
        {
            Registered registerdWindow = new Registered();
            registerdWindow.Show();
            this.Close();
        }
    }
}
