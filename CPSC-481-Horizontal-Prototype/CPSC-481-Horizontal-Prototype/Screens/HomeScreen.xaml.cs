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
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    public partial class HomeScreen : Window
    {
        private MainScreen ms;
        public HomeScreen(MainScreen ms)
        {
            this.ms = ms;
            InitializeComponent();
        }

        private void btn_addTab_Click(object sender, RoutedEventArgs e)
        {
            AddTab a = new AddTab(ms, this);
            a.Show();
        }
    }
}
