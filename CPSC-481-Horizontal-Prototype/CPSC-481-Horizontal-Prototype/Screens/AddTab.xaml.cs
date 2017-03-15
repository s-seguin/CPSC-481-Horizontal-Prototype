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

namespace CPSC_481_Horizontal_Prototype
{
    /// <summary>
    /// Interaction logic for AddTab.xaml
    /// </summary>
    public partial class AddTab : Window
    {
        HomeScreen homeScreen;
        MainScreen ms;
        private List<String> defaultTabs = new List<String> { "1", "2", "3", "4", "5", "6", "7", "8", "9"};

        public AddTab(MainScreen ms, HomeScreen hs)
        {
            InitializeComponent();
            
            this.Height = SystemParameters.PrimaryScreenHeight / 2;
            this.Width = SystemParameters.PrimaryScreenWidth / 2;
            this.ms = ms;
            this.homeScreen = hs;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //do nothing yet                    
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {

            //pass textbox input into MainScreen
            string theText = txtbox_name.Text;
            UserTab tab = new UserTab(theText); //create a new user tab

            if (theText.Equals(""))
            {
                theText = defaultTabs[0];
                defaultTabs.RemoveAt(0);
            }
            if (ms.isStartup)
            {
                ActiveTabs allTabs = new ActiveTabs(tab);
                ms.allTabs = allTabs;
                ms.OpenWindow();
                this.Close();
                if (homeScreen != null)
                    homeScreen.Close();

            }
            else
            {
                ms.allTabs.AddTab(tab);
                this.Close();
            }
            
        }
            
    }
}
