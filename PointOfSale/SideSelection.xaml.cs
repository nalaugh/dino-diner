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
        /// <summary>
        /// Construction of a the side selection page
        /// </summary>

        public SideSelection()
        {
            InitializeComponent();
        }
    }
}
