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
    /// Interaction logic for Page_Drinks.xaml
    /// </summary>
    public partial class Page_Drinks : UserControl
    {
        public Page_Drinks()
        {
            InitializeComponent();
            string gasLampPrice = "$7.25";
            string canadianPrice = "$7.75";
            string otwPrice = "$9.25";
            string rumPrice = "$8.00";

            //Init Gas Lamps
            gl1.lbl_itemName.Content = "Gas Lamp \nPrairie Pale Ale";
            gl1.lbl_itemPrice.Content =  gasLampPrice;

            gl2.lbl_itemName.Content = "Rustic Red";
            gl2.lbl_itemPrice.Content =  gasLampPrice;

            gl3.lbl_itemName.Content = "Gas Lamp \nBlanc";
            gl3.lbl_itemPrice.Content =  gasLampPrice;

            gl4.lbl_itemName.Content = "West Coast IPA";
            gl4.lbl_itemPrice.Content =  gasLampPrice;

            gl5.lbl_itemName.Content = "Nut Brown Ale";
            gl5.lbl_itemPrice.Content =  gasLampPrice;

            gl6.lbl_itemName.Content = "Maple Cream";
            gl6.lbl_itemPrice.Content =  gasLampPrice;

            gl7.lbl_itemName.Content = "Gas Lamp \nLight";
            gl7.lbl_itemPrice.Content =  gasLampPrice;

            gl8.lbl_itemName.Content = "Platinum Blonde";
            gl8.lbl_itemPrice.Content =  gasLampPrice;

            gl9.lbl_itemName.Content = "Belgian White Mist";
            gl9.lbl_itemPrice.Content =  gasLampPrice;

            //Init Canadian Brewed
            cb1.lbl_itemName.Content = "Big Rock \nGrasshopper";
            cb1.lbl_itemPrice.Content =  canadianPrice;

            cb2.lbl_itemName.Content = "Big Rock \nTraditional Ale";
            cb2.lbl_itemPrice.Content =  canadianPrice;

            cb3.lbl_itemName.Content = "Last Best IPA";
            cb3.lbl_itemPrice.Content =  canadianPrice;

            cb4.lbl_itemName.Content = "Tool Shed \nStar Creek IPA";
            cb4.lbl_itemPrice.Content =  canadianPrice;

            cb5.lbl_itemName.Content = "Village Blacksmith";
            cb5.lbl_itemPrice.Content =  canadianPrice;

            cb6.lbl_itemName.Content = "Wild Rose \nRaspberry";
            cb6.lbl_itemPrice.Content =  canadianPrice;

            cb7.lbl_itemName.Content = "Alexander Keith's";
            cb7.lbl_itemPrice.Content =  canadianPrice;

            cb8.lbl_itemName.Content = "Molson \nCanadian";
            cb8.lbl_itemPrice.Content =  canadianPrice;

            cb9.lbl_itemName.Content = "Phillips Blue Rock";
            cb9.lbl_itemPrice.Content =  canadianPrice;


            //Init Of the World
            otw1.lbl_itemName.Content = "Guinness Stout";
            otw1.lbl_itemPrice.Content =  otwPrice;

            otw2.lbl_itemName.Content = "Strongbow Cider";
            otw2.lbl_itemPrice.Content =  otwPrice;


            //Init Irish Whiskey
            irish1.lbl_itemName.Content = "Jameson";
            irish1.lbl_itemPrice.Content =  "$8.00";

            //Init Scotch
            scotch1.lbl_itemName.Content = "Chivas Regal";
            scotch1.lbl_itemPrice.Content =  "$9.00";

            //Init Canadian
            cadWhiskey1.lbl_itemName.Content = "Crown Royal";
            cadWhiskey1.lbl_itemPrice.Content = "$8.00";

            cadWhiskey2.lbl_itemName.Content = "Crown Royal \nBlack";
            cadWhiskey2.lbl_itemPrice.Content = "$9.00";

            cadWhiskey3.lbl_itemName.Content = "Crown Royal \nMaple";
            cadWhiskey3.lbl_itemPrice.Content = "$8.00";

            cadWhiskey4.lbl_itemName.Content = "Gibsons \nFinest 12 Years";
            cadWhiskey4.lbl_itemPrice.Content = "$8.00";

            //Init Bourbon
            bourbon1.lbl_itemName.Content = "Jack Daniel's";
            bourbon1.lbl_itemPrice.Content = "$8.00";

            bourbon2.lbl_itemName.Content = "Jack Daniel's \nHoney";
            bourbon2.lbl_itemPrice.Content = "$8.00";

            bourbon3.lbl_itemName.Content = "Maker's Mark";
            bourbon3.lbl_itemPrice.Content = "$9.00";

            //Init Gin
            gin1.lbl_itemName.Content = "Bombay Sapphire";
            gin1.lbl_itemPrice.Content = "$8.00";

            gin2.lbl_itemName.Content = "Tanqueray";
            gin2.lbl_itemPrice.Content = "$8.00";

            //Init Rum
            rum1.lbl_itemName.Content = "Bacardi Gold";
            rum1.lbl_itemPrice.Content = rumPrice;

            rum2.lbl_itemName.Content = "Bacardi White";
            rum2.lbl_itemPrice.Content = rumPrice;

            rum3.lbl_itemName.Content = "Captain Morgan \nBlack Spiced";
            rum3.lbl_itemPrice.Content = rumPrice;

            rum4.lbl_itemName.Content = "Captain Morgan \nPrivate Stock";
            rum4.lbl_itemPrice.Content = rumPrice;

            //Init Vodka
            vodka1.lbl_itemName.Content = "Grey Goose";
            vodka1.lbl_itemPrice.Content = "$9.00";

            vodka2.lbl_itemName.Content = "Smirnoff";
            vodka2.lbl_itemPrice.Content = "$8.00";

            vodka3.lbl_itemName.Content = "Smirnoff \nFlavored";
            vodka3.lbl_itemPrice.Content = "$8.00";

        }

        private void navButton_Click(object sender, RoutedEventArgs e)
        {
            if (btn_beer.IsFocused)
            {
                sv_drinks.ScrollToTop();
            }
            else if (btn_whiskey.IsFocused)
            {
                var point = header_whiskey.TranslatePoint(new Point(0, 0), header_beer);
                sv_drinks.ScrollToVerticalOffset(point.Y);
            }
            else if (btn_topShelf.IsFocused)
            {
                var point = header_topShelf.TranslatePoint(new Point(0, 0), header_beer);
                sv_drinks.ScrollToVerticalOffset(point.Y);
            }
            else if (btn_cocktails.IsFocused)
            {
                var point = header_cocktails.TranslatePoint(new Point(0, 0), header_beer);
                sv_drinks.ScrollToVerticalOffset(point.Y);
            }
            else if (btn_martinis.IsFocused)
            {
                var point = header_martinis.TranslatePoint(new Point(0, 0), header_beer);
                sv_drinks.ScrollToVerticalOffset(point.Y);
            }
            else if (btn_wine.IsFocused)
            {
                var point = header_wine.TranslatePoint(new Point(0, 0), header_beer);
                sv_drinks.ScrollToVerticalOffset(point.Y);
            }
        }

    }
}
