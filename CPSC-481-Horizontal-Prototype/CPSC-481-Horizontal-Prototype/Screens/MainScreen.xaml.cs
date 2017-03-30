﻿using CPSC_481_Horizontal_Prototype.Classes;
using CPSC_481_Horizontal_Prototype.Screens;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CPSC_481_Horizontal_Prototype
{
    /// <summary>
    /// Interaction logic for SpecialsScreen.xaml
    /// </summary>
    public partial class MainScreen : Window
    {

        #region Attributes

        public UserTab focusedTab { get; private set;}
        public bool isStartup { get; private set; } = true;
        public ActiveTabs allTabs { get; set; }
        private SolidColorBrush col_tabBlue = new SolidColorBrush(Color.FromArgb(0xFF, 0x28, 0x8d, 0xa7));
        private SolidColorBrush col_tabOrange = new SolidColorBrush(Color.FromArgb(0xFF, 0xf2, 0xab, 0x57)); //FFf2ab57
        public bool wantToLeave = false;
        
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

            Switcher.pageSwitcher = this;
            Switcher.Switch(new Page_Specials());
            btn_specials.Height = 99;

        }
        #endregion

        #region Methods

        #region Button Clicks
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
                HelpScreen hs = new HelpScreen();
                hs.Height = SystemParameters.PrimaryScreenHeight * .4;
                hs.Width = SystemParameters.PrimaryScreenWidth * .4;
                hs.ShowDialog();
            }
        }

        private void btn_addTab_Click(object sender, RoutedEventArgs e)
        {
            if (allTabs.GetTabs().Count < 8)
            {
                if (!focusedTab.OrderTrayEmpty())
                {
                    LeavingTabScreen warningScreen = new LeavingTabScreen(this);
                    warningScreen.ShowDialog();


                }
                if (wantToLeave || focusedTab.OrderTrayEmpty())
                {
                    focusedTab.ClearTray();
                    focusedTab.LoadTray();
                    AddTab at = new AddTab(this, null);
                    at.ShowDialog();
                }
            }
            else
            {
                Max8TabsWarning mxWarning = new Max8TabsWarning();
                mxWarning.ShowDialog();
            }

        }

        private void btn_changeTab_Click(object sender, RoutedEventArgs e)
        {
            if (!focusedTab.OrderTrayEmpty())
            {
                LeavingTabScreen warningScreen = new LeavingTabScreen(this);
                warningScreen.ShowDialog();
            }
            if (wantToLeave || focusedTab.OrderTrayEmpty())
            {
                foreach (UserTab ut in allTabs.GetTabs())
                {
                    if (ut.GetTabButton().IsFocused)
                    {
                        focusedTab.ClearTray();
                        lbl_tabTotal.Content = "Total: $" + ut.amountOwing;
                        lbl_tabName.Content = ut.ToString();
                        grid_summary.Background = ut.GetTabButton().Background;
                        this.focusedTab = ut;

                    }
                }
            }
          
  
        }

        private void btn_expandQueue_Click(object sender, RoutedEventArgs e)
        {
            //expand queue when side panel is collapsed
            if (!grid_queue.IsVisible) { showQueue(true);  }

            //minimize side panel
            else { showQueue(false); }

        }

        public void showQueue(Boolean value)
        {
            if (value)
            {
                //change expand button margins
                this.btn_expandQueue.Margin = new Thickness(0, 0, 307, 508);
                this.btn_expandQueue.Content = "\uE015";       //chevron down
                grid_queue.Visibility = Visibility.Visible;
            }
            else
            {
                this.btn_expandQueue.Margin = new Thickness(0, 0, 307, 108);
                this.btn_expandQueue.Content = "\uE014";        //checvron up
                grid_queue.Visibility = Visibility.Hidden;
            }
        }

        private void btn_payNow_click(object sender, RoutedEventArgs e)
        {
            PaymentScreen ps = new PaymentScreen();
            ps.ShowDialog();

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
            Button btn = CreateTabButton(tab.ToString());
            tab.SetTabButton(btn);
            tabPanel.Children.Add(btn);
            lbl_tabName.Content = tab.ToString();
            grid_summary.Background = tab.GetTabButton().Background;
            lbl_tabTotal.Content = "Total: $" + tab.amountOwing;

            this.focusedTab = tab;
        }

        private Button CreateTabButton(string userName)
        {
            Button btn = new Button();
            btn.Click += btn_changeTab_Click;
            btn.Width = 75;
            btn.Height = 75;
            btn.BorderBrush = null;
            btn.BorderThickness = new Thickness(0, 0, 0, 0);
            if (allTabs.GetTabs().Count % 2 == 0)
                btn.Background = col_tabBlue;
            else
                btn.Background = col_tabOrange;

            btn.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF));
            btn.Content = userName[0];
            btn.FontSize = 48;
            btn.FontFamily = new FontFamily("Segoe UI Semibold");
            return btn;
        }

        internal void Navigate(UserControl nextPage)
        {
           this.Page_Holder.Content = nextPage;
        }

        


        #endregion

        #endregion

        private void btn_submitQueue_Click(object sender, RoutedEventArgs e)
        {
            MainScreen ms = Switcher.pageSwitcher;

            ms.focusedTab.PlaceOrder();
            ms.focusedTab.ClearTray();

            lbl_queueTotal.Content = "Total: $0.00";
            showQueue(false);
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
    }
}
