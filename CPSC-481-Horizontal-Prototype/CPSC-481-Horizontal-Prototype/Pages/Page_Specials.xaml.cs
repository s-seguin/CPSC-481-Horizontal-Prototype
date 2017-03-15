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

namespace CPSC_481_Horizontal_Prototype
{
    /// <summary>
    /// Interaction logic for Page_Specials.xaml
    /// </summary>
    public partial class Page_Specials : UserControl
    {
        public Page_Specials()
        {
            InitializeComponent();

            ds1.lbl_itemName.Content = "Gas Lamp \nNut Brown";
            ds1.lbl_itemPrice.Content = "$6.50";

            ds2.lbl_itemName.Content = "Gas Lamp \nPlatinum Blonde";
            ds2.lbl_itemPrice.Content = "$6.50";

            ds3.lbl_itemName.Content = "Gas Lamp\nPrairie Ale";
            ds3.lbl_itemPrice.Content = "$6.50";
        }

        private void navButton_Click(object sender, RoutedEventArgs e)
        {
            if (btn_drinks.IsFocused)
            {
                sv_specials.ScrollToTop();
            }
            else if (btn_food.IsFocused)
            {
                var point = header_food.TranslatePoint(new Point(0,0), header_drinks);
                sv_specials.ScrollToVerticalOffset(point.Y);
            }
        }
    }
}
