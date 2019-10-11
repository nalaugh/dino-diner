/*SelectEntree
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
    /// Create a new page named EntreeSelection.xaml 
    /// that displays buttons for the seven current entrees:
    /// Brontowurst, Dino-Nuggets, Prehistoric PB&J, Pterodactyl Wings,
    /// Steakosarus Burger, T-Rex King Burger, and Veloci-Wrap.
    /// </summary>
    public partial class SelectEntree : Page
    {
        /// <summary>
        /// constructs the Entree page
        /// </summary>
        public SelectEntree()
        {
            InitializeComponent();
        }
    }
}
