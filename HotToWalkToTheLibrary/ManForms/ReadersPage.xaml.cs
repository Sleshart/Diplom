using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using static HotToWalkToTheLibrary.ManForms.MainPage;
using System.Windows.Threading;
using System.IO;
using System.Windows.Shapes;
using System.Windows.Resources;
using Path = System.IO.Path;
using System.Threading.Tasks;
using System.Windows.Media;

namespace HotToWalkToTheLibrary.ManForms
{
    public partial class ReadersPage : Page
    {
        //DispatcherTimer _dispTimer;
        public ReadersPage()
        {
           
            InitializeComponent();
            Class.ControlID.SqlR = @"select * from Readers";
            UpdateTable(Class.ControlID.SqlR);
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
                UpdateTable(Class.ControlID.SqlR);
            Error.Visibility = Visibility.Hidden;
        }
        public void UpdateTable(string SqlR)
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
                    CommandText = SqlR,
                    Connection = con
                };
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Readers");
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
            string sql = @"select * from Readers where Readers_ID like '%"+Search.Text+"%' or YearsOld like '%"+Search.Text+"%' or Sname like '%" + Search.Text + "%' or Fname like '%" + Search.Text + "%' or Lname like '%" + Search.Text + "%' or LivingPlace like '%" + Search.Text + "%' or PhoneNumber like '%"+Search.Text+"%'";
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
                da.Fill(ds, "Readers");
                MainDataGrid.DataContext = ds;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "При фильтрации");
            }
        }
        public void Add_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Class.ControlID.ChangeWhatR = true;
            AddMainShowForm();
        }

        private void AddMainShowForm()
        {
            ReadersChanger next = new ReadersChanger();
            next.Show();
        }

        public void Edit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Class.ControlID.Readers_ID != 0)
            {
                Class.ControlID.ChangeWhatR = false;
                AddMainShowForm();
                Error.Visibility = Visibility.Hidden;
                Class.ControlID.Readers_ID = 0;
            }
            else
            {
                Error.Visibility = Visibility.Visible;
            }
        }

        private void Delete_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Class.ControlID.Readers_ID != 0)
            {
                try
                {
                    string sql = "delete from Readers where Readers_ID like @Readers_ID";
                    SqlConnection conn = new SqlConnection
                    {
                        ConnectionString = ConfigurationManager.ConnectionStrings["connsetting"].ToString()
                    };
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Readers_ID", Class.ControlID.Readers_ID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    UpdateTable(Class.ControlID.SqlR);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Error.Visibility = Visibility.Hidden;
                Class.ControlID.Readers_ID = 0;
            }
            else
            {
                Error.Visibility = Visibility.Visible;
            }

        }
        public static int Readers_ID;
        public void MainDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DataGrid dg = (DataGrid)sender;

                DataRowView selectedRow = (DataRowView)dg.SelectedItem;

                if (selectedRow != null)
                {
                    Class.ControlID.Readers_ID = (int)selectedRow["Readers_ID"];
                    Readers_ID = (int)selectedRow["Readers_ID"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reload_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UpdateTable(Class.ControlID.SqlR);
        }
        private async void Bilet_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            await Task.Delay(200);
            string Sname;
            string Fname;
            string Lname;
            if(Readers_ID != 0)
            {
                try
                {
                    string Sql = "select * from Readers where Readers_ID like " + Readers_ID;
                    SqlConnection conn = new SqlConnection
                    {
                        ConnectionString = ConfigurationManager.ConnectionStrings["connsetting"].ToString()
                    };
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(Sql, conn);
                    SqlDataReader DR = cmd.ExecuteReader();

                    while (DR.Read())
                    {
                        Sname = DR["Sname"].ToString();
                        Fname = DR["Fname"].ToString();
                        Lname = DR["Lname"].ToString();
                        if(Sname != null)
                        {
                            Replacer(Readers_ID.ToString(), Sname, Fname, Lname);
                        }
                        else
                        {

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "При загрузке данных в отчет");
                }
            }
            else
            {
                Error.Visibility = Visibility.Visible;
            }
        }
        
        private void Replacer(string Readers_ID, string Sname, string Fname, string Lname)
        {
            //File.Copy(@"/Resources/ReaderTicket.docx", @"c:\Users\%username%\Desktop\ReaderTicket.docx");

            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            string fileLoc = System.AppDomain.CurrentDomain.BaseDirectory;
            var wDoc = app.Documents.Open(fileLoc + @"ReaderTicket.docx");

            GenerateDoc(Readers_ID, "{Readers_ID}", wDoc);
            GenerateDoc(Sname, "{Sname}", wDoc);
            GenerateDoc(Fname, "{Fname}", wDoc);
            GenerateDoc(Lname, "{Lname}", wDoc);
            app.Visible = true;
        }


        private void GenerateDoc(string toPrint, string toFind, Microsoft.Office.Interop.Word.Document wDoc)
        {
            var range = wDoc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: toFind, ReplaceWith: toPrint);
        }
    }
}
