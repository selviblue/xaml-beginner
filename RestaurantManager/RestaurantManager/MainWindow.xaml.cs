using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RestaurantManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OrderView_Click(object sender, RoutedEventArgs e)
        {
            ExpeditePage expedited = new ExpeditePage();
            NavigationService.GetNavigationService(this).Navigate(expedited);
        }

        private void SubmitOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderPage order = new OrderPage();
            NavigationService.GetNavigationService(this).Navigate(order);
        }
    }
}
