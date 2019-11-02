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
        private TRexKingBurger tr;
        private CretaceousCombo cb;
        public CustomTRex(TRexKingBurger tr)
        {
            InitializeComponent();
            this.tr = tr;
        }
        public CustomTRex(CretaceousCombo cb)
        {
            InitializeComponent();
            this.cb = cb;
            if (cb.Entrees is TRexKingBurger bt)
                this.tr = bt;
        }
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            tr.HoldBun();
        }
        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            tr.HoldPickle();
        }
        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            tr.HoldKetchup();
        }
        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            tr.HoldMustard();
        }
        private void OnHoldMayo(object sender, RoutedEventArgs e)
        {
            tr.HoldMayo();
        }
        private void OnHoldTomato(object sender, RoutedEventArgs e)
        {
            tr.HoldTomato();
        }
        private void OnHoldLettuse(object sender, RoutedEventArgs e)
        {
            tr.HoldLettuce();
        }
        private void OnHoldOnion(object sender, RoutedEventArgs e)
        {
            tr.HoldOnion();
        }
        private void Done(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(this.cb));
        }
    }
}
