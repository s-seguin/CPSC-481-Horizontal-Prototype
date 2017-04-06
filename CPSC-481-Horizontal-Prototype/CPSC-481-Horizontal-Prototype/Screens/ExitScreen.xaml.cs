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
    /// Interaction logic for ExitScreen.xaml
    /// </summary>
    public partial class ExitScreen : Window
    {
        MainScreen oldMain;

        public ExitScreen(MainScreen ms)
        {
            InitializeComponent();
            oldMain = ms;
        }

        public void btn_yes_Click(object sender, RoutedEventArgs e)
        {
            string yesContent = btn_yes.Content.ToString();
            if (yesContent.Equals("Yes, I want to pay"))
            {
                this.Close();
                GrayedOutWindow gw = new GrayedOutWindow();
                PaymentScreen ps = new PaymentScreen();
                gw.Show();
                ps.ShowDialog();
                gw.Close();
            }
            else
            {
                oldMain.Close();
                MainScreen ms = new MainScreen();
                this.Close();
            }
        }

        private void btn_no_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
