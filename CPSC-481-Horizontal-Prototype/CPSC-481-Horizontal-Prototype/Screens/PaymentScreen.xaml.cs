﻿using System;
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
        public PaymentScreen()
        {
            InitializeComponent();

        }

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
    }
}
