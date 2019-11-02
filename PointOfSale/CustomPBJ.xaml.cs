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
    /// Interaction logic for CustomPBJ.xaml
    /// </summary>
    public partial class CustomPBJ : Page
    {
        private PrehistoricPBJ pbj;
        private CretaceousCombo cb;
        public CustomPBJ(PrehistoricPBJ pb)
        {
            InitializeComponent();
            this.pbj = pb;
        }
        public CustomPBJ(CretaceousCombo cb)
        {
            InitializeComponent();
            this.cb = cb;
            if (cb.Entrees is PrehistoricPBJ bt)
                this.pbj = bt;
        }

        private void OnHoldJelly(object sender, RoutedEventArgs e)
        {
            pbj.HoldJelly();
        }
        private void OnHoldPB(object sender, RoutedEventArgs e)
        {
            pbj.HoldPeanutButter();
        }
        private void Done(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(this.cb));
        }

    }
}
