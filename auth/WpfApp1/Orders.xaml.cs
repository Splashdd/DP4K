using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Orders.xaml
    /// </summary>
    public partial class Orders : Page
    {
        public Orders()
        {
            InitializeComponent();
            StatementGrid.ItemsSource = dbkursEntities.GetContext().Order.ToList();
        }

        private void Redakt_Click(object sender, RoutedEventArgs e)
        {
            if (StatementGrid.SelectedItem != null)
            {
                Redaktir red = new Redaktir(StatementGrid.SelectedItem as Order);
                red.ShowDialog();
                dbkursEntities.GetContext().SaveChanges();
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Redaktir red = new Redaktir(null);
            red.ShowDialog();
        }

        private void Deletett_Click(object sender, RoutedEventArgs e)
        {
            if (StatementGrid.SelectedItem != null)
            {
                var Removing = StatementGrid.SelectedItems.Cast<Order>().ToList();

                if (MessageBox.Show($"Вы точно хотите удалить следующие {Removing.Count()} элеметнов?", "Внимание",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        dbkursEntities.GetContext().Order.RemoveRange(Removing);
                        dbkursEntities.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены");
                        StatementGrid.ItemsSource = dbkursEntities.GetContext().Order.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите что нужно удалить", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
