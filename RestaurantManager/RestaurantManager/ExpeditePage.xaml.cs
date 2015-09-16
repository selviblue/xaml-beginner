using RestaurantManager.Models;
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
    /// Interaction logic for ExpeditePage.xaml
    /// </summary>
    public partial class ExpeditePage : Page
    {
        public ExpeditePage()
        {
            InitializeComponent();
            this.Loaded += ExpeditePage_Loaded;
        }

        void ExpeditePage_Loaded(object sender, RoutedEventArgs e)
        {
            dgGrid.ItemsSource = new DataManager().OrderItems;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainPage = new MainWindow();
            NavigationService.GetNavigationService(this).Navigate(mainPage);
        }
    }
}
