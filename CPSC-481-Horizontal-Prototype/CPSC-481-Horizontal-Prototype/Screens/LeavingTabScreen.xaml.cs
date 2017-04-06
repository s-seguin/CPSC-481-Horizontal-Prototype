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
    /// Interaction logic for LeavingTabScreen.xaml
    /// </summary>
    public partial class LeavingTabScreen : Window
    {
        private MainScreen ms;
        public LeavingTabScreen(MainScreen ms)
        {
            InitializeComponent();
            this.ms = ms;
        }

        private void btn_no_Click(object sender, RoutedEventArgs e)
        {
            ms.wantToLeave = false;
            ms.lbl_submitQueue.IsEnabled = true;
            this.Close();

        }

        private void btn_yes_Click(object sender, RoutedEventArgs e)
        {
            ms.wantToLeave = true;
            this.Close();
        }
    }
}
