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
        private SteakosaurusBurger st;
        public CustomSteakosaurus(SteakosaurusBurger st)
        {
            InitializeComponent();
            this.st = st;
        }
        public CustomSteakosaurus(CretaceousCombo cb)
        {
            InitializeComponent();
            if (cb.Entrees is SteakosaurusBurger bt)
                this.st = bt;
        }
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            st.HoldBun();
        }
        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            st.HoldPickle();
        }
        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            st.HoldKetchup();
        }
        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            st.HoldMustard();
        }
    }
}
