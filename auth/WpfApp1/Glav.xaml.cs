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
using Excel = Microsoft.Office.Interop.Excel;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Glav.xaml
    /// </summary>
    public partial class Glav : Window
    {
        public Glav()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
            Manager.MainFrame.Navigate(new Glavnaya1());

        }

        private void Glav_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Glavnaya1());
        }
        private void Zakazchiki_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Zakazchiki());
        }
        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Orders());
        }
        private void Cars_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Cars());
        }
        private void Users_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Users());
        }
        private void Vihod_Click(object sender, RoutedEventArgs e)
        {
            MainWindow exit = new MainWindow();
            exit.Show();
            this.Close();
        }








        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {

        }

        private void Sozdat_Click(object sender, RoutedEventArgs e)
        {
            var application = new Excel.Application();
            application.SheetsInNewWorkbook = 1;

            Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);

            int startRowIndex = 1;

            Excel.Worksheet worksheet = application.Worksheets.Item[1];
            worksheet.Name = "Заказы";

            worksheet.Cells[1][startRowIndex] = "ID";
            worksheet.Cells[2][startRowIndex] = "ФИО";
            worksheet.Cells[3][startRowIndex] = "Вес";
            worksheet.Cells[4][startRowIndex] = "Название заказа";

            startRowIndex++;

            var orders = dbkursEntities.GetContext().Order.ToList();

            foreach (var order in orders)
            {
                worksheet.Cells[1][startRowIndex] = order.ID;
                worksheet.Cells[2][startRowIndex] = order.Name;
                worksheet.Cells[3][startRowIndex] = order.Weight;
                worksheet.Cells[4][startRowIndex] = order.NameOfOrder;

                startRowIndex++;
            }

            Excel.Range sumRange = worksheet.Range[worksheet.Cells[1][startRowIndex], worksheet.Cells[3][startRowIndex]];
            sumRange.Merge();
            sumRange.Value = "Количество заказов:";
            sumRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            worksheet.Cells[4][startRowIndex] = orders.Count();

            Excel.Range rangeBorders = worksheet.Range[worksheet.Cells[1][1], worksheet.Cells[4][startRowIndex]];
            rangeBorders.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle =
            rangeBorders.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle =
            rangeBorders.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle =
            rangeBorders.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle =
            rangeBorders.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle =
            rangeBorders.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;

            worksheet.Columns.AutoFit();

            application.Visible = true;
        }
    }
}
