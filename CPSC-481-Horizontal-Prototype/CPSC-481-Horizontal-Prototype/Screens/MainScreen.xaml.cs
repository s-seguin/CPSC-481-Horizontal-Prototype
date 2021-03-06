﻿using CPSC_481_Horizontal_Prototype.Classes;
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

        public List<Button> tabButtonsList = new List<Button>();
        public UserTab focusedTab { get; set; }
        public bool isStartup { get; private set; } = true;
        public ActiveTabs allTabs { get; set; }
        private SolidColorBrush col_tabBlue = new SolidColorBrush(Color.FromArgb(0xFF, 0x28, 0x8d, 0xa7));
        private SolidColorBrush col_tabOrange = new SolidColorBrush(Color.FromArgb(0xFF, 0xf2, 0xab, 0x57)); //FFf2ab57
        public bool wantToLeave = false;
        private bool trayOpen;
        private Button btn;
        public int newTabThickness = 75;
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

            colorArray = new SolidColorBrush[5];
            colorArray[2] = new SolidColorBrush(Color.FromRgb(0x77, 0xdd, 0x77)); // green
            colorArray[1] = new SolidColorBrush(Color.FromRgb(0xa4, 0x4b, 0xfc)); // purple
            colorArray[0] = new SolidColorBrush(Color.FromRgb(0xff, 0xa5, 0x00)); // orange
            colorArray[3] = new SolidColorBrush(Color.FromRgb(0x71, 0xae, 0xf2)); // light blue
            colorArray[4] = new SolidColorBrush(Color.FromRgb(0xea, 0x56, 0x45)); // red
         

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
            lbl_tabTotal.Content = "Total: $" + focusedTab.amountOwing.ToString("F");
           


            // set current page to speacials and focus speacials button
            Switcher.pageSwitcher = this;
            Switcher.Switch(new Page_Specials());
            switch_btn_bg(btn_specials, "specials");

        }
        #endregion

        #region Methods

        #region Button Clicks
        public void btn_nav_Click(object sender, RoutedEventArgs e)
        {

            if (btn_specials.IsFocused) {
                Switcher.Switch(new Page_Specials());
                switch_btn_bg(btn_specials, "specials");
                //btn_specials.Background = new ImageBrush(new BitmapImage(new Uri("../../Resources/Images/btn_specials_down_bg.png", UriKind.Relative)));
            } else if (btn_drinks.IsFocused) {
                Switcher.Switch(new Page_Drinks());
                switch_btn_bg(btn_drinks,"drinks");
            } else if (btn_food.IsFocused) {
                Switcher.Switch(new Page_Food());
                switch_btn_bg(btn_food, "food");
            } else if (btn_help.IsFocused) {
                GrayedOutWindow gw = new GrayedOutWindow();
                HelpScreen hs = new HelpScreen();
                gw.Show();
                hs.ShowDialog();
                gw.Close();
            }
        }

        private void switch_btn_bg(Button focusedbtn, string btnName)
        {
            string url = "../../Resources/Images/btn_" + btnName + "_down_bg.png";
            focusedbtn.Background = new ImageBrush(new BitmapImage(new Uri(url, UriKind.Relative)));

            if(focusedbtn != btn_specials)
            {
                btn_specials.Background = new ImageBrush(new BitmapImage(new Uri("../../Resources/Images/btn_specials_bg.png", UriKind.Relative)));
            }
            if (focusedbtn != btn_drinks)
            {
                btn_drinks.Background = new ImageBrush(new BitmapImage(new Uri("../../Resources/Images/btn_drinks_bg.png", UriKind.Relative)));
            }
            if (focusedbtn != btn_food)
            {
                btn_food.Background = new ImageBrush(new BitmapImage(new Uri("../../Resources/Images/btn_food_bg.png", UriKind.Relative)));
            }
        }

        private void btn_addTab_Click(object sender, RoutedEventArgs e)
        {
            lbl_submitQueue.IsEnabled = false;
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
                btn_payNow.IsEnabled = false;

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
            Button clickedBtn = (Button)sender;
            btn = clickedBtn;
            lbl_submitQueue.IsEnabled = false;
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
                        Storyboard sb = Resources["sbShowTab"] as Storyboard;
                        sb.Begin(btn);

                        focusedTab.ClearTray();
                        lbl_queueTotal.Content = "Total: $0.00";
                        lbl_tabTotal.Content = "Total: $" + ut.amountOwing.ToString("F");
                        lbl_tabName.Content = ut.ToString();
                        grid_summary.Background = ut.GetTabButton().Background;
                        this.focusedTab = ut;

                    }
                }
            }

            if (focusedTab.amountOwing > 0)
                btn_payNow.IsEnabled = true;
            else
                btn_payNow.IsEnabled = false;

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
            lbl_submitQueue.IsEnabled = false;
            MainScreen ms = Switcher.pageSwitcher;

            ms.focusedTab.PlaceOrder();
            ms.focusedTab.ClearTray();

            lbl_queueTotal.Content = "Total: $0.00";
            GrayedOutWindow gw = new GrayedOutWindow();
            gw.Show();
            OrderPlacedScreen ops = new OrderPlacedScreen(1000);
            gw.Close();
            showQueue(false);
            btn_payNow.IsEnabled = true;
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            bool allEmpty = true;
            foreach (UserTab ut in allTabs.GetTabs())
            {
                if (ut.amountOwing != 0) allEmpty = false;
            }
            if (allEmpty)
            {
                GrayedOutWindow gw = new GrayedOutWindow();
                ExitScreen es = new ExitScreen(this);

                es.textBlock.Text = "You are about to return to the main menu. This will close all your open tabs.\nAre you sure you want to continue?";
                es.btn_yes.Content = "Yes";
                es.btn_yes.Width = 160;
                es.btn_no.Content = "No";
                es.btn_no.Width = 160;
                es.btn_no.Margin = new Thickness(210, 0, 0, 52);

                gw.Show();
                es.ShowDialog();
                gw.Close();
            }
            else
            {
                GrayedOutWindow gw = new GrayedOutWindow();
                ExitScreen es = new ExitScreen(this);
                gw.Show();
                es.ShowDialog();
                gw.Close();
            }
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
            grid_addTabs.Children.Add(btn);
            tabButtonsList.Add(btn);
           // tabPanel.Children.Add(btn);
            lbl_tabName.Content = tab.ToString();
            grid_summary.Background = tab.GetTabButton().Background;

            Storyboard sb = Resources["sbShowTab"] as Storyboard;
            sb.Begin(btn);

            lbl_tabTotal.Content = "Total: $" + tab.amountOwing.ToString("F");

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

            int index = allTabs.GetTabs().Count % colorArray.Length;
            btn.Background = colorArray[index];

            /*if (allTabs.GetTabs().Count % 2 == 0)
                btn.Background = colorArray[0];
            else
                btn.Background = colorArray[1];*/

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
            string tabContent = btn.Content.ToString();
            if (tabContent.Length > 1) btn.Content = tabContent[0];
            else { btn.Content = tabContent; }
            //btn.Margin = new Thickness(0, 0, 0, 0);
        }

        #endregion

        #endregion
    }
}
