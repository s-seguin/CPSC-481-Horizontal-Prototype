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
    /// Interaction logic for ExamineItemScreen.xaml
    /// </summary>
    public partial class ExamineItemScreen : Window
    {
        public ExamineItemScreen()
        {
            InitializeComponent();
            btn_decrease.IsEnabled = false;
        }

        private void btn_decrease_Click(object sender, RoutedEventArgs e)
        {
            int numItems = int.Parse(this.tb_numItems.Text);
            if (numItems <= 2)
            {
                this.btn_decrease.IsEnabled = false;
            }
            else
            {
                this.btn_decrease.IsEnabled = true;
            }
            numItems--;
            this.tb_numItems.Text = numItems.ToString();
        }

        private void btn_increase_Click(object sender, RoutedEventArgs e)
        {
           int numItems = int.Parse(this.tb_numItems.Text);
           this.btn_decrease.IsEnabled = true;
           numItems++;
           this.tb_numItems.Text = numItems.ToString();
        }

        private void btn_addToTray_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dd_sides_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
