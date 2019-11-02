/*Custom steak
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
    /// Interaction logic for CustomSteakosaurus.xaml
    /// </summary>
    public partial class CustomSteakosaurus : Page
    {
        //backer for burger
        private SteakosaurusBurger st;
        //backer for combo
        private CretaceousCombo cb;
        /// <summary>
        /// constuctor for burger
        /// </summary>
        /// <param name="st"></param>
        public CustomSteakosaurus(SteakosaurusBurger st)
        {
            InitializeComponent();
            this.st = st;
        }
        /// <summary>
        /// constucor for combo
        /// </summary>
        /// <param name="cb"></param>
        public CustomSteakosaurus(CretaceousCombo cb)
        {
            InitializeComponent();
            this.cb = cb;
            if (cb.Entrees is SteakosaurusBurger bt)
                this.st = bt;
            Button done = new Button();
            done.Content = "Done";
            done.FontFamily = new FontFamily("Showcard Gothic");
            this.page.Children.Add(done);
            done.Click += Done;
        }
        /// <summary>
        /// holds the bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            st.HoldBun();
        }
        /// <summary>
        /// holds the pickels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            st.HoldPickle();
        }
        /// <summary>
        /// holds the ketchup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            st.HoldKetchup();
        }
        /// <summary>
        /// holds the mustard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            st.HoldMustard();
        }
        /// <summary>
        /// marks done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(this.cb));
        }
    }
}
