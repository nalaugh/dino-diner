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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AddToCombo.xaml
    /// </summary>
    public partial class AddToCombo : Page
    {
        public AddToCombo()
        {
            InitializeComponent();
        }

        private void Side(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }
        private void Drink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
