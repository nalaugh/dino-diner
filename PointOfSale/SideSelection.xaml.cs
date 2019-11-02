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
        //set the comb to false
        private bool comb = false;
        /// <summary>
        /// side field 
        /// </summary>
        public Side Side { get; set; }
        /// <summary>
        /// combo field 
        /// </summary>
        private CretaceousCombo cb { get; set; }
        /// <summary>
        /// Construction of a the side selection page
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// cinstuctor if drink is selected
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.Side = side;
        }
        /// <summary>
        /// constuctor if read in from the combo
        /// </summary>
        /// <param name="cb"></param>
        public SideSelection(CretaceousCombo cb)
        {
            InitializeComponent();
            this.cb = cb;
            this.Side = cb.Sides;
            comb = true;
        }
        /// <summary>
        /// sets the side if there is a comb it changes
        /// </summary>
        /// <param name="side"></param>
        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                if(!comb)
                {
                    order.Add(side);
                    this.Side = side;
                }
                else
                {
                    this.cb.Sides = side;
                    this.Side = side;
                }
                
            }
        }
        /// <summary>
        /// set the size of the assinment
        /// </summary>
        /// <param name="size"></param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
            {
                this.Side.Size = size;
            }
        }
        /// <summary>
        /// is a done metheod
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done(object sender, EventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// changes the side to fryceritop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseFryceritops(object sender, RoutedEventArgs e)
        {
            SelectSide(new Fryceritops());


        }
        /// <summary>
        /// changes the side to tatertots
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseTriceritots(object sender, RoutedEventArgs e)
        {


            SelectSide(new Triceritots());


        }
        /// <summary>
        /// changes the side to mac and cheese
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseMac(object sender, RoutedEventArgs e)
        {


            SelectSide(new MeteorMacAndCheese());


        }
        private void ChooseMezz(object sender, RoutedEventArgs e)
        {


            SelectSide(new MezzorellaSticks());


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
