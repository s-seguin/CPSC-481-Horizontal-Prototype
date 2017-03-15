using CPSC_481_Horizontal_Prototype.Classes;
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
        public bool isStartup { get; private set; } = true;
        public ActiveTabs allTabs { get; set; }
        public MainScreen()
        {
            HomeScreen hs = new HomeScreen(this);
            hs.Show();
            InitializeComponent();

            this.Hide();
        }

        public void OpenWindow()
        {
            this.Show();
            isStartup = false;

            //set tab identifier as first letter of person's name and set tab name in bottom 

            //btn_personTab.Content = tabName[0];

            grid_summary.Background = btn_personTab.Background;

            // lbl_tabName.Content = tabName;
            /*if (Convert.ToInt16(tabName) > 0 || Convert.ToInt16(tabName) <= 9)
            {
                lbl_tabName.Content = "Tab " + tabName;
            } */
            Switcher.pageSwitcher = this;
            Switcher.Switch(new Page_Specials());
            btn_specials.Height = 99;

            /* drinkItem.lbl_itemName.Content =  "Drink Up";
             drinkItem.lbl_itemPrice.Content = "$400.99";
             drinkItem.btn_viewItem.Background = new ImageBrush();*/
        }

        public void btn_nav_Click(object sender, RoutedEventArgs e)
        {
            if (btn_specials.IsFocused)
            {
                Switcher.Switch(new Page_Specials());
                btn_specials.Height = 99;
                btn_drinks.Height = 104;
                btn_food.Height = 104;
            }
            
            else if (btn_drinks.IsFocused)
            {
                Switcher.Switch(new Page_Drinks());
                btn_specials.Height = 104;
                btn_drinks.Height = 99;
                btn_food.Height = 104;
            }

            else if (btn_food.IsFocused)
            {
                Switcher.Switch(new Page_Food());
                btn_specials.Height = 104;
                btn_drinks.Height = 104;
                btn_food.Height = 99;
            }

            else if (btn_help.IsFocused)
            {
                ExamineItemScreen eis = new ExamineItemScreen();
                eis.Height = SystemParameters.PrimaryScreenHeight * .4;
                eis.Width = SystemParameters.PrimaryScreenWidth * .4;
                eis.Show();
            }
        }

        private void btn_addTab_Click(object sender, RoutedEventArgs e)
        {
            AddTab at = new AddTab(this, null);
            at.ShowDialog();
            foreach (UserTab ut in allTabs.GetTabs())
            {
                Console.WriteLine(ut.ToString());
            }
        }

        private void btn_changeTab_Click(object sender, RoutedEventArgs e)
        {
            //change the tab 
            if (btn_personTab.IsFocused)
            {
                grid_summary.Background = btn_personTab.Background;
            }
            else if (btn_personTab_2.IsFocused)
            {
                grid_summary.Background = btn_personTab_2.Background;
            }
        }

        internal void Navigate(UserControl nextPage)
        {
           this.Page_Holder.Content = nextPage;
        }

        private void btn_payNow_click(object sender, RoutedEventArgs e)
        {
            PaymentScreen ps = new PaymentScreen();
            ps.ShowDialog();
        }

        private void btn_expandQueue_Click(object sender, RoutedEventArgs e)
        {
            //expand queue when side panel is collapsed
            if (!stack_sidePanel.IsVisible)
            {
                //change expand button margins
                this.btn_expandQueue.Margin = new Thickness(0, 0, 268, 416);
                this.btn_expandQueue.Content = "\uE015";       //chevron down
                stack_sidePanel.Visibility = Visibility.Visible;
            }
            //minimize side panel
            else
            {
                this.btn_expandQueue.Margin = new Thickness(0, 0, 268, 108);
                this.btn_expandQueue.Content = "\uE014";        //checvron up
                stack_sidePanel.Visibility = Visibility.Collapsed;
            }

        }
    }
}
