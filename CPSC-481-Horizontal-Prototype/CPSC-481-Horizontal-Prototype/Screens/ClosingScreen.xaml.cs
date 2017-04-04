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
    /// Interaction logic for ClosingScreen.xaml
    /// </summary>
    public partial class ClosingScreen : Window
    {
        public ClosingScreen(int time)
        {
            InitializeComponent();
            this.Show();
            System.Threading.Thread.Sleep(time);
            this.Close();
        }
    }
}
