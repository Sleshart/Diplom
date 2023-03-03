using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static HotToWalkToTheLibrary.ManForms.MainPage;
using System.Windows.Threading;

namespace HotToWalkToTheLibrary.ManForms
{
    /// <summary>
    /// Логика взаимодействия для BooksPage.xaml
    /// </summary>
    public partial class BooksPage : Page
    {
        public BooksPage()
        {
            InitializeComponent();
            Class.ControlID.SqlB = @"select * from Books";
            UpdateTable(Class.ControlID.SqlB);

            Class.ControlID._timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(5000)
            };
            Class.ControlID._timer.Tick += Timer_Tick;
            Class.ControlID._timer.Start();

            Error.Visibility = Visibility.Hidden;
        }
        public void Timer_Tick(object sender, EventArgs e)
        {
            if (Search.Text.Length == 0)
                UpdateTable(Class.ControlID.SqlB);
            Error.Visibility = Visibility.Hidden;
        }
        public void UpdateTable(string SqlB)
        {
            try
            {
                SqlConnection con = new SqlConnection
                {
                    ConnectionString = ConfigurationManager.ConnectionStrings["connsetting"].ToString()
                };
                con.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = SqlB,
                    Connection = con
                };
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Books");
                MainDataGrid.DataContext = ds;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Search.Text.Length > 0)
            {
                SearchText.Visibility = Visibility.Hidden;
            }
            else
            {
                SearchText.Visibility = Visibility.Visible;
            }
            string sql = @"select * from Books where Books_ID like '&"+Search.Text+"&' or HowMany like '&"+Search.Text+"&' or Title like '" + "%" + Search.Text + "%' or Author like '" + "%" + Search.Text + "%' or MakeYears like '" + "%" + Search.Text + "%'";
            try
            {
                SqlConnection con = new SqlConnection
                {
                    ConnectionString = ConfigurationManager.ConnectionStrings["connsetting"].ToString()
                };
                con.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = sql,
                    Connection = con
                };
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Books");
                MainDataGrid.DataContext = ds;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Add_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Class.ControlID.ChangeWhatB = true;
            AddMainShowForm();
        }

        private void AddMainShowForm()
        {
            BooksChanger next = new BooksChanger();
            next.Show();
        }

        public void Edit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {            
            if (Class.ControlID.Books_ID != 0)
            {
                Class.ControlID.ChangeWhatB = false;
                AddMainShowForm();
                Error.Visibility = Visibility.Hidden;
                Class.ControlID.Books_ID = 0;
            }
            else
            {
                Error.Visibility = Visibility.Visible;
            }
        }

        private void Delete_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Class.ControlID.Books_ID != 0)
            {
                try
                {
                    string sql = "delete from Books where Books_ID like @Books_ID";
                    SqlConnection conn = new SqlConnection
                    {
                        ConnectionString = ConfigurationManager.ConnectionStrings["connsetting"].ToString()
                    };
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Books_ID", Class.ControlID.Books_ID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    UpdateTable(Class.ControlID.SqlB);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Error.Visibility = Visibility.Hidden;
                Class.ControlID.Books_ID = 0;
            }
            else
            {
                Error.Visibility = Visibility.Visible;
            }

        }

        public void MainDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DataGrid dg = (DataGrid)sender;

                var selectedRow = (DataRowView)dg.SelectedItem;

                if (selectedRow != null)
                {
                    Class.ControlID.Books_ID = (int)selectedRow["Books_ID"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reload_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UpdateTable(Class.ControlID.SqlB);
        }
    }
}
