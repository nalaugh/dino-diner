/*DrinkSelection
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
    /// Create a new page named DrinkSelection.xaml 
    /// that displays buttons for the four current drinks: 
    /// Sodasaurus, Tryrannotea, Jurassic Java, and Water. 
    /// It should also have three radio buttons for selecting 
    /// the size (small, medium, and large). Finally, 
    /// it should dynamically add/remove buttons for lemon, flavor, 
    /// decaf, and sweet, when appropriate for the currently selected drink.
    /// Clicking the flavor button should open the Flavor Selection page.
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private bool combo = false;
        private Drink Drink { get; set; }
        private CretaceousCombo cb { get; set; }

        /// <summary>
        /// constructor for the drinks page
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();

        }
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.Drink = drink;
            if (drink is Sodasaurus soda)
            {
                this.top.Children.Clear();
                this.mid.Children.Clear();
                this.bottom.Children.Clear();
                Button flavor = new Button();
                flavor.FontFamily = new FontFamily("Showcard Gothic");

                flavor.Content = "Flavor";
                flavor.Click += Flavor;
                this.top.Children.Add(flavor);
            }
            if (drink is Tyrannotea tea)
            {
                SelectDrink(new Tyrannotea());
                this.top.Children.Clear();
                this.mid.Children.Clear();
                this.bottom.Children.Clear();
                Button lemon = new Button();
                lemon.FontFamily = new FontFamily("Showcard Gothic");
                lemon.Content = "Lemon";
                this.top.Children.Add(lemon);
                Button sweet = new Button();
                sweet.FontFamily = new FontFamily("Showcard Gothic");
                sweet.Content = "Sweet";
                this.mid.Children.Add(sweet);
                lemon.Click += Lemon;
                sweet.Click += Sweet;
            }
            if(drink is Water wt)
            {
                SelectDrink(new Water());
                this.top.Children.Clear();
                this.mid.Children.Clear();
                this.bottom.Children.Clear();
                Button lemon = new Button();
                lemon.FontFamily = new FontFamily("Showcard Gothic");
                lemon.Content = "Lemon";
                this.top.Children.Add(lemon);
                lemon.Click += Lemon;
                Button ice = new Button();
                ice.FontFamily = new FontFamily("Showcard Gothic");
                ice.Content = "Hold Ice";
                this.mid.Children.Add(ice);
                ice.Click += HoldIce;
            }
            if(drink is JurrassicJava jv)
            {
                SelectDrink(new JurrassicJava());
                this.top.Children.Clear();
                this.mid.Children.Clear();
                this.bottom.Children.Clear();
                Button decaf = new Button();
                decaf.FontFamily = new FontFamily("Showcard Gothic");

                decaf.Content = "Decaf";
                this.top.Children.Add(decaf);
                Button ice = new Button();
                ice.FontFamily = new FontFamily("Showcard Gothic");
                ice.Content = "Hold Ice";
                this.mid.Children.Add(ice);
                Button room = new Button();
                room.FontFamily = new FontFamily("Showcard Gothic");
                room.Content = "Leave room";
                this.bottom.Children.Add(room);
                ice.Click += HoldIce;
                decaf.Click += Decaf;
                room.Click += LeaveRoom;
            }
        }
        public DrinkSelection(CretaceousCombo cb)
        {
            InitializeComponent();
            this.cb = cb;
            this.Drink = cb.Drinks;
            combo = true;
            if (this.Drink is Sodasaurus soda)
            {
                this.top.Children.Clear();
                this.mid.Children.Clear();
                this.bottom.Children.Clear();
                Button flavor = new Button();
                flavor.FontFamily = new FontFamily("Showcard Gothic");

                flavor.Content = "Flavor";
                flavor.Click += Flavor;
                this.top.Children.Add(flavor);
            }
            if (this.Drink is Tyrannotea tea)
            {
                SelectDrink(new Tyrannotea());
                this.top.Children.Clear();
                this.mid.Children.Clear();
                this.bottom.Children.Clear();
                Button lemon = new Button();
                lemon.FontFamily = new FontFamily("Showcard Gothic");
                lemon.Content = "Lemon";
                this.top.Children.Add(lemon);
                Button sweet = new Button();
                sweet.FontFamily = new FontFamily("Showcard Gothic");
                sweet.Content = "Sweet";
                this.mid.Children.Add(sweet);
                lemon.Click += Lemon;
                sweet.Click += Sweet;
            }
            if (this.Drink is Water wt)
            {
                SelectDrink(new Water());
                this.top.Children.Clear();
                this.mid.Children.Clear();
                this.bottom.Children.Clear();
                Button lemon = new Button();
                lemon.FontFamily = new FontFamily("Showcard Gothic");
                lemon.Content = "Lemon";
                this.top.Children.Add(lemon);
                lemon.Click += Lemon;
                Button ice = new Button();
                ice.FontFamily = new FontFamily("Showcard Gothic");
                ice.Content = "Hold Ice";
                this.mid.Children.Add(ice);
                ice.Click += HoldIce;
            }
            if (this.Drink is JurrassicJava jv)
            {
                SelectDrink(new JurrassicJava());
                this.top.Children.Clear();
                this.mid.Children.Clear();
                this.bottom.Children.Clear();
                Button decaf = new Button();
                decaf.FontFamily = new FontFamily("Showcard Gothic");

                decaf.Content = "Decaf";
                this.top.Children.Add(decaf);
                Button ice = new Button();
                ice.FontFamily = new FontFamily("Showcard Gothic");
                ice.Content = "Hold Ice";
                this.mid.Children.Add(ice);
                Button room = new Button();
                room.FontFamily = new FontFamily("Showcard Gothic");
                room.Content = "Leave room";
                this.bottom.Children.Add(room);
                ice.Click += HoldIce;
                decaf.Click += Decaf;
                room.Click += LeaveRoom;
            }


        }

        private void SelectDrink(Drink drink)
        {
            if (DataContext is Order order)
            {

                if (!combo)
                {
                    order.Add(drink);
                    this.Drink = drink;
                }
                else
                {
                    this.cb.Drinks = drink;
                    this.Drink = drink;
                }


            }
        }
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
            {
                this.Drink.Size = size;
            }
        }

        /// <summary>
        /// creats a clickable button for flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Soda(object sender, RoutedEventArgs e)
        {
            this.top.Children.Clear();
            this.mid.Children.Clear();
            this.bottom.Children.Clear();
            Button flavor = new Button();
            flavor.FontFamily = new FontFamily("Showcard Gothic");

            flavor.Content = "Flavor";
            flavor.Click += Flavor;
            this.top.Children.Add(flavor);
        }
        /// <summary>
        /// send the page to the flavor page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Flavor(object sender, EventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection(Drink));
        }
        private void Done(object sender, EventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// creats a button for lemon and sweet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tea(object sender, RoutedEventArgs e)
        {
            SelectDrink(new Tyrannotea());
            this.top.Children.Clear();
            this.mid.Children.Clear();
            this.bottom.Children.Clear();
            Button lemon = new Button();
            lemon.FontFamily = new FontFamily("Showcard Gothic");
            lemon.Content = "Lemon";
            this.top.Children.Add(lemon);
            Button sweet = new Button();
            sweet.FontFamily = new FontFamily("Showcard Gothic");
            sweet.Content = "Sweet";
            this.mid.Children.Add(sweet);
            lemon.Click += Lemon;
            sweet.Click += Sweet;

        }
        /// <summary>
        /// creats a button for decaf ice and room for cream
        /// </summary>
        /// <param name="secder"></param>
        /// <param name="e"></param>
        private void Coffee(object secder, RoutedEventArgs e)
        {
            SelectDrink(new JurrassicJava());
            this.top.Children.Clear();
            this.mid.Children.Clear();
            this.bottom.Children.Clear();
            Button decaf = new Button();
            decaf.FontFamily = new FontFamily("Showcard Gothic");

            decaf.Content = "Decaf";
            this.top.Children.Add(decaf);
            Button ice = new Button();
            ice.FontFamily = new FontFamily("Showcard Gothic");
            ice.Content = "Hold Ice";
            this.mid.Children.Add(ice);
            Button room = new Button();
            room.FontFamily = new FontFamily("Showcard Gothic");
            room.Content = "Leave room";
            this.bottom.Children.Add(room);
            ice.Click += HoldIce;
            decaf.Click += Decaf;
            room.Click += LeaveRoom;
        }
        /// <summary>
        /// creats a button for lemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Water(object sender, RoutedEventArgs e)
        {
            SelectDrink(new Water());
            this.top.Children.Clear();
            this.mid.Children.Clear();
            this.bottom.Children.Clear();
            Button lemon = new Button();
            lemon.FontFamily = new FontFamily("Showcard Gothic");
            lemon.Content = "Lemon";
            this.top.Children.Add(lemon);
            lemon.Click += Lemon;
            Button ice = new Button();
            ice.FontFamily = new FontFamily("Showcard Gothic");
            ice.Content = "Hold Ice";
            this.mid.Children.Add(ice);
            ice.Click += HoldIce;
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
        /// <summary>
        /// Holds Ice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void HoldIce(object sender, RoutedEventArgs e)
        {
            if (Drink is Water water)
            {
                water.Add();
            }
            if (Drink is JurrassicJava java)
            {
                java.AddIce();
            }
        }
        /// <summary>
        /// Makes Decaf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Decaf(object sender, RoutedEventArgs e)
        {
            if (Drink is JurrassicJava java)
            {
                java.MakeDecaf();
            }
        }
        /// <summary>
        /// Adds Lemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Lemon(object sender, RoutedEventArgs e)
        {
            if (Drink is Water water)
            {
                water.AddLemon();
            }
            if (Drink is Tyrannotea tea)
            {
                tea.AddLemon();
            }
        }
        /// <summary>
        /// Leaves room
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LeaveRoom(object sender, RoutedEventArgs e)
        {
            if (Drink is JurrassicJava java)
            {
                java.RoomForCream();
            }
        }
        /// <summary>
        /// Makes Sweet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Sweet(object sender, RoutedEventArgs e)
        {
            if (Drink is Tyrannotea tea)
            {
                tea.AddMakeSweet();
            }
        }

    }
}
