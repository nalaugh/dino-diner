/*FlavorSelection
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
    /// Create a new page named FlavorSelection.xaml 
    /// that displays buttons for the seven current Sodasaurus 
    /// flavors offered by the DinoDiner: Cherry, Chocolate, Cola, Lime, 
    /// Orange, Root Beer, and Vanilla.
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private Drink Drink { get; set; }
        /// <summary>
        /// constructs the page
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructs a page setting the Drink
        /// </summary>
        /// <param name="drink"></param>
        public FlavorSelection(Drink drink)
        {
            InitializeComponent();
            this.Drink = drink;


        }
        /// <summary>
        /// Changes the flavor to cola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cola(object sender, RoutedEventArgs e)
        {

                   if(Drink is Sodasaurus soe)
                    {
                        soe.ChangeFlavor(SodasaurusFlavor.Cola);
                    }

            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Changes the flavor to Chocolate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Chocolate(object sender, RoutedEventArgs e)
        {

                    if (Drink is Sodasaurus soe)
                    {
                        soe.ChangeFlavor(SodasaurusFlavor.Chocolate);
                    }

            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Changes the flavor to Orange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Orange(object sender, RoutedEventArgs e)
        {

                    if (Drink is Sodasaurus soe)
                    {
                        soe.ChangeFlavor(SodasaurusFlavor.Orange);
                    }

            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Changes the flavor to Lime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Line(object sender, RoutedEventArgs e)
        {

                    if (Drink is Sodasaurus soe)
                    {
                        soe.ChangeFlavor(SodasaurusFlavor.Lime);
                    }

            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Changes the flavor to Vanilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Vanilla(object sender, RoutedEventArgs e)
        {

                    if (Drink is Sodasaurus soe)
                    {
                        soe.ChangeFlavor(SodasaurusFlavor.Vanilla);
                    }

            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Changes the flavor to Root Beer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RootBeer(object sender, RoutedEventArgs e)
        {

                    if (Drink is Sodasaurus soe)
                    {
                        soe.ChangeFlavor(SodasaurusFlavor.RootBeer);
                    }
 
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Changes the flavor to Charry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Charry(object sender, RoutedEventArgs e)
        {

                    if (Drink is Sodasaurus soe)
                    {
                        soe.ChangeFlavor(SodasaurusFlavor.Cherry);
                     
                    }

            NavigationService.Navigate(new DrinkSelection());

        }
    }
}
