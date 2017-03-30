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

namespace CPSC_481_Horizontal_Prototype.User_Controls
{
    /// <summary>
    /// Interaction logic for trayItem.xaml
    /// </summary>
    public partial class trayItem : UserControl
    {
        KeyValuePair<Classes.MenuItem, int> order { get; set; }
        string name { get; set; }
        int quantity { get; set; }
        double price { get; set; }

        public trayItem()
        {
            InitializeComponent();
        }

        public trayItem(KeyValuePair<Classes.MenuItem, int> order, string name, int quantity, double price)
        {
            this.order = order;
            this.name = name;
            this.quantity = quantity;
            this.price = price;


            //set user control label values
            InitializeComponent();
            item_name.Content = name;
            item_quantity.Content += quantity.ToString();
            item_price.Content += price.ToString(); ;

            
        }


        //show button to remove from tray or hide it
        private void grid_tray_item_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (btn_remove.Visibility == Visibility.Hidden)
            {
                btn_remove.Visibility = Visibility.Visible;
            }
            else
            {
                btn_remove.Visibility = Visibility.Hidden;
            }
        }

        //show button to remove from tray or hide it
        private void grid_tray_item_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (btn_remove.Visibility == Visibility.Hidden)
            {
                btn_remove.Visibility = Visibility.Visible;
            }
            else
            {
                btn_remove.Visibility = Visibility.Hidden;
            }
        }

        private void btn_remove_Click(object sender, RoutedEventArgs e)
        {
            MainScreen ms = Switcher.pageSwitcher;

            ms.focusedTab.RemoveFromTray(this.order, this.quantity);
            
        }
    }
}
