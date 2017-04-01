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
    /// Interaction logic for paymentItem.xaml
    /// </summary>
    public partial class paymentItem : UserControl
    {
        KeyValuePair<Classes.MenuItem, int> order { get; set; }
        string name { get; set; }
        int quantity { get; set; }
        double price { get; set; }

        public paymentItem()
        {
            InitializeComponent();
        }

        public paymentItem(KeyValuePair<Classes.MenuItem, int> order, string name, int quantity, double price)
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

    }
}
