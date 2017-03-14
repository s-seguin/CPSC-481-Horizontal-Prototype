using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC_481_Horizontal_Prototype.Classes
{
    /// <summary>
    /// This class represents a single tab
    /// </summary>
    public class UserTab
    {
        private string tabName;
        private List<MenuItem> currentOrder = new List<MenuItem>();
        private double amountOwing;

        public UserTab(string tabName)
        {
            this.tabName = tabName;
        }

        public void OrderItem(MenuItem item)
        {
            currentOrder.Add(item);
            amountOwing += item.price;
        }

    }
}
