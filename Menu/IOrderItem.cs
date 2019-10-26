using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
   public interface IOrderItem : INotifyPropertyChanged
    {
        string Description { get; }
        string[] Special { get; }
        double Price { get; }
    }
}
