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
        private VelociWrap vw;
        private CretaceousCombo cb;
        public CustomVelociWrap(VelociWrap vw)
        {
            InitializeComponent();
            this.vw = vw;
        }
        public CustomVelociWrap(CretaceousCombo cb)
        {
            InitializeComponent();
                this.cb = cb; 
            if (cb.Entrees is VelociWrap bt)
                this.vw = bt;
        }
        private void OnHoldDressing(object sender, RoutedEventArgs e)
        {
            vw.HoldDressing();
        }
        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            vw.HoldLettuce();
        }
        private void OnHoldCheese(object sender, RoutedEventArgs e)
        {
            vw.HoldCheese();
        }
        private void Done(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(this.cb));
        }
    }
}
