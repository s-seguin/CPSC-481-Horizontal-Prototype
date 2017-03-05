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
            
            MainScreen ss = new MainScreen();
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
