using CPSC_481_Horizontal_Prototype.Screens;
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
        public MainScreen(string tabName)
        {
            InitializeComponent();

            //set tab identifier as first letter of person's name and set tab name in bottom right
            btn_personTab.Content = tabName[0];
            Switcher.pageSwitcher = this;
            Switcher.Switch(new Page_Specials());
            this.btn_specials.IsEnabled = false;

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
            this.Page_Holder.Content = nextPage;
        }


        private void btn_payNow_Click(object sender, RoutedEventArgs e)
        {
            PaymentScreen ps = new PaymentScreen();
            ps.Show();
        }

        private void btn_expandQueue_Click(object sender, RoutedEventArgs e)
        {
            //expand queue when side panel is collapsed
            if (!stack_sidePanel.IsVisible)
            {
                //change expand button margins
                this.btn_expandQueue.Margin = new Thickness(0, 0, 280, 250);
                this.btn_expandQueue.Content = "\uE015";       //chevron down
                stack_sidePanel.Visibility = Visibility.Visible;
            }
            //minimize side panel
            else
            {
                this.btn_expandQueue.Margin = new Thickness(0, 0, 280, 75);
                this.btn_expandQueue.Content = "\uE014";        //checvron up
                stack_sidePanel.Visibility = Visibility.Collapsed;
            }

        }
    }
}
