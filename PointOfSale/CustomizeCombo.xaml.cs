/*CustomizeCombo
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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Create a new page named CustomizeCombo.xaml 
    /// that displays buttons with the currently 
    /// selected side, drink, and size for the combo. 
    /// Clicking the side button should take you to the side selection page.
    /// Clicking the drink selection page should take you to 
    /// the drink selection page. It should also have three radio
    /// buttons for selecting the size of the combo 
    /// (small, medium, and large).
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        private CretaceousCombo cb;
        /// <summary>
        /// constructor for the custamize combo page
        /// </summary>
        public CustomizeCombo(CretaceousCombo cb)
        {
            InitializeComponent();
            this.cb = cb;
        }
        /// <summary>
        /// set the size
        /// </summary>
        /// <param name="size"></param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (cb != null)
            {
                this.cb.Size = size;
            }
        }
        /// <summary>
        /// navigates to sides page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Side(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection(cb));
        }
        /// <summary>
        /// navigates to drinks page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Drink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(cb));
        }
        protected void OnselectLarge(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }
        /// <summary>
        /// chaged the size to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnselectMedium(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }
        /// <summary>
        /// changes the size to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnselectSmall(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }
    }
}
