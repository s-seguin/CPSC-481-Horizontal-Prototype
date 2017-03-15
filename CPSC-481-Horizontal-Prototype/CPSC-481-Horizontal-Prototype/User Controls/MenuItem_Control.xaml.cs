using CPSC_481_Horizontal_Prototype.Screens;
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
        String description;

        public MenuItem_Control()
        {
            InitializeComponent();
        }

        public void setDescription(string descr)
        {
            this.description = descr;
        }

        public string getDesription()
        {
            return description;
        }

        private void btn_viewItem_Click(object sender, RoutedEventArgs e)
        { 
            ExamineItemScreen eis = new ExamineItemScreen();

            //change item name to fit on one line
            string temp = (String) lbl_itemName.Content;

            //update name, price, description and image of template
            eis.lbl_itemName.Content = Regex.Replace(temp, @"\n", ""); 
            eis.lbl_itemPrice.Content = lbl_itemPrice.Content;
            eis.tb_description.Text = this.getDesription();
            eis.image.Source = background.ImageSource;

            //change overlay dimensions
            eis.Height = SystemParameters.PrimaryScreenHeight * .4;
            eis.Width = SystemParameters.PrimaryScreenWidth * .4;
            eis.ShowDialog();
        }


    }
}
