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
        }

        private void navButton_Click(object sender, RoutedEventArgs e)
        {
            if (btn_drinks.IsFocused)
            {
                var point = lbl_drinks.TranslatePoint(new Point(0, 0), lbl_drinks);
                sv_specials.ScrollToVerticalOffset(point.Y);
            }
            if (btn_food.IsFocused)
            {
                var point = lbl_food.TranslatePoint(new Point(0,0), lbl_drinks);
                sv_specials.ScrollToVerticalOffset(point.Y);
            }
        }
    }
}
