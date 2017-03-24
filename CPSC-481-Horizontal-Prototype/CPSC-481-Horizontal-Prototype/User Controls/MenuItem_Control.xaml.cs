﻿using CPSC_481_Horizontal_Prototype.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for MenuItem_Control.xaml
    /// </summary>
    public partial class MenuItem_Control : UserControl
    {
        String name { get; set; }
        String price { get; set; }
        String description { get; set; }

        public MenuItem_Control()
        {
            InitializeComponent();
        }

        public MenuItem_Control(string name, string price, string description, string path)
        {
            InitializeComponent();
            this.lbl_itemName.Content = name;
            this.name = name;
            this.lbl_itemPrice.Content = price;
            this.price = price;
            this.description = description;
            this.background.ImageSource = new BitmapImage(new Uri(path, UriKind.Relative));
        }

        public void setDescription(string descr)
        {
            this.description = descr;
        }

        public string getDesription()
        {
            if ((this.description == null) || (this.description.Equals("")))
            {
                description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec maximus mi vel malesuada sollicitudin. Suspendisse in cursus ex. Cras placerat in diam sodales pellentesque. Nulla lacinia nunc commodo neque tristique varius. Fusce iaculis euismod mattis. In quis lacus elit. Phasellus vitae placerat mi.";
            }
            return description;
        }

        private void btn_viewItem_Click(object sender, RoutedEventArgs e)
        {
            ExamineItemScreen eis = new ExamineItemScreen();

            //change item name to fit on one line
            string name = this.name;
            eis.lbl_itemName.Content = Regex.Replace(name, @"\n", "");
            //update name, price, description and image of template

            eis.lbl_itemPrice.Content = this.price;
            eis.tb_description.Text = this.getDesription();
            eis.image.Source = background.ImageSource;

            //change overlay dimensions
            eis.Height = SystemParameters.PrimaryScreenHeight * .4;
            eis.Width = SystemParameters.PrimaryScreenWidth * .4;
            eis.ShowDialog();
        }


    }
}
