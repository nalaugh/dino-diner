/*MenuCatagorySelection
 * Natalie Laughlin
 */
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
    /// Create a new page named MenuCategorySelection.xaml 
    /// that displays buttons for the four current menu categories:
    /// Combos, Entrees, Sides, and Drinks. Clicking any of these
    /// buttons should take you to the appropriate selection page.
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// Constructs the menu page
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// navigates to the drink page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// navigates to the comboselection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCombo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComboSelection());
        }
        /// <summary>
        /// navigates to the side selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSides(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }
        /// <summary>
        /// navigates to the entree selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectEntree(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectEntree());
        }
       
    }
}
