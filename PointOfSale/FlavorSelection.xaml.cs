/*FlavorSelection
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

namespace PointOfSale
{
    /// <summary>
    /// Create a new page named FlavorSelection.xaml 
    /// that displays buttons for the seven current Sodasaurus 
    /// flavors offered by the DinoDiner: Cherry, Chocolate, Cola, Lime, 
    /// Orange, Root Beer, and Vanilla.
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// constructs the page
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }
    }
}
