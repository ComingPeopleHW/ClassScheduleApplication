using System;
using System.Data;
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

            //...
            SqlDataReader sDR1 = sqlCmd.ExecuteReader();
            if (sDR1.Read() == false)
            {
                TextBlock();
            }
            sDR1.Close();

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
                        switch (sDR["WeekDay"].ToString())
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
                        switch (sDR["WeekDay"].ToString())
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
                    default:
                        TextBlock();
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
                addClassbutton11.Visibility = Visibility.Visible;
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
                addClassbutton12.Visibility = Visibility.Visible;
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
                addClassButton13.Visibility = Visibility.Visible;
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
                addClassButton14.Visibility = Visibility.Visible;
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
                addClassButton15.Visibility = Visibility.Visible;
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
                addClassButton16.Visibility = Visibility.Visible;
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
                addClassButton17.Visibility = Visibility.Visible;
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
                addClassButton21.Visibility = Visibility.Visible;
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
                addClassButton22.Visibility = Visibility.Visible;
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
                addClassButton23.Visibility = Visibility.Visible;
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
                addClassButton24.Visibility = Visibility.Visible;
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
                addClassButton25.Visibility = Visibility.Visible;
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
                addClassButton26.Visibility = Visibility.Visible;
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
                addClassButton27.Visibility = Visibility.Visible;
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
                addClassButton31.Visibility = Visibility.Visible;
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
                addClassButton32.Visibility = Visibility.Visible;
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
                addClassButton33.Visibility = Visibility.Visible;
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
                addClassButton34.Visibility = Visibility.Visible;
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
                addClassButton35.Visibility = Visibility.Visible;
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
                addClassButton36.Visibility = Visibility.Visible;
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
                addClassButton37.Visibility = Visibility.Visible;
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
                addClassButton41.Visibility = Visibility.Visible;
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
                addClassButton42.Visibility = Visibility.Visible;
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
                addClassButton43.Visibility = Visibility.Visible;
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
                addClassButton44.Visibility = Visibility.Visible;
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
                addClassButton45.Visibility = Visibility.Visible;
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
                addClassButton46.Visibility = Visibility.Visible;
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
                addClassButton47.Visibility = Visibility.Visible;
                _47.Visibility = Visibility.Hidden;
                _47ClassRoom.Visibility = Visibility.Hidden;
            }
        }

        //DeleteButton可见性
        public void DeleteButtonVisibility()
            {
                if (_11.Text.Length > 0)
                {
                    deleteButton11.Visibility = Visibility.Visible;
                }
                if (_12.Text.Length > 0)
                {
                    deleteButton12.Visibility = Visibility.Visible;
                }
                if (_13.Text.Length > 0)
                {
                    deleteButton13.Visibility = Visibility.Visible;
                }
                if (_14.Text.Length > 0)
                {
                    deleteButton14.Visibility = Visibility.Visible;
                }
                if (_15.Text.Length > 0)
                {
                    deleteButton15.Visibility = Visibility.Visible;
                }
                if (_17.Text.Length > 0)
                {
                    deleteButton17.Visibility = Visibility.Visible;
                }
                if (_21.Text.Length > 0)
                {
                    deleteButton21.Visibility = Visibility.Visible;
                }
                if (_22.Text.Length > 0)
                {
                    deleteButton22.Visibility = Visibility.Visible;
                }
                if (_23.Text.Length > 0)
                {
                    deleteButton23.Visibility = Visibility.Visible;
                }
                if (_24.Text.Length > 0)
                {
                    deleteButton24.Visibility = Visibility.Visible;
                }
                if (_25.Text.Length > 0)
                {
                    deleteButton25.Visibility = Visibility.Visible;
                }
                if (_26.Text.Length > 0)
                {
                    deleteButton26.Visibility = Visibility.Visible;
                }
                if (_27.Text.Length > 0)
                {
                    deleteButton27.Visibility = Visibility.Visible;
                }
                if (_31.Text.Length > 0)
                {
                    deleteButton31.Visibility = Visibility.Visible;
                }
                if (_32.Text.Length > 0)
                {
                    deleteButton32.Visibility = Visibility.Visible;
                }
                if (_33.Text.Length > 0)
                {
                    deleteButton33.Visibility = Visibility.Visible;
                }
                if (_34.Text.Length > 0)
                {
                    deleteButton34.Visibility = Visibility.Visible;
                }
                if (_35.Text.Length > 0)
                {
                    deleteButton35.Visibility = Visibility.Visible;
                }
                if (_36.Text.Length > 0)
                {
                    deleteButton36.Visibility = Visibility.Visible;
                }
                if (_37.Text.Length > 0)
                {
                    deleteButton37.Visibility = Visibility.Visible;
                }
                if (_41.Text.Length > 0)
                {
                    deleteButton41.Visibility = Visibility.Visible;
                }
                if (_42.Text.Length > 0)
                {
                    deleteButton42.Visibility = Visibility.Visible;
                }
                if (_43.Text.Length > 0)
                {
                    deleteButton43.Visibility = Visibility.Visible;
                }
                if (_44.Text.Length > 0)
                {
                    deleteButton44.Visibility = Visibility.Visible;
                }
                if (_45.Text.Length > 0)
                {
                    deleteButton45.Visibility = Visibility.Visible;
                }
                if (_46.Text.Length > 0)
                {
                    deleteButton46.Visibility = Visibility.Visible;
                }
                if (_47.Text.Length > 0)
                {
                    deleteButton47.Visibility = Visibility.Visible;
                }
            }

        //委托事件处理
        private void addClassWindow_Closed()
            {
                ReadSqlUserClassTime();
            }

        private void deleteWindow_Closed()
            {
                ReadSqlUserClassTime();
            }

        private void TextBlock()
            {
                _11.Text = null;
                _11ClassRoom.Text = null;
                _12.Text = null;
                _12ClassRoom.Text = null;
                _13.Text = null;
                _13ClassRoom.Text = null;
                _14.Text = null;
                _14ClassRoom.Text = null;
                _15.Text = null;
                _15ClassRoom.Text = null;
                _16.Text = null;
                _16ClassRoom.Text = null;
                _17.Text = null;
                _17ClassRoom.Text = null;

                _21.Text = null;
                _21ClassRoom.Text = null;
                _22.Text = null;
                _22ClassRoom.Text = null;
                _23.Text = null;
                _23ClassRoom.Text = null;
                _24.Text = null;
                _24ClassRoom.Text = null;
                _25.Text = null;
                _25ClassRoom.Text = null;
                _26.Text = null;
                _26ClassRoom.Text = null;
                _27.Text = null;
                _27ClassRoom.Text = null;

                _31.Text = null;
                _31ClassRoom.Text = null;
                _32.Text = null;
                _32ClassRoom.Text = null;
                _33.Text = null;
                _33ClassRoom.Text = null;
                _34.Text = null;
                _34ClassRoom.Text = null;
                _35.Text = null;
                _35ClassRoom.Text = null;
                _36.Text = null;
                _36ClassRoom.Text = null;
                _37.Text = null;
                _37ClassRoom.Text = null;

                _41.Text = null;
                _41ClassRoom.Text = null;
                _42.Text = null;
                _42ClassRoom.Text = null;
                _43.Text = null;
                _43ClassRoom.Text = null;
                _44.Text = null;
                _44ClassRoom.Text = null;
                _45.Text = null;
                _45ClassRoom.Text = null;
                _46.Text = null;
                _46ClassRoom.Text = null;
                _47.Text = null;
                _47ClassRoom.Text = null;
            }


            #region addClassButton Event

            private void addClassbutton11_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "1", "1", this);
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

            private void addClassbutton12_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "1", "2", this);
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

            private void addclassButton13_click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "1", "3", this);
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

            private void addclassButton14_click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "1", "4", this);
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

            private void addclassButton15_click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "1", "5", this);
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

            private void addclassButton16_click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "1", "6", this);
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

            private void addclassButton17_click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "1", "7", this);
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

            private void addclassButton21_click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "2", "1", this);
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

            private void addClassButton22_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "2", "2", this);
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

            private void addClassButton23_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "2", "3", this);
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

            private void addClassButton24_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "2", "4", this);
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

            private void addClassButton25_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "2", "5", this);
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
                AddClass addClassWindow = new AddClass(UserName, "2", "6", this);
                addClassWindow.ChangeLableEvent += new ChangeLableTextHandler(addClassWindow_Closed);
                addClassWindow.VisibilityEvent += new VisibilityHandler(ButtonVisibility);
                addClassWindow.Show();
            }

            private void addClassButton27_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "2", "7", this);
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

            private void addClassButton31_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "3", "1", this);
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

            private void addClassButton32_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "3", "2", this);
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

            private void addClassButton33_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "3", "3", this);
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

            private void addClassButton34_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "3", "4", this);
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

            private void addClassButton35_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "3", "5", this);
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

            private void addClassButton36_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "3", "6", this);
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

            private void addClassButton37_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "3", "7", this);
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

            private void addClassButton41_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "4", "1", this);
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

            private void addClassButton42_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "4", "2", this);
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

            private void addClassButton43_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "4", "3", this);
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

            private void addClassButton44_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "4", "4", this);
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

            private void addClassButton45_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "4", "5", this);
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

            private void addClassButton46_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "4", "6", this);
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

            private void addClassButton47_Click(object sender, RoutedEventArgs e)
            {
                AddClass addClassWindow = new AddClass(UserName, "4", "7", this);
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

            #region deleteButton Event
            private void deleteButton11_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("1", "1", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton11_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_11.Text.Length > 0)
                {
                    deleteButton11.Visibility = Visibility.Visible;
                    deleteButton11.Opacity = 100;
                    deleteButton11.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton11.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton11_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton11.Opacity = 0;
            }

            private void deleteButton12_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("1", "2", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton12_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_12.Text.Length > 0)
                {
                    deleteButton12.Visibility = Visibility.Visible;
                    deleteButton12.Opacity = 100;
                    deleteButton12.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton12.Visibility = Visibility.Hidden;
                }

            }
            private void deleteButton12_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton12.Opacity = 0;
            }

            private void deleteButton13_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("1", "3", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton13_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_13.Text.Length > 0)
                {
                    deleteButton13.Visibility = Visibility.Visible;
                    deleteButton13.Opacity = 100;
                    deleteButton13.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton13.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton13_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton13.Opacity = 0;
            }

            private void deleteButton14_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("1", "4", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton14_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_14.Text.Length > 0)
                {
                    deleteButton14.Visibility = Visibility.Visible;
                    deleteButton14.Opacity = 100;
                    deleteButton14.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton14.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton14_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton14.Opacity = 0;
            }

            private void deleteButton15_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("1", "5", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton15_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton15.Opacity = 0;
            }
            private void deleteButton15_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_15.Text.Length > 0)
                {
                    deleteButton15.Visibility = Visibility.Visible;
                    deleteButton15.Opacity = 100;
                    deleteButton15.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton15.Visibility = Visibility.Hidden;
                }
            }

            private void deleteButton16_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("1", "6", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton16_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_16.Text.Length > 0)
                {
                    deleteButton16.Visibility = Visibility.Visible;
                    deleteButton16.Opacity = 100;
                    deleteButton16.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton16.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton16_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton16.Opacity = 0;
            }

            private void deleteButton17_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("1", "7", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton17_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_17.Text.Length > 0)
                {
                    deleteButton17.Visibility = Visibility.Visible;
                    deleteButton17.Opacity = 100;
                    deleteButton17.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton17.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton17_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton17.Opacity = 0;
            }

            private void deleteButton21_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("2", "1", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton21_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_21.Text.Length > 0)
                {
                    deleteButton21.Visibility = Visibility.Visible;
                    deleteButton21.Opacity = 100;
                    deleteButton21.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton21.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton21_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton21.Opacity = 0;
            }

            private void deleteButton22_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("2", "2", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton22_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_22.Text.Length > 0)
                {
                    deleteButton22.Visibility = Visibility.Visible;
                    deleteButton22.Opacity = 100;
                    deleteButton22.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton22.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton22_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton22.Opacity = 0;
            }

            private void deleteButton23_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("2", "3", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton23_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_23.Text.Length > 0)
                {
                    deleteButton23.Visibility = Visibility.Visible;
                    deleteButton23.Opacity = 100;
                    deleteButton23.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton23.Visibility = Visibility.Hidden;
                }

            }
            private void deleteButton23_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton23.Opacity = 0;
            }

            private void deleteButton24_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("2", "4", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton24_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_24.Text.Length > 0)
                {
                    deleteButton24.Visibility = Visibility.Visible;
                    deleteButton24.Opacity = 100;
                    deleteButton24.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton24.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton24_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton24.Opacity = 0;
            }

            private void deleteButton25_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("2", "5", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton25_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_25.Text.Length > 0)
                {
                    deleteButton25.Visibility = Visibility.Visible;
                    deleteButton25.Opacity = 100;
                    deleteButton25.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton25.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton25_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton25.Opacity = 0;
            }

            private void deleteButton26_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("2", "6", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton26_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_26.Text.Length > 0)
                {
                    deleteButton26.Visibility = Visibility.Visible;
                    deleteButton26.Opacity = 100;
                    deleteButton26.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton26.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton26_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton26.Opacity = 0;
            }

            private void deleteButton27_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("2", "7", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton27_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_27.Text.Length > 0)
                {
                    deleteButton27.Visibility = Visibility.Visible;
                    deleteButton27.Opacity = 100;
                    deleteButton27.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton27.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton27_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton27.Opacity = 0;
            }

            private void deleteButton31_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("3", "1", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton31_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_31.Text.Length > 0)
                {
                    deleteButton31.Visibility = Visibility.Visible;
                    deleteButton31.Opacity = 100;
                    deleteButton31.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton31.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton31_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton31.Opacity = 0;
            }

            private void deleteButton32_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("3", "2", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton32_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_32.Text.Length > 0)
                {
                    deleteButton32.Visibility = Visibility.Visible;
                    deleteButton32.Opacity = 100;
                    deleteButton32.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton32.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton32_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton32.Opacity = 0;
            }

            private void deleteButton33_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("3", "3", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton33_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_33.Text.Length > 0)
                {
                    deleteButton33.Visibility = Visibility.Visible;
                    deleteButton33.Opacity = 100;
                    deleteButton33.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton33.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton33_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton33.Opacity = 0;
            }

            private void deleteButton34_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("3", "4", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton34_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_34.Text.Length > 0)
                {
                    deleteButton34.Visibility = Visibility.Visible;
                    deleteButton34.Opacity = 100;
                    deleteButton34.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton34.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton34_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton34.Opacity = 0;
            }

            private void deleteButton35_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("3", "5", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton35_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_35.Text.Length > 0)
                {
                    deleteButton35.Visibility = Visibility.Visible;
                    deleteButton35.Opacity = 100;
                    deleteButton35.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton35.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton35_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton35.Opacity = 0;
            }

            private void deleteButton36_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("3", "6", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton36_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_36.Text.Length > 0)
                {
                    deleteButton36.Visibility = Visibility.Visible;
                    deleteButton36.Opacity = 100;
                    deleteButton36.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton36.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton36_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton36.Opacity = 0;
            }

            private void deleteButton37_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("3", "7", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton37_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_37.Text.Length > 0)
                {
                    deleteButton37.Visibility = Visibility.Visible;
                    deleteButton37.Opacity = 100;
                    deleteButton37.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton37.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton37_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton37.Opacity = 0;
            }

            private void deleteButton41_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("4", "1", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton41_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_41.Text.Length > 0)
                {
                    deleteButton41.Visibility = Visibility.Visible;
                    deleteButton41.Opacity = 100;
                    deleteButton41.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton41.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton41_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton41.Opacity = 0;
            }

            private void deleteButton42_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("4", "2", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton42_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_42.Text.Length > 0)
                {
                    deleteButton42.Visibility = Visibility.Visible;
                    deleteButton42.Opacity = 100;
                    deleteButton42.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton42.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton42_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton42.Opacity = 0;
            }

            private void deleteButton43_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("4", "3", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton43_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_43.Text.Length > 0)
                {
                    deleteButton43.Visibility = Visibility.Visible;
                    deleteButton43.Opacity = 100;
                    deleteButton43.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton43.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton43_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton43.Opacity = 0;
            }

            private void deleteButton44_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("4", "4", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton44_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_44.Text.Length > 0)
                {
                    deleteButton44.Visibility = Visibility.Visible;
                    deleteButton44.Opacity = 100;
                    deleteButton44.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton44.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton44_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton44.Opacity = 0;
            }

            private void deleteButton45_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("4", "5", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton45_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_45.Text.Length > 0)
                {
                    deleteButton45.Visibility = Visibility.Visible;
                    deleteButton45.Opacity = 100;
                    deleteButton45.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton45.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton45_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton45.Opacity = 0;
            }

            private void deleteButton46_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("4", "6", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton46_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_46.Text.Length > 0)
                {
                    deleteButton46.Visibility = Visibility.Visible;
                    deleteButton46.Opacity = 100;
                    deleteButton46.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton46.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton46_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton46.Opacity = 0;
            }

            private void deleteButton47_Click(object sender, RoutedEventArgs e)
            {
                Delete deleteWindow = new Delete("4", "7", UserName);
                deleteWindow.ChangeLableEvent += new Delete.ChangeLableTextHandler(deleteWindow_Closed);
                deleteWindow.VisibilityEvent += new Delete.VisibilityHandler(DeleteButtonVisibility);
                deleteWindow.AddButtonEvent += new Delete.AddButtonVisibilityHandler(ButtonVisibility);
                deleteWindow.Show();
            }
            private void deleteButton47_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
            {
                if (_47.Text.Length > 0)
                {
                    deleteButton47.Visibility = Visibility.Visible;
                    deleteButton47.Opacity = 100;
                    deleteButton47.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5FCCF4"));
                }
                else
                {
                    deleteButton47.Visibility = Visibility.Hidden;
                }
            }
            private void deleteButton47_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
            {
                deleteButton47.Opacity = 0;
            }
            #endregion
        
    }
}