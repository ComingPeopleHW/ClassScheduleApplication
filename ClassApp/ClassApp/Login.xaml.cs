using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Media;

namespace ClassApp
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        // Sql->Week
        private int Week { get; set; }

        // Sql->ID
        private int ID { get; set; }

        // Sql->UserName
        private string UserName { get; set; }

        public Login(int week, int id, string userName)
        {
            InitializeComponent();
            monthLable.Content = Convert.ToInt32(DateTime.Now.Month) + "月"; //获取月份
            weekComboBox.SelectedIndex = week;
            Week = week;
            ID = id;
            UserName = userName;
            this.Title = "课程表";
            ReadSqlUserClassTime();
            ButtonVisibility();
        }

        //close button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //return button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow test = new MainWindow();
            test.Show();
            this.Close();
        }

        //Week
        private void weekComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string dBWeek = "";
            SqlConnection sqlCon = new SqlConnection() //连接
            {
                ConnectionString = @"server=119.29.217.67;DataBase=Csharp;User Id=csharp;Password=csharp;"
            };
            //Week应放哪个表中？
            dBWeek = string.Format("update UserInformation set Week={0} where ID={1}", weekComboBox.SelectedIndex, ID);
            SqlCommand sqlCmd = new SqlCommand(dBWeek, sqlCon);  //修改对应ID值的Week
            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        //从sql中读取课程信息
        private void ReadSqlUserClassTime()
        {
            SqlConnection sqlCon = new SqlConnection()
            {
                ConnectionString = @"server=119.29.217.67;DataBase=Csharp;User Id=csharp;Password=csharp;"
            };
            SqlCommand sqlCmd = new SqlCommand($"select * from {UserName}_ClassTime", sqlCon);
            sqlCon.Open();
            SqlDataReader sDR = sqlCmd.ExecuteReader();
            while (sDR.Read())
            {
                switch (sDR["ClassTime"].ToString())
                {
                    case "1":
                        switch (sDR["WeekDay"].ToString())
                        {
                            case "1":
                                _11.Text = sDR["ClassName"].ToString();
                                _11ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "2":
                                _12.Text = sDR["ClassName"].ToString();
                                _12ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "3":
                                _13.Text = sDR["ClassName"].ToString();
                                _13ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "4":
                                _14.Text = sDR["ClassName"].ToString();
                                _14ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "5":
                                _15.Text = sDR["ClassName"].ToString();
                                _15ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "6":
                                _16.Text = sDR["ClassName"].ToString();
                                _16ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "7":
                                _17.Text = sDR["ClassName"].ToString();
                                _17ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                        }
                        break;
                    case "2":
                        switch(sDR["WeekDay"].ToString())
                        {
                            case "1":
                                _21.Text = sDR["ClassName"].ToString();
                                _21ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "2":
                                _22.Text = sDR["ClassName"].ToString();
                                _22ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "3":
                                _23.Text = sDR["ClassName"].ToString();
                                _23ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "4":
                                _24.Text = sDR["ClassName"].ToString();
                                _24ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "5":
                                _25.Text = sDR["ClassName"].ToString();
                                _25ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "6":
                                _26.Text = sDR["ClassName"].ToString();
                                _26ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "7":
                                _27.Text = sDR["ClassName"].ToString();
                                _27ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                        }
                        break;
                    case "3":
                        switch (sDR["WeekDay"].ToString())
                        {
                            case "1":
                                _31.Text = sDR["ClassName"].ToString();
                                _31ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "2":
                                _32.Text = sDR["ClassName"].ToString();
                                _32ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "3":
                                _33.Text = sDR["ClassName"].ToString();
                                _33ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "4":
                                _34.Text = sDR["ClassName"].ToString();
                                _34ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "5":
                                _35.Text = sDR["ClassName"].ToString();
                                _35ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "6":
                                _36.Text = sDR["ClassName"].ToString();
                                _36ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "7":
                                _37.Text = sDR["ClassName"].ToString();
                                _37ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                        }
                        break;
                    case "4":
                        switch(sDR["WeekDay"].ToString())
                        {
                            case "1":
                                _41.Text = sDR["ClassName"].ToString();
                                _41ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "2":
                                _42.Text = sDR["ClassName"].ToString();
                                _42ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "3":
                                _43.Text = sDR["ClassName"].ToString();
                                _43ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "4":
                                _44.Text = sDR["ClassName"].ToString();
                                _44ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "5":
                                _45.Text = sDR["ClassName"].ToString();
                                _45ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "6":
                                _46.Text = sDR["ClassName"].ToString();
                                _46ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                            case "7":
                                _47.Text = sDR["ClassName"].ToString();
                                _47ClassRoom.Text = sDR["ClassRoomes"].ToString();
                                break;
                        }
                        break;
                }
            }
        }

        //addClassButton和classLable的可见性
        private void ButtonVisibility()
        {
            if (_11.Text.ToString() != "")
            {
                addClassbutton11.Visibility = Visibility.Hidden;
                _11.Visibility = Visibility.Visible;
                _11ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _11.Visibility = Visibility.Hidden;
                _11ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_12.Text.ToString() != "")
            {
                addClassbutton12.Visibility = Visibility.Hidden;
                _12.Visibility = Visibility.Visible;
                _12ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _12.Visibility = Visibility.Hidden;
                _12ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_13.Text.ToString() != "")
            {
                addClassButton13.Visibility = Visibility.Hidden;
                _13.Visibility = Visibility.Visible;
                _13ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _13.Visibility = Visibility.Hidden;
                _13ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_14.Text.ToString() != "")
            {
                addClassButton14.Visibility = Visibility.Hidden;
                _14.Visibility = Visibility.Visible;
                _14ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _14.Visibility = Visibility.Hidden;
                _14ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_15.Text.ToString() != "")
            {
                addClassButton15.Visibility = Visibility.Hidden;
                _15.Visibility = Visibility.Visible;
                _15ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _15.Visibility = Visibility.Hidden;
                _15ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_16.Text.ToString() != "")
            {
                addClassButton16.Visibility = Visibility.Hidden;
                _16.Visibility = Visibility.Visible;
                _16ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _16.Visibility = Visibility.Hidden;
                _16ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_17.Text.ToString() != "")
            {
                addClassButton17.Visibility = Visibility.Hidden;
                _17.Visibility = Visibility.Visible;
                _17ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _17.Visibility = Visibility.Hidden;
                _17ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_21.Text.ToString() != "")
            {
                addClassButton21.Visibility = Visibility.Hidden;
                _21.Visibility = Visibility.Visible;
                _21ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _21.Visibility = Visibility.Hidden;
                _21ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_22.Text.ToString() != "")
            {
                addClassButton22.Visibility = Visibility.Hidden;
                _22.Visibility = Visibility.Visible;
                _22ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _22.Visibility = Visibility.Hidden;
                _22ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_23.Text.ToString() != "")
            {
                addClassButton23.Visibility = Visibility.Hidden;
                _23.Visibility = Visibility.Visible;
                _23ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _23.Visibility = Visibility.Hidden;
                _23ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_24.Text.ToString() != "")
            {
                addClassButton24.Visibility = Visibility.Hidden;
                _24.Visibility = Visibility.Visible;
                _24ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _24.Visibility = Visibility.Hidden;
                _24ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_25.Text.ToString() != "")
            {
                addClassButton25.Visibility = Visibility.Hidden;
                _25.Visibility = Visibility.Visible;
                _25ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _25.Visibility = Visibility.Hidden;
                _25ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_26.Text.ToString() != "")
            {
                addClassButton26.Visibility = Visibility.Hidden;
                _26.Visibility = Visibility.Visible;
                _26ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _26.Visibility = Visibility.Hidden;
                _26ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_27.Text.ToString() != "")
            {
                addClassButton27.Visibility = Visibility.Hidden;
                _27.Visibility = Visibility.Visible;
                _27ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _27.Visibility = Visibility.Hidden;
                _27ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_31.Text.ToString() != "")
            {
                addClassButton31.Visibility = Visibility.Hidden;
                _31.Visibility = Visibility.Visible;
                _31ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _31.Visibility = Visibility.Hidden;
                _31ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_32.Text.ToString() != "")
            {
                addClassButton32.Visibility = Visibility.Hidden;
                _32.Visibility = Visibility.Visible;
                _32ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _32.Visibility = Visibility.Hidden;
                _32ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_33.Text.ToString() != "")
            {
                addClassButton33.Visibility = Visibility.Hidden;
                _33.Visibility = Visibility.Visible;
                _33ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _33.Visibility = Visibility.Hidden;
                _33ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_34.Text.ToString() != "")
            {
                addClassButton34.Visibility = Visibility.Hidden;
                _34.Visibility = Visibility.Visible;
                _34ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _34.Visibility = Visibility.Hidden;
                _34ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_35.Text.ToString() != "")
            {
                addClassButton35.Visibility = Visibility.Hidden;
                _35.Visibility = Visibility.Visible;
                _35ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _35.Visibility = Visibility.Hidden;
                _35ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_36.Text.ToString() != "")
            {
                addClassButton36.Visibility = Visibility.Hidden;
                _36.Visibility = Visibility.Visible;
                _36ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _36.Visibility = Visibility.Hidden;
                _36ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_37.Text.ToString() != "")
            {
                addClassButton37.Visibility = Visibility.Hidden;
                _37.Visibility = Visibility.Visible;
                _37ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _37.Visibility = Visibility.Hidden;
                _37ClassRoom.Visibility = Visibility.Hidden;
            }
            
            if (_41.Text.ToString() != "")
            {
                addClassButton41.Visibility = Visibility.Hidden;
                _41.Visibility = Visibility.Visible;
                _41ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _41.Visibility = Visibility.Hidden;
                _41ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_42.Text.ToString() != "")
            {
                addClassButton42.Visibility = Visibility.Hidden;
                _42.Visibility = Visibility.Visible;
                _42ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _42.Visibility = Visibility.Hidden;
                _42ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_43.Text.ToString() != "")
            {
                addClassButton43.Visibility = Visibility.Hidden;
                _43.Visibility = Visibility.Visible;
                _43ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _43.Visibility = Visibility.Hidden;
                _43ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_44.Text.ToString() != "")
            {
                addClassButton44.Visibility = Visibility.Hidden;
                _44.Visibility = Visibility.Visible;
                _44ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _44.Visibility = Visibility.Hidden;
                _44ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_45.Text.ToString() != "")
            {
                addClassButton45.Visibility = Visibility.Hidden;
                _45.Visibility = Visibility.Visible;
                _45ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _45.Visibility = Visibility.Hidden;
                _45ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_46.Text.ToString() != "")
            {
                addClassButton46.Visibility = Visibility.Hidden;
                _46.Visibility = Visibility.Visible;
                _46ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _46.Visibility = Visibility.Hidden;
                _46ClassRoom.Visibility = Visibility.Hidden;
            }

            if (_47.Text.ToString() != "")
            {
                addClassButton47.Visibility = Visibility.Hidden;
                _47.Visibility = Visibility.Visible;
                _47ClassRoom.Visibility = Visibility.Visible;
            }
            else
            {
                _47.Visibility = Visibility.Hidden;
                _47ClassRoom.Visibility = Visibility.Hidden;
            }
        }

        //委托事件处理
        void addClassWindow_Closed()
        {
            ReadSqlUserClassTime();
        }

        #region 11button
        private void addClassbutton11_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "1", "1");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassbutton11_MouseEnter_1(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassbutton11.Content = "+";
            addClassbutton11.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassbutton11_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassbutton11.Content = "";
            addClassbutton11.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 12button
        private void addClassbutton12_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "1", "2");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassbutton12_MouseEnter_1(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassbutton12.Content = "+";
            addClassbutton12.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));

        }

        private void addClassbutton12_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassbutton12.Content = "";
            addClassbutton12.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 13button
        private void addclassButton13_click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "1", "3");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton13_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton13.Content = "+";
            addClassButton13.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton13_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton13.Content = "";
            addClassButton13.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 14button
        private void addclassButton14_click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "1", "4");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton14_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton14.Content = "+";
            addClassButton14.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton14_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton14.Content = "";
            addClassButton14.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }

        #endregion

        #region 15button
        private void addclassButton15_click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "1", "5");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton15_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton15.Content = "+";
            addClassButton15.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton15_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton15.Content = "";
            addClassButton15.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }
        #endregion

        #region 16button
        private void addclassButton16_click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "1", "6");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton16_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton16.Content = "+";
            addClassButton16.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton16_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton16.Content = "";
            addClassButton16.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 17button
        private void addclassButton17_click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "1", "7");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton17_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton17.Content = "+";
            addClassButton17.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton17_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton17.Content = "";
            addClassButton17.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 21button
        private void addclassButton21_click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "2", "1");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton21_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton21.Content = "+";
            addClassButton21.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton21_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton21.Content = "";
            addClassButton21.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 22button
        private void addClassButton22_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "2", "2");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton22_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton22.Content = "+";
            addClassButton22.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton22_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton22.Content = "";
            addClassButton22.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }

        #endregion

        #region 23button
        private void addClassButton23_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "2", "3");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton23_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton23.Content = "+";
            addClassButton23.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton23_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton23.Content = "";
            addClassButton23.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 24button
        private void addClassButton24_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "2", "4");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton24_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton24.Content = "+";
            addClassButton24.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton24_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton24.Content = "";
            addClassButton24.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 25button
        private void addClassButton25_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "2", "5");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton25_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton25.Content = "+";
            addClassButton25.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton25_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton25.Content = "";
            addClassButton24.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 26button
        private void addClassButton26_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton26.Content = "";
            addClassButton26.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }

        private void addClassButton26_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton26.Content = "+";
            addClassButton26.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton26_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "2", "6");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }
        #endregion

        #region 27button
        private void addClassButton27_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "2", "7");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton27_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton27.Content = "+";
            addClassButton27.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton27_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton27.Content = "";
            addClassButton27.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 31button
        private void addClassButton31_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "3", "1");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton31_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton31.Content = "+";
            addClassButton31.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton31_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton31.Content = "";
            addClassButton31.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 32button
        private void addClassButton32_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "3", "2");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton32_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton32.Content = "+";
            addClassButton32.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton32_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton32.Content = "";
            addClassButton32.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 33button
        private void addClassButton33_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "3", "3");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton33_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton33.Content = "+";
            addClassButton33.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton33_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton33.Content = "";
            addClassButton33.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 34button
        private void addClassButton34_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "3", "4");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton34_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton34.Content = "+";
            addClassButton34.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton34_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton34.Content = "";
            addClassButton34.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 35button
        private void addClassButton35_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "3", "5");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton35_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton35.Content = "+";
            addClassButton35.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton35_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton35.Content = "";
            addClassButton35.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 36button
        private void addClassButton36_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "3", "6");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton36_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton36.Content = "+";
            addClassButton36.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton36_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton36.Content = "";
            addClassButton36.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 37button
        private void addClassButton37_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "3", "7");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton37_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton37.Content = "+";
            addClassButton37.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton37_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton37.Content = "";
            addClassButton37.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 41button
        private void addClassButton41_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "4", "1");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton41_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton41.Content = "+";
            addClassButton41.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton41_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton41.Content = "";
            addClassButton41.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 42button
        private void addClassButton42_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "4", "2");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton42_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton42.Content = "+";
            addClassButton42.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton42_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton42.Content = "";
            addClassButton42.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 43button
        private void addClassButton43_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "4", "3");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton43_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton43.Content = "+";
            addClassButton43.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton43_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton43.Content = "";
            addClassButton43.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 44button
        private void addClassButton44_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "4", "4");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton44_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton44.Content = "+";
            addClassButton44.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton44_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton44.Content = "";
            addClassButton44.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 45button
        private void addClassButton45_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "4", "5");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton45_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton45.Content = "+";
            addClassButton45.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton45_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton45.Content = "";
            addClassButton45.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 46button
        private void addClassButton46_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "4", "6");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton46_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton46.Content = "+";
            addClassButton46.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton46_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton46.Content = "";
            addClassButton46.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        #endregion

        #region 47button
        private void addClassButton47_Click(object sender, RoutedEventArgs e)
        {
            AddClass addClassWindow = new AddClass(UserName, "4", "7");
            addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
            addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
            addClassWindow.Show();
        }

        private void addClassButton47_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton47.Content = "+";
            addClassButton47.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE81010"));
        }

        private void addClassButton47_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            addClassButton47.Content = "";
            addClassButton47.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
#endregion
    }
}
