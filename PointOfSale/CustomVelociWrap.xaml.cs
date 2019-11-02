/*Custom Wrop
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
    /// Interaction logic for CustomVelociWrap.xaml
    /// </summary>
    public partial class CustomVelociWrap : Page
    {
        //backer for the wrap
        private VelociWrap vw;
        //backer for the combo
        private CretaceousCombo cb;
        /// <summary>
        /// constor for the wrap
        /// </summary>
        /// <param name="vw"></param>
        public CustomVelociWrap(VelociWrap vw)
        {
            InitializeComponent();
            this.vw = vw;
        }
        /// <summary>
        /// backer for the combo
        /// </summary>
        /// <param name="cb"></param>
        public CustomVelociWrap(CretaceousCombo cb)
        {
            InitializeComponent();
                this.cb = cb; 
            if (cb.Entrees is VelociWrap bt)
                this.vw = bt;
            Button done = new Button();
            done.Content = "Done";
            done.FontFamily = new FontFamily("Showcard Gothic");
            this.page.Children.Add(done);
            done.Click += Done;
        }
        /// <summary>
        /// holds the dressing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldDressing(object sender, RoutedEventArgs e)
        {
            vw.HoldDressing();
        }
        /// <summary>
        /// holds the lettuce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            vw.HoldLettuce();
        }
        /// <summary>
        /// holds the cheese
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldCheese(object sender, RoutedEventArgs e)
        {
            vw.HoldCheese();
        }
        /// <summary>
        /// marks as done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(this.cb));
        }
    }
}
