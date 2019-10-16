/*DrinkSelection
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
    /// Create a new page named DrinkSelection.xaml 
    /// that displays buttons for the four current drinks: 
    /// Sodasaurus, Tryrannotea, Jurassic Java, and Water. 
    /// It should also have three radio buttons for selecting 
    /// the size (small, medium, and large). Finally, 
    /// it should dynamically add/remove buttons for lemon, flavor, 
    /// decaf, and sweet, when appropriate for the currently selected drink.
    /// Clicking the flavor button should open the Flavor Selection page.
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// constructor for the drinks page
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// creats a clickable button for flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Soda(object sender, RoutedEventArgs e)
        {
            this.top.Children.Clear();
            this.mid.Children.Clear();
            this.bottom.Children.Clear();
            Button flavor = new Button();
            flavor.FontFamily = new FontFamily("Showcard Gothic");
           
            flavor.Content = "Flavor";
            flavor.Click += Flavor;
            this.top.Children.Add(flavor);
        }
        /// <summary>
        /// send the page to the flavor page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Flavor(object sender, EventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
        /// <summary>
        /// creats a button for lemon and sweet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tea(object sender, RoutedEventArgs e)
        {
            this.top.Children.Clear();
            this.mid.Children.Clear();
            this.bottom.Children.Clear();
            Button lemon = new Button();
            lemon.FontFamily = new FontFamily("Showcard Gothic");
            lemon.Content = "Lemon";
            this.top.Children.Add(lemon);
            Button sweet = new Button();
            sweet.FontFamily = new FontFamily("Showcard Gothic");
            sweet.Content = "Sweet";
            this.mid.Children.Add(sweet);
        }
        /// <summary>
        /// creats a button for decaf ice and room for cream
        /// </summary>
        /// <param name="secder"></param>
        /// <param name="e"></param>
        private void Coffee(object secder, RoutedEventArgs e)
        {
            this.top.Children.Clear();
            this.mid.Children.Clear();
            this.bottom.Children.Clear();
            Button decaf = new Button();
            decaf.FontFamily = new FontFamily("Showcard Gothic");

            decaf.Content = "Decaf";
            this.top.Children.Add(decaf);
            Button ice = new Button();
            ice.FontFamily = new FontFamily("Showcard Gothic");
            ice.Content = "Hold Ice";
            this.top.Children.Add(ice) ;
            Button room = new Button();
            room.FontFamily = new FontFamily("Showcard Gothic");
            room.Content = "Leave room";
            this.bottom.Children.Add(room);
        }
        /// <summary>
        /// creats a button for lemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Water(object sender, RoutedEventArgs e)
        {
            this.top.Children.Clear();
            this.mid.Children.Clear();
            this.bottom.Children.Clear();
            Button lemon = new Button();
            lemon.FontFamily = new FontFamily("Showcard Gothic");
            lemon.Content = "Lemon";
            this.top.Children.Add(lemon);
        }
    }
}
