using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer timer = new DispatcherTimer();
        string code;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void gencode()
        {
            code = null;
            Random random = new Random();
            string[] massiveCharacters = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            for (int i = 0; i < 4; i++)
            {
                code += massiveCharacters[random.Next(0, massiveCharacters.Length)];
            }
            CodeBlock.Text = code;
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += Timer_Tick;
            timer.Start();
            CodBox.IsEnabled = true;
            Vhod.IsEnabled = true;
            Reloadd.IsEnabled = true;
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            code = null;
            MessageBox.Show("Время написания кода вышло. Повторите попытку", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            timer.Stop();
            gencode();
        }
        private void LogBlock_Up(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                using (var db = new dbkursEntities())
                {
                    var salamlog = salam.hashPassword(LogBox.Text);
                    var login = dbkursEntities.GetContext().Users.FirstOrDefault(l => l.Name == salamlog.Trim());
                    if (login == null)
                    {
                        MessageBox.Show("Неверный логин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        PassBox.IsEnabled = true;
                        LogBox.IsEnabled = false;
                        PassBox.Focus();
                    }
                }
            }
        }
        private void PassBlock_Up(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                using (var db = new dbkursEntities())
                {
                    var salampass = salam.hashPassword(PassBox.Password);
                    var login = dbkursEntities.GetContext().Users.FirstOrDefault(l => l.Password == salampass.Trim());
                    if (login == null)
                    {
                        MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        PassBox.IsEnabled = false;
                        gencode();
                        CodBox.Focus();
                    }
                }
            }
        }
        private void CodeBlock_Up(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Vhod_Click(sender, e);
            }
        }
        private void Reload_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            gencode();
            CodBox.Focus();
        }

        public static class Globals
        {
            public static int RoleID;
        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            var salamlog = salam.hashPassword(LogBox.Text);
            var salampass = salam.hashPassword(PassBox.Password);
            var db = new dbkursEntities();
            var auth = db.Users.AsNoTracking().FirstOrDefault(u => u.Name == salamlog && u.Password == salampass);

            if (auth != null & code == CodBox.Text)
            {
                timer.Stop();
                if (auth.Active == true)
                {
                    MessageBox.Show("Доступ запрещён!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    Globals.RoleID = auth.RoleID;
                    Glav NW = new Glav();
                    NW.Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                CodBox.Clear();
                timer.Stop();
                gencode();
            }
        
        }

        private void Otmena_Click(object sender, RoutedEventArgs e)
        {
            {
                timer.Stop();
                LogBox.Clear();
                PassBox.Clear();
                CodBox.Clear();
                CodeBlock.Text = "";
                LogBox.IsEnabled = true;
                PassBox.IsEnabled = false;
                CodBox.IsEnabled = false;
                Vhod.IsEnabled = false;
                Reloadd.IsEnabled = false;
            }
        }
    }

    

}

