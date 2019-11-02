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
        //backer for pbj
        private PrehistoricPBJ pbj;
        //backer for combo
        private CretaceousCombo cb;
        /// <summary>
        /// constuctor for pbj
        /// </summary>
        /// <param name="pb"></param>
        public CustomPBJ(PrehistoricPBJ pb)
        {
            InitializeComponent();
            this.pbj = pb;
        }
        /// <summary>
        /// constrructor for combo
        /// </summary>
        /// <param name="cb"></param>
        public CustomPBJ(CretaceousCombo cb)
        {
            InitializeComponent();
            this.cb = cb;
            if (cb.Entrees is PrehistoricPBJ bt)
                this.pbj = bt;
            Button done = new Button();
            done.Content = "Done";
            done.FontFamily = new FontFamily("Showcard Gothic");
            this.page.Children.Add(done);
            done.Click += Done;
        }
        /// <summary>
        /// holds jelly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldJelly(object sender, RoutedEventArgs e)
        {
            pbj.HoldJelly();
        }
        /// <summary>
        /// holds pb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPB(object sender, RoutedEventArgs e)
        {
            pbj.HoldPeanutButter();
        }
        /// <summary>
        /// Marked as done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(this.cb));
        }

    }
}
