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
    /// Interaction logic for Page11.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        private void SelectCombo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComboSelection());
        }
        private void SelectSides(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }
        private void SelectEntree(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectEntree());
        }
        /*
         *    <WrapPanel.Resources>
            <Style TargetType="Button">
                <Setter Property="MinWidth" Value="140"/>

                <Setter Property="MinHeight" Value="140"/>
            </Style>
        </WrapPanel.Resources>*/
    }
}
