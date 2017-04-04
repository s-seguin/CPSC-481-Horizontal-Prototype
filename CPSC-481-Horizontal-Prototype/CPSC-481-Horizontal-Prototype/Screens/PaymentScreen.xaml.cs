using CPSC_481_Horizontal_Prototype.Classes;
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

namespace CPSC_481_Horizontal_Prototype.Screens
{
    /// <summary>
    /// Interaction logic for PaymentScreen.xaml
    /// </summary>
    public partial class PaymentScreen : Window
    {
        private MainScreen ms;

        public PaymentScreen()
        {
            InitializeComponent();

            ms = Switcher.pageSwitcher;
            lbl_title.Content = ms.focusedTab.ToString() + "'s Tab";
            ms.focusedTab.LoadOrder(this);

        }

        #region Button Clicks
        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void rbtn_card_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rbtn_cash_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btn_payNow_Click(object sender, RoutedEventArgs e)
        {
            ms.allTabs.RemoveTab(ms.focusedTab);
            ms.tabPanel.Children.Remove(ms.focusedTab.GetTabButton());
            if (ms.allTabs.GetTabs().Count > 0)
            {
                UserTab ut = ms.allTabs.GetTabs()[0];
                ms.lbl_tabTotal.Content = "Total: $" + ut.amountOwing;
                ms.lbl_tabName.Content = ut.ToString();
                ms.grid_summary.Background = ut.GetTabButton().Background;
                ms.focusedTab = ut;
            }
            else
            {
                //that was the last tab
                ClosingScreen cs = new ClosingScreen(5000);
                MainScreen mainScreen = new MainScreen();
                ms.Close();
            }
            this.Close();
        }

        private void btn_cash_Click(object sender, RoutedEventArgs e)
        {
            rbtn_cash.IsChecked = true;
            rbtn_card.IsChecked = false;
            btn_payNow.IsEnabled = true;
        }

        private void btn_card_Click(object sender, RoutedEventArgs e)
        {
            rbtn_card.IsChecked = true;
            rbtn_cash.IsChecked = false;
            btn_payNow.IsEnabled = true;
        }
        #endregion

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            bool AutoScroll = true;
            ScrollViewer sv = (ScrollViewer)sender;

            if (e.ExtentHeightChange == 0)
            {   // Content unchanged : user scroll event
                if (sv.VerticalOffset == sv.ScrollableHeight)
                {   // Scroll bar is in bottom
                    // Set autoscroll mode
                    AutoScroll = true;
                }
                else
                {   // Scroll bar isn't in bottom
                    // Unset autoscroll mode
                    AutoScroll = false;
                }
            }

            // Content scroll event : autoscroll eventually
            if (AutoScroll && e.ExtentHeightChange != 0)
            {   // Content changed and autoscroll mode set
                // Autoscroll
                sv.ScrollToVerticalOffset(sv.ExtentHeight);
            }
        }
    }
}
