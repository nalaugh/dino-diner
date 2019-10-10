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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : PageFunction<String>
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        private void Brontowurst(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddToCombo());
        }
        private void DinoNuggets(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddToCombo());
        }
        private void PBJ(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddToCombo());
        }
        private void Wings(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddToCombo());
        }
        private void TRex(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddToCombo());
        }
        private void Wrap(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddToCombo());
        }
        private void Burger(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddToCombo());
        }
    }
}
