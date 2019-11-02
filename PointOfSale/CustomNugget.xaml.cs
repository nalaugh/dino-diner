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
    /// Interaction logic for CustomNugget.xaml
    /// </summary>
    public partial class CustomNugget : Page
    {
        //backer for nugget
        private DinoNuggets dn;
        //backer for combo
        private CretaceousCombo cb;
        /// <summary>
        /// cinstuctor for nuggest
        /// </summary>
        /// <param name="dn"></param>
        public CustomNugget(DinoNuggets dn)
        {
            InitializeComponent();
            this.dn = dn;
        }
        /// <summary>
        /// constuctor for combo
        /// </summary>
        /// <param name="cb"></param>
        public CustomNugget(CretaceousCombo cb)
        {
            InitializeComponent();
            this.cb = cb;
            if (cb.Entrees is DinoNuggets bt)
                this.dn = bt;
            Button done = new Button();
            done.Content = "Done";
            done.FontFamily = new FontFamily("Showcard Gothic");
            this.page.Children.Add(done);
            done.Click += Done;
        }
        /// <summary>
        /// Adds a nugget
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNugget(object sender, RoutedEventArgs e)
        {
            dn.AddNugget();
        }
        /// <summary>
        /// marked as done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(this.cb));
        }
    }
}
