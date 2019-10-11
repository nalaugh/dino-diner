/*ComboSelection
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
    /// Create a new page named ComboSelection.xaml 
    /// that displays buttons for the seven current combos: 
    /// Brontowurst Combo, Dino-Nuggets Combo, Prehistoric PB&J Combo,
    /// Pterodactyl Wings Combo, Steakosarus Burger Combo, T-Rex King Burger
    /// Combo, and Veloci-Wrap Combo. Clicking any of these should take you
    /// to the customize combo page.
    /// </summary>
    public partial class ComboSelection : PageFunction<String>
    {
        /// <summary>
        /// constructs the page for combo selections
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// navigates to cutomize combo selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Brontowurst(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// navigates to cutomize combo selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DinoNuggets(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// navigates to cutomize combo selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PBJ(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// navigates to cutomize combo selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wings(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// navigates to cutomize combo selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TRex(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// navigates to cutomize combo selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wrap(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// navigates to cutomize combo selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Burger(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
    }
}
