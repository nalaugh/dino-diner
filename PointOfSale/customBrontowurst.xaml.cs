/*customBrontowurst
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
    /// Interaction logic for customBrontowurst.xaml
    /// </summary>
    public partial class customBrontowurst : Page
    {
        //Backer fort the entree
        private Brontowurst bt;
        //backer for the combo
        private CretaceousCombo cb;
        /// <summary>
        /// constusctor for the entree
        /// </summary>
        /// <param name="bt"></param>
        public customBrontowurst(Brontowurst bt)
        {
            InitializeComponent();
            this.bt = bt;
        }
        /// <summary>
        /// constuctor for the combo
        /// </summary>
        /// <param name="cb"></param>
        public customBrontowurst(CretaceousCombo cb)
        {
            InitializeComponent();
            this.cb = cb;
            if (cb.Entrees is Brontowurst bt)
                this.bt = bt;
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
            if (cb == null)
            {
                bt.HoldBun();
            }
            else
            {
                if(cb.Entrees is Brontowurst bt)
                {
                    bt.HoldBun();
                }
            }
        }
        /// <summary>
        /// hold the pepper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPepper(object sender, RoutedEventArgs e)
        {
            if (cb == null)
            {
                bt.HoldPeppers();
            }
            else
            {
                if (cb.Entrees is Brontowurst bt)
                {
                    bt.HoldPeppers();
                }
            }
        }
        /// <summary>
        /// holds the onions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldOnions(object sender, RoutedEventArgs e)
        {
            if (cb == null)
            {
                bt.HoldOnion();
            }
            else
            {
                if (cb.Entrees is Brontowurst bt)
                {
                    bt.HoldOnion();
                }
            }
        }
        /// <summary>
        /// marked done sending to custom combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(this.cb));
        }
    }
}
