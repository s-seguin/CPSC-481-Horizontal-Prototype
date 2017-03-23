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
            wp_gasLamps.Children.Add(new MenuItem_Control("Gas Lamp \nPrairie Pale Ale", gasLampPrice, "A crisp copper coloured pale ale that perfectly balances a smooth and robust malt base with an aromatic hint of citrus hops.", path + "prairie_pale_ale.jpeg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("Rustic Red", gasLampPrice, "We have recrafted our Rustic Red! This deep red ale is balanced with toasted malts, caramel toffee and a distinct hoppy finish.", path + "rustic_red.jpeg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("Gas Lamp \nBlanc", gasLampPrice, "A refreshing golden wheat beer with fruity flavours of orange and tropical citrus. Perfect for enjoying on a sunny summer day.", path + "gaslamp_blanc.jpeg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("West Coast IPA", gasLampPrice, "A perfectly balanced West Coast IPA. Brewed with premium malts and cascade dry-hopping, West Coast IPA has an enticingly smooth and slightly sweet flavour. Bursts of citrus aromas make this one drinkable beer.", path + "west_coast_ipa.jpeg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("Nut Brown Ale", gasLampPrice, "This is one full-bodied and refreshing premium dark ale! With a wealth of taste sensations roused by roasted malts, hints of chocolate and espresso flavours.", path + "nut_brown.jpeg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("Maple Cream", gasLampPrice, "A smooth bold and rich amber ale with a hint of all natural Canadian maple. It is perfectly balanced with the hint of sweetness in the flavour and aroma", path + "maple_cream.jpeg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("Gas Lamp \nLight", gasLampPrice, "This superior light lager is complimented by peppery hops and sweet malts. A performance beer with 4% alcohol by volume and less than 170 calories per pint.", path + "gaslamp_light.jpeg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("Platinum Blonde", gasLampPrice, "A preservative free, golden lager with a thick head and a malty smoothness. An easy drinking beer that is great for watching the game, long nights on the patio or the perfect pairing for wing night.", path + "platinum_blonde.jpeg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("Belgian White Mist", gasLampPrice, "This is a true Belgian style wit beer, brewed with Canadian wheat. It is unfiltered and finished with just a hint of grapefruit zest. Served in a traditional Belgian abby glass with a wedge of grapefruit", path + "belgian_white.jpeg"));

            //Init Canadian Brewed
            cb1.lbl_itemName.Content = "Big Rock \nGrasshopper";
            cb1.lbl_itemPrice.Content = canadianPrice;
            cb1.background.ImageSource = new BitmapImage(new Uri(path + "grasshopper.jpeg", UriKind.Relative));

            cb2.lbl_itemName.Content = "Big Rock \nTraditional Ale";
            cb2.lbl_itemPrice.Content = canadianPrice;
            cb2.background.ImageSource = new BitmapImage(new Uri(path + "traditional_ale.jpeg", UriKind.Relative));

            cb3.lbl_itemName.Content = "Last Best IPA";
            cb3.lbl_itemPrice.Content = canadianPrice;
            cb3.background.ImageSource = new BitmapImage(new Uri(path + "last_best_ipa.jpeg", UriKind.Relative));

            cb4.lbl_itemName.Content = "Tool Shed \nStar Cheek IPA";
            cb4.lbl_itemPrice.Content = canadianPrice;
            cb4.background.ImageSource = new BitmapImage(new Uri(path + "star_cheek.jpeg", UriKind.Relative));

            cb5.lbl_itemName.Content = "Village Blacksmith";
            cb5.lbl_itemPrice.Content = canadianPrice;
            cb5.background.ImageSource = new BitmapImage(new Uri(path + "village_blacksmith.jpeg", UriKind.Relative));

            cb6.lbl_itemName.Content = "Wild Rose \nRaspberry";
            cb6.lbl_itemPrice.Content = canadianPrice;
            cb6.background.ImageSource = new BitmapImage(new Uri(path + "wraspberry_ale.jpeg", UriKind.Relative));

            cb7.lbl_itemName.Content = "Alexander Keith's";
            cb7.lbl_itemPrice.Content = canadianPrice;
            cb7.background.ImageSource = new BitmapImage(new Uri(path + "alexander_keiths.jpeg", UriKind.Relative));

            cb8.lbl_itemName.Content = "Molson \nCanadian";
            cb8.lbl_itemPrice.Content = canadianPrice;
            cb8.background.ImageSource = new BitmapImage(new Uri(path + "molson_canadian.jpeg", UriKind.Relative));

            cb9.lbl_itemName.Content = "Phillips Blue Buck";
            cb9.lbl_itemPrice.Content = canadianPrice;
            cb9.background.ImageSource = new BitmapImage(new Uri(path + "blue_buck.jpeg", UriKind.Relative));


            //Init Of the World
            otw1.lbl_itemName.Content = "Guinness Stout";
            otw1.lbl_itemPrice.Content = otwPrice;
            otw1.background.ImageSource = new BitmapImage(new Uri(path + "guinness_stout.jpeg", UriKind.Relative));

            otw2.lbl_itemName.Content = "Strongbow Cider";
            otw2.lbl_itemPrice.Content = otwPrice;
            otw2.background.ImageSource = new BitmapImage(new Uri(path + "strongbow_cider.jpeg", UriKind.Relative));


            //Init Irish Whiskey
            irish1.lbl_itemName.Content = "Jameson";
            irish1.lbl_itemPrice.Content = "$8.00";
            irish1.background.ImageSource = new BitmapImage(new Uri(path + "jameson.jpeg", UriKind.Relative));

            //Init Scotch
            scotch1.lbl_itemName.Content = "Chivas Regal";
            scotch1.lbl_itemPrice.Content = "$9.00";
            scotch1.background.ImageSource = new BitmapImage(new Uri(path + "chivas_regal.jpeg", UriKind.Relative));

            //Init Canadian
            cadWhiskey1.lbl_itemName.Content = "Crown Royal";
            cadWhiskey1.lbl_itemPrice.Content = "$8.00";
            cadWhiskey1.background.ImageSource = new BitmapImage(new Uri(path + "crown_royal.jpeg", UriKind.Relative));

            cadWhiskey2.lbl_itemName.Content = "Crown Royal \nBlack";
            cadWhiskey2.lbl_itemPrice.Content = "$9.00";
            cadWhiskey2.background.ImageSource = new BitmapImage(new Uri(path + "crown_royal_black.jpeg", UriKind.Relative));

            cadWhiskey3.lbl_itemName.Content = "Crown Royal \nMaple";
            cadWhiskey3.lbl_itemPrice.Content = "$8.00";
            cadWhiskey3.background.ImageSource = new BitmapImage(new Uri(path + "crown_royal_maple.jpeg", UriKind.Relative));

            cadWhiskey4.lbl_itemName.Content = "Gibsons \nFinest 12 Years";
            cadWhiskey4.lbl_itemPrice.Content = "$8.00";
            cadWhiskey4.background.ImageSource = new BitmapImage(new Uri(path + "gibsons.jpeg", UriKind.Relative));

            //Init Bourbon
            bourbon1.lbl_itemName.Content = "Jack Daniel's";
            bourbon1.lbl_itemPrice.Content = "$8.00";
            bourbon1.background.ImageSource = new BitmapImage(new Uri(path + "jack_daniels.png", UriKind.Relative));

            bourbon2.lbl_itemName.Content = "Jack Daniel's \nHoney";
            bourbon2.lbl_itemPrice.Content = "$8.00";
            bourbon2.background.ImageSource = new BitmapImage(new Uri(path + "jack_daniels_honey.png", UriKind.Relative));

            bourbon3.lbl_itemName.Content = "Maker's Mark";
            bourbon3.lbl_itemPrice.Content = "$9.00";
            bourbon3.background.ImageSource = new BitmapImage(new Uri(path + "makers_mark.png", UriKind.Relative));

            //Init Gin
            gin1.lbl_itemName.Content = "Bombay Sapphire";
            gin1.lbl_itemPrice.Content = "$8.00";
            gin1.background.ImageSource = new BitmapImage(new Uri(path + "bombay_sapphire.jpeg", UriKind.Relative));

            gin2.lbl_itemName.Content = "Tanqueray";
            gin2.lbl_itemPrice.Content = "$8.00";
            gin2.background.ImageSource = new BitmapImage(new Uri(path + "tanqueray.jpeg", UriKind.Relative));

            //Init Rum
            rum1.lbl_itemName.Content = "Bacardi Gold";
            rum1.lbl_itemPrice.Content = rumPrice;
            rum1.background.ImageSource = new BitmapImage(new Uri(path + "bacardi_gold.jpeg", UriKind.Relative));

            rum2.lbl_itemName.Content = "Bacardi White";
            rum2.lbl_itemPrice.Content = rumPrice;
            rum2.background.ImageSource = new BitmapImage(new Uri(path + "bacardi_white.jpeg", UriKind.Relative));

            rum3.lbl_itemName.Content = "Captain Morgan \nBlack Spiced";
            rum3.lbl_itemPrice.Content = rumPrice;
            rum3.background.ImageSource = new BitmapImage(new Uri(path + "captain_morgan_black.jpeg", UriKind.Relative));

            rum4.lbl_itemName.Content = "Captain Morgan \nPrivate Stock";
            rum4.lbl_itemPrice.Content = rumPrice;
            rum4.background.ImageSource = new BitmapImage(new Uri(path + "captain_morgan.jpeg", UriKind.Relative));

            //Init Vodka
            vodka1.lbl_itemName.Content = "Grey Goose";
            vodka1.lbl_itemPrice.Content = "$9.00";
            vodka1.background.ImageSource = new BitmapImage(new Uri(path + "grey_goose.jpeg", UriKind.Relative));

            vodka2.lbl_itemName.Content = "Smirnoff";
            vodka2.lbl_itemPrice.Content = "$8.00";
            vodka2.background.ImageSource = new BitmapImage(new Uri(path + "smirnoff.jpeg", UriKind.Relative));

            vodka3.lbl_itemName.Content = "Smirnoff \nFlavored";
            vodka3.lbl_itemPrice.Content = "$8.00";
            vodka3.background.ImageSource = new BitmapImage(new Uri(path + "smirnoff_flavored.jpeg", UriKind.Relative));

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
