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
        private Brontowurst bt;
        private CretaceousCombo cb;

        public customBrontowurst(Brontowurst bt)
        {
            InitializeComponent();
            this.bt = bt;
        }
        public customBrontowurst(CretaceousCombo cb)
        {
            InitializeComponent();
            this.cb = cb;
            if (cb.Entrees is Brontowurst bt)
                this.bt = bt;
        }
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            bt.HoldBun();
        }
        private void OnHoldPepper(object sender, RoutedEventArgs e)
        {
            bt.HoldPeppers();
        }
        private void OnHoldOnions(object sender, RoutedEventArgs e)
        {
            bt.HoldOnion();
        }
        private void Done(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(this.cb));
        }
    }
}
