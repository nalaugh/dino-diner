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
using DinoDiner.Menu;

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
        private CretaceousCombo CretaceousCombo { get; set; }
        /// <summary>
        /// constructs the page for combo selections
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        private void SelectComb(CretaceousCombo cretaceous)
        {
            if (DataContext is Order order)
            {
                order.Item.Add(cretaceous);
                this.CretaceousCombo = cretaceous;
            }
        }
        public ComboSelection(CretaceousCombo cretaceous)
        {
            InitializeComponent();
            this.CretaceousCombo = cretaceous;
        }
        /// <summary>
        /// navigates to cutomize combo selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Brontowurst(object sender, RoutedEventArgs e)
        {
            SelectComb(new CretaceousCombo(new Brontowurst()));
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// navigates to cutomize combo selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DinoNuggets(object sender, RoutedEventArgs e)
        {
            SelectComb(new CretaceousCombo(new DinoNuggets()));
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// navigates to cutomize combo selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PBJ(object sender, RoutedEventArgs e)
        {
            SelectComb(new CretaceousCombo(new PrehistoricPBJ()));
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// navigates to cutomize combo selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wings(object sender, RoutedEventArgs e)
        {
            SelectComb(new CretaceousCombo(new PterodactylWings()));
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// navigates to cutomize combo selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TRex(object sender, RoutedEventArgs e)
        {
            SelectComb(new CretaceousCombo(new TRexKingBurger()));
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// navigates to cutomize combo selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wrap(object sender, RoutedEventArgs e)
        {
            SelectComb(new CretaceousCombo(new VelociWrap()));
            NavigationService.Navigate(new CustomizeCombo());
        }
        /// <summary>
        /// navigates to cutomize combo selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Burger(object sender, RoutedEventArgs e)
        {
            SelectComb(new CretaceousCombo(new SteakosaurusBurger()));
            NavigationService.Navigate(new CustomizeCombo());
        }
    }
}
