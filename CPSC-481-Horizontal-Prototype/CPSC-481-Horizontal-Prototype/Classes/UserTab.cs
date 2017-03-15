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
        private Dictionary<MenuItem, int> currentOrder = new Dictionary<MenuItem, int>();
        private Dictionary<MenuItem, int> orderQueue = new Dictionary<MenuItem, int>();
        private double amountOwing;

        public UserTab(string tabName)
        {
            this.tabName = tabName;
        }

        public void OrderItem(KeyValuePair<MenuItem, int> order)
        {
            if (currentOrder.ContainsKey(order.Key))
                currentOrder[order.Key] += order.Value;
            else
                currentOrder.Add(order.Key, order.Value);

            amountOwing += order.Key.price*currentOrder[order.Key];
        }

        public void AddToQueue(MenuItem item)
        {
            if (orderQueue.ContainsKey(item))
                orderQueue[item]++;
            else
                orderQueue.Add(item, 1);
        }

        public void PlaceOrder()
        {
            foreach (KeyValuePair<MenuItem, int> order in orderQueue)
            {
                OrderItem(order);
            }
        }

        override public string ToString()
        {
            return tabName;
        }

    }
}
