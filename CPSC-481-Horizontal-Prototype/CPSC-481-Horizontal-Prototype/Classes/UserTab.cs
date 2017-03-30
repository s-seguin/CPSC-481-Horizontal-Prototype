using CPSC_481_Horizontal_Prototype.User_Controls;
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

            ms.sp_tray.Children.Clear();
            ms.focusedTab.LoadTray();

        }

        public void RemoveFromTray(KeyValuePair<MenuItem, int> order, int quantity)
        {
            MainScreen ms = Switcher.pageSwitcher;
            if (order.Value > quantity)
            {
                orderTray.Remove(order.Key);
                orderTray.Add(order.Key, (order.Value - quantity));
            }
            else
            {
                orderTray.Remove(order.Key);
            }
            ms.sp_tray.Children.Clear();
            ms.focusedTab.LoadTray();
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
        public void ClearTray()
        {
            MainScreen ms = Switcher.pageSwitcher;

            orderTray.Clear();
            ms.sp_tray.Children.Clear();
        }


        public void LoadTray()
        {
            MainScreen ms = Switcher.pageSwitcher;
            double queueTotal = 0;
            foreach (KeyValuePair<MenuItem, int> order in orderTray)
            {
                //set name, quantity and price of drinks in order queue
                //order.Key.name is the name of the item
                //orderTray[order.Key] is price per item

                string name = order.Key.name;
                int item_quantity = orderTray[order.Key];
                double price = order.Key.price * orderTray[order.Key];
                queueTotal += order.Key.price * orderTray[order.Key];

                ms.sp_tray.Children.Add(new trayItem(order, name, item_quantity, price));

                //update order queue total
                
            }
            ms.lbl_queueTotal.Content = "Total: $" + queueTotal;
        }
=======
        public bool OrderTrayEmpty()
        {
            if (orderTray.Count == 0 || orderTray == null)
                return true;
            else
                return false;
        }

>>>>>>> 6aee7a553360598b79d4ee50f5c2864003bee611
    }
}
