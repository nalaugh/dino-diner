/*Custom kingburger
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
    /// Interaction logic for CustomTRex.xaml
    /// </summary>
    public partial class CustomTRex : Page
    {
        //backs the brugers
        private TRexKingBurger tr;
        //backs the combos
        private CretaceousCombo cb;
        /// <summary>
        /// constuctor for the burger
        /// </summary>
        /// <param name="tr"></param>
        public CustomTRex(TRexKingBurger tr)
        {
            InitializeComponent();
            this.tr = tr;
        }
        /// <summary>
        /// constucros for the combo
        /// </summary>
        /// <param name="cb"></param>
        public CustomTRex(CretaceousCombo cb)
        {
            InitializeComponent();
            this.cb = cb;
            if (cb.Entrees is TRexKingBurger bt)
                this.tr = bt;
            Button done = new Button();
            done.Content = "Done";
            done.FontFamily = new FontFamily("Showcard Gothic");
            this.page.Children.Add(done);
            done.Click += Done;
        }
        /// <summary>
        /// hold the bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            tr.HoldBun();
        }
        /// <summary>
        /// holds the pickles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            tr.HoldPickle();
        }
        /// <summary>
        /// holds the ketchup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            tr.HoldKetchup();
        }
        /// <summary>
        /// holds the mustard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            tr.HoldMustard();
        }
        /// <summary>
        /// hold the mayo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs e)
        {
            tr.HoldMayo();
        }
        /// <summary>
        /// holds the tomatos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs e)
        {
            tr.HoldTomato();
        }
        /// <summary>
        /// holds the lettuce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldLettuse(object sender, RoutedEventArgs e)
        {
            tr.HoldLettuce();
        }
        /// <summary>
        /// holds the onions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs e)
        {
            tr.HoldOnion();
        }
        /// <summary>
        /// Marks as done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(this.cb));
        }
    }
}
