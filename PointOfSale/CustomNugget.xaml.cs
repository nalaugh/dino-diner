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
        private DinoNuggets dn;
        private CretaceousCombo cb;
        public CustomNugget(DinoNuggets dn)
        {
            InitializeComponent();
            this.dn = dn;
        }
        public CustomNugget(CretaceousCombo cb)
        {
            InitializeComponent();
            this.cb = cb;
            if (cb.Entrees is DinoNuggets bt)
                this.dn = bt;
        }
        private void AddNugget(object sender, RoutedEventArgs e)
        {
            dn.AddNugget();
        }
        private void Done(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(this.cb));
        }
    }
}
