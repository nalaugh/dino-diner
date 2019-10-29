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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           Order order = (Order)DataContext;
            OrderList.NavigationService = OrderInterface.NavigationService;


        }
        /// <summary>
        /// this marks the page being done loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arge"></param>
        public void OnLoadCompleted(object sender, NavigationEventArgs arge)
        {
            BindDataContextToPage();

        }
        /// <summary>
        /// this makes that the data has changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            BindDataContextToPage();

        }
        /// <summary>
        /// this sets the data context
        /// </summary>
        private void SetFrameDataContext()
        {
            FrameworkElement content = OrderInterface.Content as FrameworkElement;
            if (content == null) return;
            content.DataContext = OrderInterface.DataContext;
        }
        /// <summary>
        /// this sets the data context
        /// </summary>
        private void BindDataContextToPage()
        {
            if (OrderInterface.Content is FrameworkElement element)
            {
                element.DataContext = OrderInterface.DataContext;
            }

        }
        private void Done(object sender, RoutedEventArgs arge)
        {
            if (OrderInterface.NavigationService.CanGoBack)
            {
                OrderInterface.NavigationService.GoBack();
            }
            else
            {
                OrderInterface.NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}