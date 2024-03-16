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

using Lab1.MakdoknekDataSetTableAdapters;

namespace Lab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClientTableAdapter client = new ClientTableAdapter();
        MenuTableAdapter menu = new MenuTableAdapter();
        BookingTableAdapter booking = new BookingTableAdapter();

        int flag = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).IsEnabled == true)
            {
                if (flag > 2)
                    flag = -1;
                flag++;
            }
            if (flag == 0)
                ClientDateGrid.ItemsSource = client.GetData();
            if (flag == 1)
                ClientDateGrid.ItemsSource = menu.GetData();
            if (flag == 2)
                ClientDateGrid.ItemsSource = booking.GetData();
        }
    }
}
