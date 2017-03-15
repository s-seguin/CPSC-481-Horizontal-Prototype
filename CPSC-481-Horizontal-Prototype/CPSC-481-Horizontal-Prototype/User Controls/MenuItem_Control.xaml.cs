using CPSC_481_Horizontal_Prototype.Screens;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CPSC_481_Horizontal_Prototype
{
    /// <summary>
    /// Interaction logic for MenuItem_Control.xaml
    /// </summary>
    public partial class MenuItem_Control : UserControl
    {
        public MenuItem_Control()
        {
            InitializeComponent();
        }

        private void btn_viewItem_Click(object sender, RoutedEventArgs e)
        {
            ExamineItemScreen eis = new ExamineItemScreen();
            eis.Show();
        }
    }
}
