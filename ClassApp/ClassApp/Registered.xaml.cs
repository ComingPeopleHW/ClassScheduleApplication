using System;
using System.Data.SqlClient;
using System.Windows;

namespace ClassApp
{
    /// <summary>
    /// Registered.xaml 的交互逻辑
    /// </summary>
    public partial class Registered : Window
    {
        public Registered()
        {
            InitializeComponent();
            Random random = new Random();
            verificationLable1.Content = random.Next(0, 50).ToString();
            verificationLable3.Content = random.Next(0, 50).ToString();
        }

        //'取消'button
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        //'注册'button
        private void registeredButton_Click(object sender, RoutedEventArgs e)
        {
            string classRowAndColumn = "";
            string userName = "";
            if (AccountCorrectness())
            {
                MessageBox.Show("1.账号&密码长度为3-16个字符 \n2.不包含空格");
            }
            else if (IsSameAccount())
            {
                Random random = new Random();
                // 
                registeredAccountNumberTextBox.Text = null;
                registeredPassWordBox.Password = null;
                checkPassWordBox.Password = null;
                VerificationCodeTextBox.Text = null;
                verificationLable5.Content = null;
                verificationLable1.Content = random.Next(0, 50).ToString();
                verificationLable3.Content = random.Next(0, 50).ToString();

                MessageBox.Show("账号已存在,请重新输入");
            }
            else if (registeredPassWordBox.Password != checkPassWordBox.Password)
            {
                MessageBox.Show("两次密码不一致");
            }
            else if (verificationLable5.Content.ToString() == "×" || verificationLable5.Content.ToString() == "")
            {
                MessageBox.Show("验证码错误");
            }
            else  //数据库的操作
            {
                SqlConnection sqlCon = new SqlConnection() //连接数据库
                {
                    ConnectionString = @"server=xxxxxx;DataBase=xxxxxx;User Id=xxxxx;Password=xxxxx;"
                };
                string addAcountToDB = "";
                addAcountToDB = $"INSERT INTO UserInformation(UserName,PassWord,Week) VALUES (\'{registeredAccountNumberTextBox.Text}\',\'{registeredPassWordBox.Password}\',0)";
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand(addAcountToDB, sqlCon);
                sqlCmd.ExecuteNonQuery();  //保存INSERT操作

                //读取用户名
                SqlCommand sqlCmd1 = new SqlCommand("select top 1 UserName from UserInformation order by ID desc", sqlCon);
                SqlDataReader sDR = sqlCmd1.ExecuteReader();
                sDR.Read();
                userName = sDR["UserName"].ToString();
                sDR.Close();
                

                //为用户在sql server中建立课程表
                classRowAndColumn = $@"create table {userName}_ClassTime (UserName nvarchar(18),WeekDay nvarchar(6),ClassTime nvarchar(6),ClassName nvarchar(20),ClassRoomes nvarchar(20),ClassTeacher nvarchar(12));";
                SqlCommand sqlCmd2 = new SqlCommand(classRowAndColumn,sqlCon);
                sqlCmd2.ExecuteNonQuery();

                sqlCon.Close();
                
                MessageBox.Show("注册成功!");

                //注册成功后返回登录界面
                MainWindow mainWindow = new MainWindow(); 
                mainWindow.Show();
                this.Close();
            }
        }

        //注册账号的长度验证
        private bool AccountCorrectness()  
        {
            if(registeredAccountNumberTextBox.Text.Length > 18 || registeredAccountNumberTextBox.Text.Length<3)
            {
                return true;
            }

            if(registeredPassWordBox.Password.Length >18 || registeredPassWordBox.Password.Length < 3)
            {
                return true;
            }

            return false;
        }

        //验证码对错
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if(VerificationCodeTextBox.Text=="")
            {
                verificationLable5.Content = "×";
            }
            else if (Convert.ToInt32(verificationLable1.Content) + Convert.ToInt32(verificationLable3.Content.ToString()) == Convert.ToInt32(VerificationCodeTextBox.Text))
            {
                verificationLable5.Content = "√";
            }
            else
            {
                verificationLable5.Content = "×";
            }
        }

        //验证账号是否重复
        private bool IsSameAccount()
        {
            SqlConnection sqlCon = new SqlConnection() //连接数据库
            {
                ConnectionString = @"server=xxxxxx;DataBase=xxxxx;User Id=xxxxx;Password=xxxxx;"
            };
            sqlCon.Open();
            SqlCommand sqlCmd2 = new SqlCommand("select * from dbo.UserInformation", sqlCon);
            SqlDataReader sDR = sqlCmd2.ExecuteReader();
            while (sDR.Read())
            {
                
                if(registeredAccountNumberTextBox.Text==sDR["UserName"].ToString().Trim())
                {
                    sqlCon.Close();
                    sDR.Close();
                    return true;
                }
            }
            sqlCon.Close();  //关闭连接
            sDR.Close();
            return false;
        }
    }
}
