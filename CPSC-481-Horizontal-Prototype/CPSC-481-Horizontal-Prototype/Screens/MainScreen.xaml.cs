using CPSC_481_Horizontal_Prototype.Classes;
using CPSC_481_Horizontal_Prototype.Screens;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace CPSC_481_Horizontal_Prototype
{
    /// <summary>
    /// Interaction logic for SpecialsScreen.xaml
    /// </summary>
    public partial class MainScreen : Window
    {

        #region Attributes

        public UserTab focusedTab { get; set;}
        public bool isStartup { get; private set; } = true;
        public ActiveTabs allTabs { get; set; }
        private SolidColorBrush col_tabBlue = new SolidColorBrush(Color.FromArgb(0xFF, 0x28, 0x8d, 0xa7));
        private SolidColorBrush col_tabOrange = new SolidColorBrush(Color.FromArgb(0xFF, 0xf2, 0xab, 0x57)); //FFf2ab57
        public bool wantToLeave = false;
        private bool trayOpen;
        private Button btn;
        private int newTabThickness = 75;
        private String currentPage;
        private SolidColorBrush[] colorArray;

        #endregion

        #region Constructors
        /// <summary>
        /// This contructor opens the first window you will see and hides the main window
        /// </summary>
        public MainScreen()
        {
            HomeScreen hs = new HomeScreen(this);
            hs.Show();
            InitializeComponent();

            colorArray = new SolidColorBrush[8];
            colorArray[0] = new SolidColorBrush(Color.FromRgb(0x28, 0x8d, 0xa7));
            colorArray[1] = new SolidColorBrush(Color.FromRgb(0xf2, 0xab, 0x57));

            this.Hide();
        }

        /// <summary>
        /// Once the first tab has been created we draw this window
        /// </summary>
        public void OpenWindow()
        {
            this.Show();
            isStartup = false;

            //add the first tab
            AddTabButton(allTabs.GetTabs()[0]);
            focusedTab = allTabs.GetTabs()[0];

            //make the thing look nice in corner
            grid_summary.Background = focusedTab.GetTabButton().Background;
            lbl_tabName.Content = focusedTab.ToString();
            lbl_tabTotal.Content = "Total: $" + focusedTab.amountOwing;

            // set current page to speacials and focus speacials button
            Switcher.pageSwitcher = this;
            Switcher.Switch(new Page_Specials());
            btn_specials.Focus();
            currentPage = "specials";

        }
        #endregion

        #region Methods

        #region Button Clicks
        public void btn_nav_Click(object sender, RoutedEventArgs e)
        {

            if (btn_specials.IsFocused) {
                Switcher.Switch(new Page_Specials());
                currentPage = "specials";
                btn_specials.Background = new ImageBrush(new BitmapImage(new Uri("../../Resources/Images/btn_specials_down_bg.png", UriKind.Relative)));
            }  else if (btn_drinks.IsFocused) {
                Switcher.Switch(new Page_Drinks());
                currentPage = "drinks";
            } else if (btn_food.IsFocused) {
                Switcher.Switch(new Page_Food());
                currentPage = "food";
            } else if (btn_help.IsFocused) {
                GrayedOutWindow gw = new GrayedOutWindow();
                HelpScreen hs = new HelpScreen();

                // make sure that the last active page still has its button focused
                switch (currentPage)
                {
                    case "specials":
                        btn_specials.Focus();
                        break;
                    case "drinks":
                        btn_drinks.Focus();
                        break;
                    case "food":
                        btn_food.Focus();
                        break;
                    default:
                        // should be an error message here...
                        break;
                }

                gw.Show();
                hs.ShowDialog();
                gw.Close();
            }
        }

        private void btn_addTab_Click(object sender, RoutedEventArgs e)
        {
            if (allTabs.GetTabs().Count < 8)
            {
                if (!focusedTab.OrderTrayEmpty())
                {
                    GrayedOutWindow gw = new GrayedOutWindow();
                    LeavingTabScreen warningScreen = new LeavingTabScreen(this);
                    gw.Show();
                    warningScreen.ShowDialog();
                    gw.Close();


                }
                if (wantToLeave || focusedTab.OrderTrayEmpty())
                {
                    GrayedOutWindow gw = new GrayedOutWindow();

                    focusedTab.ClearTray();
                    focusedTab.LoadTray();
                    AddTab at = new AddTab(this, null);
                    gw.Show();
                    at.ShowDialog();
                    gw.Close();

                }
            }
            else
            {
                GrayedOutWindow gw = new GrayedOutWindow();

                Max8TabsWarning mxWarning = new Max8TabsWarning();
                gw.Show();

                mxWarning.ShowDialog();
                gw.Close();

            }

        }

        private void btn_changeTab_Click(object sender, RoutedEventArgs e)
        {
            if (!focusedTab.OrderTrayEmpty())
            {
                GrayedOutWindow gw = new GrayedOutWindow();

                LeavingTabScreen warningScreen = new LeavingTabScreen(this);
                gw.Show();
                warningScreen.ShowDialog();
                gw.Close();

            }
            if (wantToLeave || focusedTab.OrderTrayEmpty())
            {
                foreach (UserTab ut in allTabs.GetTabs())
                {
                    if (ut.GetTabButton().IsFocused)
                    {
                        focusedTab.ClearTray();
                        lbl_queueTotal.Content = "Total: $0.00";
                        lbl_tabTotal.Content = "Total: $" + ut.amountOwing;
                        lbl_tabName.Content = ut.ToString();
                        grid_summary.Background = ut.GetTabButton().Background;
                        this.focusedTab = ut;

                    }
                }
            }
          
  
        }

        public void btn_expandQueue_Click(object sender, RoutedEventArgs e)
        {
            //expand queue when side panel is collapsed
            if (sp_trayAndBtn.Margin == new Thickness(0,0,0,-292)) { showQueue(true);  }

            //minimize side panel
            else { showQueue(false); }

        }

        public void showQueue(Boolean value)
        {
            //value is true if we desire to expand the tray
            if ((value) && (!trayOpen))
            {
                //change expand button margins
                this.btn_expandQueue.Content = "\uE015";       //chevron down
                this.trayOpen = true;
                Storyboard sb = Resources["sbShowTray"] as Storyboard;
                sb.Begin(sp_trayAndBtn);
            }
            else if ((!value) && (trayOpen))
            {
                this.btn_expandQueue.Content = "\uE014";        //checvron up
                this.trayOpen = false;
                Storyboard sb = Resources["sbHideTray"] as Storyboard;
                sb.Begin(sp_trayAndBtn);
            }
        }

        private void btn_payNow_click(object sender, RoutedEventArgs e)
        {
            GrayedOutWindow gw = new GrayedOutWindow();
            PaymentScreen ps = new PaymentScreen();
            gw.Show();
            ps.ShowDialog();
            gw.Close();

        }

        private void btn_submitQueue_Click(object sender, RoutedEventArgs e)
        {
            MainScreen ms = Switcher.pageSwitcher;

            ms.focusedTab.PlaceOrder();
            ms.focusedTab.ClearTray();

            lbl_queueTotal.Content = "Total: $0.00";

            ClosingScreen cs = new ClosingScreen(2000, "Your order has been successfully placed!");
            showQueue(false);
        }

        #endregion

        #region Helper Functions
        /// <summary>
        /// Creates a tab btn in the tab panel for the given user tab
        /// the button is store as an attribute in the usertab class
        /// </summary>
        /// <param name="tab">The user tab to create a button for</param>
        public void AddTabButton(UserTab tab)
        {
            btn = CreateTabButton(tab.ToString());
            tab.SetTabButton(btn);
            grid_tryingshit.Children.Add(btn);
            lbl_tabName.Content = tab.ToString();
            grid_summary.Background = tab.GetTabButton().Background;

            Storyboard sb = Resources["sbShowTab"] as Storyboard;
            sb.Begin(btn);

            lbl_tabTotal.Content = "Total: $" + tab.amountOwing;

            this.focusedTab = tab;
        }

        private Button CreateTabButton(string userName)
        {
            Button btn = new Button();
            btn.Click += btn_changeTab_Click;
            btn.Width = 75;
            btn.Height = 75;
            btn.HorizontalAlignment = HorizontalAlignment.Left;
            btn.VerticalAlignment = VerticalAlignment.Top;
            btn.BorderBrush = null;
            btn.BorderThickness = new Thickness(0, 0, 0, 0);
            newTabThickness += 75;
            btn.Margin = new Thickness(0, newTabThickness, 0, 0);
            if (allTabs.GetTabs().Count % 2 == 0)
                btn.Background = colorArray[0];
            else
                btn.Background = colorArray[1];

            btn.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF));
            btn.Content = userName;
            btn.FontSize = 48;
            btn.FontFamily = new FontFamily("Segoe UI Semibold");
            return btn;
        }

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

        internal void Navigate(UserControl nextPage)
        {
           this.Page_Holder.Content = nextPage;
        }




        #endregion

        #endregion

        private void ScrollViewer_ManipulationBoundaryFeedback(object sender, System.Windows.Input.ManipulationBoundaryFeedbackEventArgs e)
        {
            e.Handled = true;
        }

        private void Tab_Expanded(object sender, EventArgs e)
        {
            Storyboard sb = Resources["sbHideTab"] as Storyboard;
            sb.Begin(btn);
        }

        private void Tab_Hidden(object sender, EventArgs e)
        {
            string tabContent = (string)btn.Content;
            if (tabContent.Length > 1) btn.Content = tabContent[0];
            else { btn.Content = tabContent; }

            grid_tryingshit.Children.Remove(btn);
            btn.Margin = new Thickness(0, 0, 0, 0);
            tabPanel.Children.Add(btn);
        }
    }
}
