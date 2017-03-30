using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CPSC_481_Horizontal_Prototype.Classes
{
    /// <summary>
    /// This class represents a single tab
    /// </summary>
    public class UserTab
    {
        private string tabName;
        private Dictionary<MenuItem, int> currentOrder = new Dictionary<MenuItem, int>();
        private Dictionary<MenuItem, int> orderTray = new Dictionary<MenuItem, int>();
        public double amountOwing { get; set; }
        private Button btn_tab;

        public UserTab(string tabName)
        {
            this.tabName = tabName;
            amountOwing = 0;
        }

        public void OrderItem(KeyValuePair<MenuItem, int> order)
        {
            if (currentOrder.ContainsKey(order.Key))
                currentOrder[order.Key] += order.Value;
            else
                currentOrder.Add(order.Key, order.Value);

            amountOwing += order.Key.price*currentOrder[order.Key];
        }

        public void AddToTray(MenuItem item, int quantity)
        {
            MainScreen ms = Switcher.pageSwitcher;

            if (orderTray.ContainsKey(item))
                orderTray[item]+= quantity;
            else
                orderTray.Add(item, quantity);

            double queueTotal = 0;
            ms.sp_item_names.Children.Clear();
            ms.sp_item_quantity.Children.Clear();
            ms.sp_item_prices.Children.Clear();
           
            foreach (KeyValuePair<MenuItem, int> order in orderTray)
            {
                Label name = new Label();
                Label item_quantity = new Label();
                Label price = new Label();


                //set name, quantity and price of drinks in order queue
                //order.Key.name is the name of the item
                //orderTray[order.Key] is price per item

                name.Content = order.Key.name;
                item_quantity.Content = "x" + orderTray[order.Key];
                price.Content = "$" + order.Key.price * orderTray[order.Key];
                queueTotal += order.Key.price * orderTray[order.Key];

                ms.sp_item_names.Children.Add(name);
                ms.sp_item_quantity.Children.Add(item_quantity);
                ms.sp_item_prices.Children.Add(price);

                //update order queue total
                ms.lbl_queueTotal.Content = "Total: $" + queueTotal;
            }
        }

        public void PlaceOrder()
        {
            foreach (KeyValuePair<MenuItem, int> order in orderTray)
            {
                OrderItem(order);
            }
            Switcher.pageSwitcher.lbl_tabTotal.Content = "Total: $" + amountOwing;
        }

        override public string ToString()
        {
            return tabName;
        }

        public Button GetTabButton()
        {
            return btn_tab;
        }

        public void SetTabButton(Button btn_tab)
        {
            this.btn_tab = btn_tab;
        }

        //temporary method to remove items from order queue
        public void clearTray()
        {
            MainScreen ms = Switcher.pageSwitcher;

            orderTray.Clear();
            ms.sp_item_names.Children.Clear();
            ms.sp_item_prices.Children.Clear();
            ms.sp_item_quantity.Children.Clear();
        }

    }
}
