/*OrderContrrol
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
    /// Interaction logic for OrderContrrol.xaml
    /// </summary>
    public partial class OrderContrrol : UserControl
    {
        public NavigationService NavigationService { get; set; }
        public OrderContrrol()
        {
            InitializeComponent();
        }

        /// <summary>
        /// if selected it sends to the page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrderItem.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));

            }
            else if (OrderItem.SelectedItem is Entree entree)
            {
                NavigationService?.Navigate(new SelectEntree(entree));

            }
            else if (OrderItem.SelectedItem is Drink drink)
            {
                
                NavigationService?.Navigate(new DrinkSelection(drink));
            }
            else if (OrderItem.SelectedItem is CretaceousCombo cretaceous)
            {
                NavigationService?.Navigate(new ComboSelection(cretaceous));
            }
        }
        /// <summary>
        /// removes item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Remove((sender as Button).Tag as IOrderItem);
            }
        }
    }

}