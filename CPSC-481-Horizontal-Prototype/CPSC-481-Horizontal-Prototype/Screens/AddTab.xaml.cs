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
        private List<String> defaultTabs = new List<String> { "1", "2", "3", "4", "5", "6", "7", "8", "9"};

        public AddTab()
        {
            InitializeComponent();
            
            // this.Height = SystemParameters.PrimaryScreenHeight / 2;
            // this.Width = SystemParameters.PrimaryScreenWidth / 2;
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
            if (theText.Equals(""))
            {
                theText = defaultTabs[0];
                defaultTabs.RemoveAt(0);
            }
            MainScreen ss = new MainScreen(theText);
            ss.Show();
            this.Close();
            homeScreen.Close();
        }

        public void SetHomeScreen(HomeScreen hs)
        {
            this.homeScreen = hs;
        }
            
    }
}
