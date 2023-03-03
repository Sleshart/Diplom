using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Configuration;
using System.Windows.Threading;

namespace HotToWalkToTheLibrary.ManForms
{
    public partial class MainPage : Page
    {
        public Action UpdateT;
        public MainPage()
        {
            InitializeComponent();

            Class.ControlID.Sql = @"select * from Main";
            UpdateTable(Class.ControlID.Sql);
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
            if(Search.Text.Length == 0)
            UpdateTable(Class.ControlID.Sql);
            Error.Visibility = Visibility.Hidden;
        }
        public void UpdateTable(string Sql)
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
                    CommandText = Sql,
                    Connection = con
                };
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Main");
                MainDataGrid.DataContext = ds;
                con.Close();

                //MainDataGrid.RowStyle = convert.ToDateTime("Дата выдачи").Date;
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
            string sql = @"select * from Main where Main_ID like '%"+Search.Text+"%' or FIO like '%" + Search.Text + "%' or M_Book like '%" + Search.Text + "%' or DateGet like '%"+Search.Text+"%' or LastDate like '"+Search.Text+"'";
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
                da.Fill(ds, "Main");
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
            Class.ControlID.ChangeWhat = true;
            AddMainShowForm();
        }

        private void AddMainShowForm()
        {
            MainChanger next = new MainChanger();
            next.Show();
        }

        public void Edit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Class.ControlID.Main_ID != 0)
            {
                Class.ControlID.ChangeWhat = false;
                AddMainShowForm();
                Error.Visibility = Visibility.Hidden;
                Class.ControlID.Main_ID = 0;
            }
            else
            {
                Error.Visibility = Visibility.Visible;
            }
            
        }

        private void Delete_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Class.ControlID.Main_ID != 0)
            {
                try
                {
                    string sql = "delete from Main where Main_ID like @Main_ID";
                    SqlConnection conn = new SqlConnection
                    {
                        ConnectionString = ConfigurationManager.ConnectionStrings["connsetting"].ToString()
                    };
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Main_ID", Class.ControlID.Main_ID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    UpdateTable(Class.ControlID.Sql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Error.Visibility = Visibility.Hidden;
                Class.ControlID.Main_ID = 0;
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

                DataRowView selectedRow = (DataRowView)dg.SelectedItem;

                if (selectedRow != null)
                {
                    Class.ControlID.Main_ID = (int)selectedRow["Main_ID"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reload_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UpdateTable(Class.ControlID.Sql);
        }
    }
}
