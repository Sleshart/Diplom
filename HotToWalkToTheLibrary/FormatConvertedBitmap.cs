using HotToWalkToTheLibrary.ManForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using static HotToWalkToTheLibrary.ManForms.MainPage;

namespace HotToWalkToTheLibrary
{
    /// Влажный код
    /// 
    /// var bc = new BrushConverter();
    /// Должники.Background = (Brush) bc.ConvertFrom("#8B93A7");
    /// Дтекст.Foreground = (Brush) bc.ConvertFrom("#1B1D23");

    public partial class MainWindow : Window
    {
        public string sql;
        public bool Ab = false;
        public bool Do = false;
        public bool Ch = false;
        public bool Kn = false;
        public Process p = new Process();
        readonly ThicknessAnimation AnimateIn = new ThicknessAnimation(new Thickness(-80, 0, 0, 0), TimeSpan.FromSeconds(0.2));
        readonly ThicknessAnimation AnimateOut = new ThicknessAnimation(new Thickness(-100, 0, 0, 0), TimeSpan.FromSeconds(0.2));
        public MainWindow()
        {
            Theme = Properties.Settings.Default.CurrentTheme;
            ChangeTheme();
            InitializeComponent();

            Test.Text = Theme.ToString();

            string applicationDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            p.StartInfo.FileName = Directory.GetParent(applicationDirectory).Parent.FullName + "/Resources/RestartApp.cmd";

            MainFrame.Content = new MainPage();
            Абонемент.Margin = new Thickness(-80, 0, 0, 0);
            BorderShadow.SetValue(Grid.RowProperty, 0);
            Ab = true;
            //var bc = new BrushConverter();
            //Абонемент.Background = (Brush) bc.ConvertFrom("#959AA7");

            
            if (Theme == false)
            {
                SwitchInner.BeginAnimation(Canvas.MarginProperty, AnimateSwitchOut);
            }
            else
            {
                SwitchInner.BeginAnimation(Canvas.MarginProperty, AnimateSwitchIn);
            }
        }

        private async void CloseButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            await Task.Delay(400);
            Process.GetCurrentProcess().Kill();
        }

        private async void Абонемент_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Ab = true;
            Do = false;
            Ch = false;
            Kn = false;
            if (Do == false)
            {
                Должники.BeginAnimation(Canvas.MarginProperty, AnimateOut);
            }
            if (Ab == true)
            {
                Абонемент.BeginAnimation(Canvas.MarginProperty, AnimateIn);
                BorderShadow.SetValue(Grid.RowProperty, 0);
            }
            if (Ch == false)
            {
                Читатели.BeginAnimation(Canvas.MarginProperty, AnimateOut);
            }
            if (Kn == false)
            {
                Книги.BeginAnimation(Canvas.MarginProperty, AnimateOut);
            }
            Class.ControlID.Sql = "select * from Main";
            await Task.Delay(250);
            MainFrame.Content = new MainPage();
        }

        private async void Должники_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Ab = false;
            Do = true;
            Ch = false;
            Kn = false;

            if (Do == true)
            {
                Должники.BeginAnimation(Canvas.MarginProperty, AnimateIn);
                BorderShadow.SetValue(Grid.RowProperty, 1);
            }
            if (Ab == false)
            {
                Абонемент.BeginAnimation(Canvas.MarginProperty, AnimateOut);
            }
            if (Ch == false)
            {
                Читатели.BeginAnimation(Canvas.MarginProperty, AnimateOut);
            }
            if (Kn == false)
            {
                Книги.BeginAnimation(Canvas.MarginProperty, AnimateOut);
            }
            await Task.Delay(250);
            MainFrame.Content = new DebtorsPage();
        }

        private async void Читатели_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Ab = false;
            Do = false;
            Ch = true;
            Kn = false;
            if (Do == false)
            {
                Должники.BeginAnimation(Canvas.MarginProperty, AnimateOut);
            }
            if (Ab == false)
            {
                Абонемент.BeginAnimation(Canvas.MarginProperty, AnimateOut);
            }
            if (Ch == true)
            {
                Читатели.BeginAnimation(Canvas.MarginProperty, AnimateIn);
                BorderShadow.SetValue(Grid.RowProperty, 2);
            }
            if (Kn == false)
            {
                Книги.BeginAnimation(Canvas.MarginProperty, AnimateOut);
            }
            await Task.Delay(250);
            MainFrame.Content = new ReadersPage();
        }
        private async void Книги_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Ab = false;
            Do = false;
            Ch = false;
            Kn = true;
            if (Do == false)
            {
                Должники.BeginAnimation(Canvas.MarginProperty, AnimateOut);
            }
            if (Ab == false)
            {
                Абонемент.BeginAnimation(Canvas.MarginProperty, AnimateOut);
            }
            if (Ch == false)
            {
                Читатели.BeginAnimation(Canvas.MarginProperty, AnimateOut);
            }
            if (Kn == true)
            {
                Книги.BeginAnimation(Canvas.MarginProperty, AnimateIn);
                BorderShadow.SetValue(Grid.RowProperty, 3);
            }
            await Task.Delay(250);
            MainFrame.Content = new BooksPage();
        }  

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                MainWindowW.DragMove();
        }

        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
            
        }
        bool Theme = false;
        readonly ThicknessAnimation AnimateSwitchIn = new ThicknessAnimation(new Thickness(-19, 1, 0, 1), TimeSpan.FromSeconds(0.1));
        readonly ThicknessAnimation AnimateSwitchOut = new ThicknessAnimation(new Thickness(19, 1, 0, 1), TimeSpan.FromSeconds(0.1));
        private async void Swhitcher_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(Theme == false)
            {
                SwitchInner.BeginAnimation(Canvas.MarginProperty, AnimateSwitchIn);
                Theme = true;
                Properties.Settings.Default.CurrentTheme = Theme;
                Properties.Settings.Default.Save();
            }
            else
            {
                SwitchInner.BeginAnimation(Canvas.MarginProperty, AnimateSwitchOut);
                Theme = false;
                Properties.Settings.Default.CurrentTheme = Theme;
                Properties.Settings.Default.Save();
            }
            await Task.Delay(200);
            p.Start();
            Process.GetCurrentProcess().Kill();
        }
        public void ChangeTheme()
        {
            if (Theme == true)
            {
                var ColorsUri = new Uri("/Styles/Colors.xaml", UriKind.Relative);
                ResourceDictionary resourceCoolorDict = Application.LoadComponent(ColorsUri) as ResourceDictionary;
                var DataGridUri = new Uri("/Styles/DataGrid.xaml", UriKind.Relative);
                ResourceDictionary resourceDataGridDict = Application.LoadComponent(DataGridUri) as ResourceDictionary;
                var DatePickerUri = new Uri("/Styles/DatePicker.xaml", UriKind.Relative);
                ResourceDictionary resourceDatePickerDict = Application.LoadComponent(DatePickerUri) as ResourceDictionary;
                var ComboBoxUri = new Uri("/Styles/ComboBox.xaml", UriKind.Relative);
                ResourceDictionary resourceComboBoxDict = Application.LoadComponent(ComboBoxUri) as ResourceDictionary;
                var DrawingImagesUri = new Uri("/Resources/DrawingImages.xaml", UriKind.Relative);
                ResourceDictionary resourceDrawingImagesDict = Application.LoadComponent(DrawingImagesUri) as ResourceDictionary;
                var StoryboardsUri = new Uri("/Resources/Storyboards.xaml", UriKind.Relative);
                ResourceDictionary resourceStoryboardsDict = Application.LoadComponent(StoryboardsUri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceCoolorDict);
                Application.Current.Resources.MergedDictionaries.Add(resourceDataGridDict);
                Application.Current.Resources.MergedDictionaries.Add(resourceDatePickerDict);
                Application.Current.Resources.MergedDictionaries.Add(resourceComboBoxDict);
                Application.Current.Resources.MergedDictionaries.Add(resourceDrawingImagesDict);
                Application.Current.Resources.MergedDictionaries.Add(resourceStoryboardsDict);
            }
            else
            {
                var ColorsUri = new Uri("/Styles/ColorsLight.xaml", UriKind.Relative);
                ResourceDictionary resourceCoolorDict = Application.LoadComponent(ColorsUri) as ResourceDictionary;
                var DataGridUri = new Uri("/Styles/DataGrid.xaml", UriKind.Relative);
                ResourceDictionary resourceDataGridDict = Application.LoadComponent(DataGridUri) as ResourceDictionary;
                var DatePickerUri = new Uri("/Styles/DatePicker.xaml", UriKind.Relative);
                ResourceDictionary resourceDatePickerDict = Application.LoadComponent(DatePickerUri) as ResourceDictionary;
                var ComboBoxUri = new Uri("/Styles/ComboBox.xaml", UriKind.Relative);
                ResourceDictionary resourceComboBoxDict = Application.LoadComponent(ComboBoxUri) as ResourceDictionary;
                var DrawingImagesUri = new Uri("/Resources/DrawingImages.xaml", UriKind.Relative);
                ResourceDictionary resourceDrawingImagesDict = Application.LoadComponent(DrawingImagesUri) as ResourceDictionary;
                var StoryboardsUri = new Uri("/Resources/Storyboards.xaml", UriKind.Relative);
                ResourceDictionary resourceStoryboardsDict = Application.LoadComponent(StoryboardsUri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceCoolorDict);
                Application.Current.Resources.MergedDictionaries.Add(resourceDataGridDict);
                Application.Current.Resources.MergedDictionaries.Add(resourceDatePickerDict);
                Application.Current.Resources.MergedDictionaries.Add(resourceComboBoxDict);
                Application.Current.Resources.MergedDictionaries.Add(resourceDrawingImagesDict);
                Application.Current.Resources.MergedDictionaries.Add(resourceStoryboardsDict);
            }
        }
    }
}
