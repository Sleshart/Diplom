using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using static HotToWalkToTheLibrary.ManForms.MainPage;

namespace HotToWalkToTheLibrary.ManForms
{
    public partial class BooksChanger : Window
    {
        public int Books_ID = Class.ControlID.Books_ID;
        public bool ChangeWhatB = Class.ControlID.ChangeWhatB;
        public BooksChanger()
        {
            InitializeComponent();

            if (ChangeWhatB == true)
            {
                Atext.Text = "Добавить";
            }
            else
            {
                try
                {
                    string Sql = "select * from Books where Books_ID like " + Books_ID;
                    SqlConnection conn = new SqlConnection
                    {
                        ConnectionString = ConfigurationManager.ConnectionStrings["connsetting"].ToString()
                    };
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(Sql, conn);
                    SqlDataReader DR = cmd.ExecuteReader();

                    while (DR.Read())
                    {
                        Title.Text = DR["Title"].ToString();
                        Author.Text = DR["Author"].ToString();
                        MakeYears.Text = DR["MakeYears"].ToString();
                        HowMany.Text = DR["HowMany"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "При загрузке данных на изменение");
                }
                Atext.Text = "Изменить";

            }
        }
        private async void Action_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            await Task.Delay(200);
            if (ChangeWhatB == true)
            {
                try
                {
                    string sql = "insert into Books(Title,Author,MakeYears,HowMany) values(@Title, @Author, @MakeYears, @HowMany)";
                    SqlConnection conn = new SqlConnection
                    {
                        ConnectionString = ConfigurationManager.ConnectionStrings["connsetting"].ToString()
                    };
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Title", Title.Text);
                    cmd.Parameters.AddWithValue("@Author", Author.Text);
                    cmd.Parameters.AddWithValue("@MakeYears", MakeYears.Text);
                    cmd.Parameters.AddWithValue("@HowMany", HowMany.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MainPage update = new MainPage();
                    update.UpdateTable(Class.ControlID.SqlB);
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "При добавлении записи");
                }
            }
            else
            {
                try
                {
                    string sql = "update Books set Title = @Title, Author = @Author, MakeYears = @MakeYears, HowMany = @HowMany where Books_ID like " + Books_ID;
                    SqlConnection conn = new SqlConnection
                    {
                        ConnectionString = ConfigurationManager.ConnectionStrings["connsetting"].ToString()
                    };
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Title", Title.Text);
                    cmd.Parameters.AddWithValue("@Author", Author.Text);
                    cmd.Parameters.AddWithValue("@MakeYears", MakeYears.Text);
                    cmd.Parameters.AddWithValue("@HowMany", HowMany.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    BooksPage update = new BooksPage();
                    update.UpdateTable(Class.ControlID.SqlB);
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "При изменении записи");
                }
            }
        }
        private void CloseButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseLeave(object sender, MouseEventArgs e)
        {
            ImageSourceConverter imgs = new ImageSourceConverter();
            CloseButton.SetValue(Image.SourceProperty, imgs.ConvertFromString(@"pack://application:,,,/Resources/Закрыть.png"));
        }

        private void CloseButton_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageSourceConverter imgs = new ImageSourceConverter();
            CloseButton.SetValue(Image.SourceProperty, imgs.ConvertFromString(@"pack://application:,,,/Resources/Закрыть нажат.png"));
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                ChangerWindow.DragMove();
        }
    }
}
