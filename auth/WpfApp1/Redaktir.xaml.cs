using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Redaktir.xaml
    /// </summary>
    public partial class Redaktir : Window
    {
        private Order _CurentZakazchik = new Order();
        public Redaktir(Order selectOrder)
        {
            InitializeComponent();

            if (selectOrder != null)
            {
                _CurentZakazchik = selectOrder;

            }



            DataContext = _CurentZakazchik;
        }

        private void Addd_Click(object sender, RoutedEventArgs e)
        {
            if (_CurentZakazchik.ID == 0)
            {
                dbkursEntities.GetContext().Order.Add(_CurentZakazchik);
            }

            try
            {
                dbkursEntities.GetContext().SaveChanges();
                MessageBox.Show("Пользователь сохранен");
                Close();
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Otmen_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
