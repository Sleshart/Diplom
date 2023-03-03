using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HotToWalkToTheLibrary.ManForms
{
    public partial class Autorisation : Window
    {
        public Autorisation()
        {
            InitializeComponent();
        }
        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Login.Text.Length > 0)
            {
                LogText.Visibility = Visibility.Hidden;
            }
            else
            {
                LogText.Visibility = Visibility.Visible;
            }
        }
        private async void Войти_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            await Task.Delay(200);
            UserEnter();
        }
        public static int count;
        public void UserEnter()
        {
            SqlConnection con = new SqlConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["connsetting"].ToString()
            };
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string query = "select count(1) from Users where Username=@Username and Pass=@Password";
                SqlCommand cmd = new SqlCommand(query, con)
                {
                    CommandType = CommandType.Text
                };
                cmd.Parameters.AddWithValue("@Username", Login.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Password);
                count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {

                    MainWindow next = new MainWindow();
                    next.Show();
                    this.Close();
                }
                else
                {
                    Error.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void CloseButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            await Task.Delay(400);
            this.Close();
        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Password.Focus();
            }
        }
        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (Password.Password.Length > 0)
            {
                PassText.Visibility = Visibility.Hidden;
            }
            else
            {
                PassText.Visibility = Visibility.Visible;
            }    
        }
        private void PassTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PassTextBox.Text.Length > 0)
            {
                PassText.Visibility = Visibility.Hidden;
            }
            else
            {
                PassText.Visibility = Visibility.Visible;
            }
            

        }
        private void HidePass_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Password.Visibility = Visibility.Visible;
            PassTextBox.Visibility = Visibility.Hidden;
            //Password.Focus();
        }
        private void HidePass_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PassTextBox.Text = Password.Password;
            Password.Visibility = Visibility.Hidden;
            PassTextBox.Visibility = Visibility.Visible;
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                UserEnter();
            }       
        }
        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                Authoris.DragMove();
        }
    }
}
