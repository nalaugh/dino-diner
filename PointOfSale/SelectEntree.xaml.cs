/*SelectEntree
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
    /// Create a new page named EntreeSelection.xaml 
    /// that displays buttons for the seven current entrees:
    /// Brontowurst, Dino-Nuggets, Prehistoric PB&J, Pterodactyl Wings,
    /// Steakosarus Burger, T-Rex King Burger, and Veloci-Wrap.
    /// </summary>
    public partial class SelectEntree : Page
    {
        //field for the entree
        private Entree Entree { get; set; }
        /// <summary>
        /// constructs the Entree page
        /// </summary>
        public SelectEntree()
        {
            InitializeComponent();
        }
        /// <summary>
        /// constuctor for an entree
        /// </summary>
        /// <param name="entree"></param>
        public SelectEntree(Entree entree)
        {
            InitializeComponent();
            this.Entree = entree;
        }
        /// <summary>
        /// set the entrees
        /// </summary>
        /// <param name="entree"></param>
        private void SelectEntrees(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
                this.Entree = entree;
            }
        }
        /// <summary>
        /// set the entree to brostoswarst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseBront(object sender, RoutedEventArgs e)
        {
  
            SelectEntrees(new Brontowurst());
            if(this.Entree is Brontowurst bt)
            NavigationService.Navigate(new customBrontowurst(bt));


        }
        /// <summary>
        /// set the entree to nuggest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseNuggt(object sender, RoutedEventArgs e)
        {

            SelectEntrees(new DinoNuggets());
            if(this.Entree is DinoNuggets dn)
            NavigationService.Navigate(new CustomNugget(dn));
        }
        /// <summary>
        /// set the entree to wings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Choosewings(object sender, RoutedEventArgs e)
        {

            SelectEntrees(new PterodactylWings());
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// set the entree to PBJ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChoosePbJ(object sender, RoutedEventArgs e)
        {

            SelectEntrees(new PrehistoricPBJ());
            if(this.Entree is PrehistoricPBJ pBJ)
            NavigationService.Navigate(new CustomPBJ(pBJ));
        }
        /// <summary>
        /// Set the entree to kingburger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseKing(object sender, RoutedEventArgs e)
        {

            SelectEntrees(new TRexKingBurger());
            if(this.Entree is TRexKingBurger tr)
            NavigationService.Navigate(new CustomTRex(tr));
        }
        /// <summary>
        /// set the entree to burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseBurger(object sender, RoutedEventArgs e)
        {

            SelectEntrees(new SteakosaurusBurger());
            if(this.Entree is SteakosaurusBurger st)
            NavigationService.Navigate(new CustomSteakosaurus(st));
        }
        /// <summary>
        /// set the entree to wrap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseWrap(object sender, RoutedEventArgs e)
        {
            SelectEntrees(new VelociWrap());
            if(this.Entree is VelociWrap vw)
            NavigationService.Navigate(new CustomVelociWrap(vw));
        }
    }
}
