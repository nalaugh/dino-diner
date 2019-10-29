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
    ///Create a new page named SideSelection.xaml 
    ///that displays buttons for the four current sides: Fryceritops, 
    ///Triceritots, Meteor Mac & Cheese, and Mozzerella Sticks. 
    ///In addition, it should have three radio buttons for selecting 
    ///the size (small, medium, and large).
    /// </summary>

    public partial class SideSelection : Page
    {
        public Side Side { get; set; }
        /// <summary>
        /// Construction of a the side selection page
        /// </summary>

        public SideSelection()
        {
            InitializeComponent();
        }
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.Side = side;
        }
        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Add(side);
                this.Side = side;
            }
        }
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
            {
                this.Side.Size = size;
            }
        }
        private void Done(object sender, EventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
        private void ChooseFryceritops(object sender, RoutedEventArgs e)
        {
            SelectSide(new Fryceritops());
          
                TriButton.IsEnabled = false;
                MacButton.IsEnabled = false;
                MezzButton.IsEnabled = false;
                FryButton.IsEnabled = false;
            
        }
        private void ChooseTriceritots(object sender, RoutedEventArgs e)
        {


            SelectSide(new Triceritots());
                TriButton.IsEnabled = false;
                MacButton.IsEnabled = false;
                MezzButton.IsEnabled = false;
                FryButton.IsEnabled = false;
            
        }
        private void ChooseMac(object sender, RoutedEventArgs e)
        {


            SelectSide(new MeteorMacAndCheese());
                TriButton.IsEnabled = false;
                MacButton.IsEnabled = false;
                MezzButton.IsEnabled = false;
                FryButton.IsEnabled = false;
            
        }
        private void ChooseMezz(object sender, RoutedEventArgs e)
        {


            SelectSide(new MezzorellaSticks());
                TriButton.IsEnabled = false;
                MacButton.IsEnabled = false;
                MezzButton.IsEnabled = false;
                FryButton.IsEnabled = false;
            
        }
        /// <summary>
        /// Changed the size to Large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnselectLarge(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }
        /// <summary>
        /// chaged the size to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnselectMedium(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }
        /// <summary>
        /// changes the size to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnselectSmall(object sender, RoutedEventArgs e)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

    }
}
