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

            string path = "../../Resources/Images/Drinks/";

            //Init Gas Lamps
            gl1.lbl_itemName.Content = "Gas Lamp \nPrairie Pale Ale";
            gl1.lbl_itemPrice.Content =  gasLampPrice;
            gl1.setDescription("A crisp copper coloured pale ale that perfectly balances a smooth and robust malt base with an aromatic hint of citrus hops.");
            gl1.background.ImageSource = new BitmapImage(new Uri(path + "prairie_pale_ale.jpeg", UriKind.Relative));

            gl2.lbl_itemName.Content = "Rustic Red";
            gl2.lbl_itemPrice.Content =  gasLampPrice;
            gl2.setDescription("We have recrafted our Rustic Red! This deep red ale is balanced with toasted malts, caramel toffee and a distinct hoppy finish.");
            gl2.background.ImageSource = new BitmapImage(new Uri(path + "rustic_red.jpeg", UriKind.Relative));

            gl3.lbl_itemName.Content = "Gas Lamp \nBlanc";
            gl3.lbl_itemPrice.Content =  gasLampPrice;
            gl3.setDescription("A refreshing golden wheat beer with fruity flavours of orange and tropical citrus. Perfect for enjoying on a sunny summer day.");
            gl3.background.ImageSource = new BitmapImage(new Uri(path + "gaslamp_blanc.jpeg", UriKind.Relative));

            gl4.lbl_itemName.Content = "West Coast IPA";
            gl4.lbl_itemPrice.Content =  gasLampPrice;
            gl4.setDescription("A perfectly balanced West Coast IPA. Brewed with premium malts and cascade dry-hopping, West Coast IPA has an enticingly smooth and slightly sweet flavour. Bursts of citrus aromas make this one drinkable beer.");
            gl4.background.ImageSource = new BitmapImage(new Uri(path + "west_coast_ipa.jpeg", UriKind.Relative));

            gl5.lbl_itemName.Content = "Nut Brown Ale";
            gl5.lbl_itemPrice.Content =  gasLampPrice;
            gl5.setDescription("This is one full-bodied and refreshing premium dark ale! With a wealth of taste sensations roused by roasted malts, hints of chocolate and espresso flavours.");
            gl5.background.ImageSource = new BitmapImage(new Uri(path + "nut_brown.jpeg", UriKind.Relative));

            gl6.lbl_itemName.Content = "Maple Cream";
            gl6.lbl_itemPrice.Content =  gasLampPrice;
            gl6.setDescription("A smooth bold and rich amber ale with a hint of all natural Canadian maple. It is perfectly balanced with the hint of sweetness in the flavour and aroma");
            gl6.background.ImageSource = new BitmapImage(new Uri(path + "maple_cream.jpeg", UriKind.Relative));

            gl7.lbl_itemName.Content = "Gas Lamp \nLight";
            gl7.lbl_itemPrice.Content =  gasLampPrice;
            gl7.setDescription("This superior light lager is complimented by peppery hops and sweet malts. A performance beer with 4% alcohol by volume and less than 170 calories per pint.");
            gl7.background.ImageSource = new BitmapImage(new Uri(path + "gaslamp_light.jpeg", UriKind.Relative));

            gl8.lbl_itemName.Content = "Platinum Blonde";
            gl8.lbl_itemPrice.Content =  gasLampPrice;
            gl8.setDescription("A preservative free, golden lager with a thick head and a malty smoothness. An easy drinking beer that is great for watching the game, long nights on the patio or the perfect pairing for wing night.");
            gl8.background.ImageSource = new BitmapImage(new Uri(path + "platinum_blonde.jpeg", UriKind.Relative));

            gl9.lbl_itemName.Content = "Belgian White Mist";
            gl9.lbl_itemPrice.Content =  gasLampPrice;
            gl9.setDescription("This is a true Belgian style wit beer, brewed with Canadian wheat. It is unfiltered and finished with just a hint of grapefruit zest. Served in a traditional Belgian abby glass with a wedge of grapefruit");
            gl9.background.ImageSource = new BitmapImage(new Uri(path + "belgian_white.jpeg", UriKind.Relative));

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
