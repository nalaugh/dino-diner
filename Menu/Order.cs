using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
       public  ObservableCollection<IOrderItem> Item { get; set; }
       public  double SubtotalCost { get; }
       public  double SalesTaxRate { get; protected set; }
       public double TotalCost { get; }

    }
}
