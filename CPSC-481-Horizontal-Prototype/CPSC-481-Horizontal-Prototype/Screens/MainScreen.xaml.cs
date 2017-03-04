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
using System.Windows.Shapes;

namespace CPSC_481_Horizontal_Prototype
{
    /// <summary>
    /// Interaction logic for SpecialsScreen.xaml
    /// </summary>
    public partial class MainScreen : Window
    {
        public MainScreen()
        {
            InitializeComponent();
            Switcher.pageSwitcher = this;
            Switcher.Switch(new Page_Specials());
           /* drinkItem.lbl_itemName.Content =  "Drink Up";
            drinkItem.lbl_itemPrice.Content = "$400.99";
            drinkItem.btn_viewItem.Background = new ImageBrush();*/
        }

        private void btn_specials_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Page_Specials());
            this.btn_specials.IsEnabled = false;
            this.btn_food.IsEnabled = true;
            this.btn_drinks.IsEnabled = true;

        }
        private void btn_drinks_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Page_Drinks());
            this.btn_drinks.IsEnabled = false;
            this.btn_food.IsEnabled = true;
            this.btn_specials.IsEnabled = true;

        }
        private void btn_food_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Page_Food());
            this.btn_food.IsEnabled = false;
            this.btn_drinks.IsEnabled = true;
            this.btn_specials.IsEnabled = true;



        }
        private void btn_help_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_addTab_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_changeTab_Click(object sender, RoutedEventArgs e)
        {
            //change the tab 
        }

        internal void Navigate(UserControl nextPage)
        {
<<<<<<< HEAD:CPSC-481-Horizontal-Prototype/CPSC-481-Horizontal-Prototype/MainScreen.xaml.cs
            // this.pageHolder.Content = nextPage;
=======
            this.Page_Holder.Content = nextPage;
>>>>>>> origin/master:CPSC-481-Horizontal-Prototype/CPSC-481-Horizontal-Prototype/Screens/MainScreen.xaml.cs
        }
    }
}
