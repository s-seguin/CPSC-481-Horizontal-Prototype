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
            
            wp_gasLamps.Children.Add(new MenuItem_Control("Gas Lamp \nPrairie Pale Ale", gasLampPrice, "A crisp copper coloured pale ale that perfectly balances a smooth and robust malt base with an aromatic hint of citrus hops.", path + "prairie_pale_ale.jpg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("Rustic Red", gasLampPrice, "We have recrafted our Rustic Red! This deep red ale is balanced with toasted malts, caramel toffee and a distinct hoppy finish.", path + "rustic_red.jpg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("Gas Lamp \nBlanc", gasLampPrice, "A refreshing golden wheat beer with fruity flavours of orange and tropical citrus. Perfect for enjoying on a sunny summer day.", path + "gaslamp_blanc.jpg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("West Coast IPA", gasLampPrice, "A perfectly balanced West Coast IPA. Brewed with premium malts and cascade dry-hopping, West Coast IPA has an enticingly smooth and slightly sweet flavour. Bursts of citrus aromas make this one drinkable beer.", path + "west_coast_ipa.jpg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("Nut Brown Ale", gasLampPrice, "This is one full-bodied and refreshing premium dark ale! With a wealth of taste sensations roused by roasted malts, hints of chocolate and espresso flavours.", path + "nut_brown.jpg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("Maple Cream", gasLampPrice, "A smooth bold and rich amber ale with a hint of all natural Canadian maple. It is perfectly balanced with the hint of sweetness in the flavour and aroma", path + "maple_cream.jpg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("Gas Lamp \nLight", gasLampPrice, "This superior light lager is complimented by peppery hops and sweet malts. A performance beer with 4% alcohol by volume and less than 170 calories per pint.", path + "gaslamp_light.jpg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("Platinum Blonde", gasLampPrice, "A preservative free, golden lager with a thick head and a malty smoothness. An easy drinking beer that is great for watching the game, long nights on the patio or the perfect pairing for wing night.", path + "platinum_blonde.jpg"));

            wp_gasLamps.Children.Add(new MenuItem_Control("Belgian White Mist", gasLampPrice, "This is a true Belgian style wit beer, brewed with Canadian wheat. It is unfiltered and finished with just a hint of grapefruit zest. Served in a traditional Belgian abby glass with a wedge of grapefruit", path + "belgian_white.jpg"));

            //Init Canadian Brewed
            wp_domestic.Children.Add(new MenuItem_Control("Big Rock \nGrasshopper", canadianPrice, "Truly a home grown, honest-to-goodness Albertan beer. A light touch of hops gives the beer a crisp finish, balancing its soft sweetness and texture with fruity or citrusy notes", path + "grasshopper.jpg"));

            wp_domestic.Children.Add(new MenuItem_Control("Big Rock \nTraditional Ale", canadianPrice, "Calgary’s original craft beer, a deep copper colour with a blend of caramel and black hops" , path + "traditional_ale.jpg"));

            wp_domestic.Children.Add(new MenuItem_Control("Last Best IPA", canadianPrice, "A raw and unfiltered IPA showcasing the tropical and citrusy notes of the Mosaic Hops.This is a well balanced 4 malt blend.", path + "last_best_ipa.jpg"));

            wp_domestic.Children.Add(new MenuItem_Control("Tool Shed \nStar Cheek IPA", canadianPrice, "This India pale ale is hoppy, bold and citrusy, yet clean and crisp. These hops don’t smack you in the face, they tempt you to experience their complex profile.", path + "star_cheek.jpg"));

            wp_domestic.Children.Add(new MenuItem_Control("Village Blacksmith", canadianPrice, "A distinctly dark and flavourful ale that carefully balances the sweet flavours of the dark malts with the bitterness of the hopping.Citrus aromas balanced with roasted espresso, chocolate and licorice.", path + "village_blacksmith.jpg"));

            wp_domestic.Children.Add(new MenuItem_Control("Wild Rose \nRaspberry", canadianPrice, "Wraspberry Ale continues a centuries-long tradition by using raspberries to give a tart edge to this smooth, refreshing ale.", path + "wraspberry_ale.jpg"));

            wp_domestic.Children.Add(new MenuItem_Control("Alexander Keith's", canadianPrice, "Smooth golden ale with a distinct taste. Slight sweetness and a bitter finish.", path + "alexander_keiths.jpg"));

            wp_domestic.Children.Add(new MenuItem_Control("Molson \nCanadian", canadianPrice, "A beer made from Canadian water, prairie barley and no preservatives. This is one clean, crisp beer.", path + "molson_canadian.jpg"));

            wp_domestic.Children.Add(new MenuItem_Control("Phillips Blue Buck", canadianPrice, "A deep amber coloured beer, the Blue Buck has a crisp finish featuring a delicate hop aroma.", path + "blue_buck.jpg"));


            //Init Of the World
            wp_otw.Children.Add(new MenuItem_Control("Guinness Stout", otwPrice, "Brewed the same way since 1759 at St. James’s Gate Brewery in Dublin.Velvet black with a thick creamy head.", path + "guinness_stout.jpg"));

            wp_otw.Children.Add(new MenuItem_Control("Strongbow Cider", otwPrice, "Bold cider flavour from the fermented cider apples followed by a distinct fresh apple taste from the culinary apples.", path + "strongbow_cider.jpg"));

            wp_otw.Children.Add(new MenuItem_Control("Heineken Brewlock", otwPrice, "A patented BrewLock system relies on natural atmospheric pressure versus propellant gasses. Using only water, malted barley, and hops. The resin from the female hop flower cones is used to help balance the sweetness of the barley with a refreshing bitterness.", path + "heineken.jpg"));


            //Init Irish Whiskey
            wp_irish.Children.Add(new MenuItem_Control("Jameson", "$8.00", "", path + "jameson.jpg"));

            //Init Scotch
            wp_scotch.Children.Add(new MenuItem_Control("Chivas Regal", "$9.00", "", path + "chivas_regal.jpg"));

            //Init Canadian Whiskey
            wp_cadWhiskey.Children.Add(new MenuItem_Control("Crown Royal", "$8.00", "", path + "crown_royal.jpg"));

            wp_cadWhiskey.Children.Add(new MenuItem_Control("Crown Royal \nBlack", "$9.00", "", path + "crown_royal_black.jpg"));

            wp_cadWhiskey.Children.Add(new MenuItem_Control("Crown Royal \nMaple", "$8.00", "", path + "crown_royal_maple.jpg"));

            wp_cadWhiskey.Children.Add(new MenuItem_Control("Gibsons \nFinest 12 Years", "$8.00", "", path + "gibsons.jpg"));

            //Init Bourbon
            wp_bourbon.Children.Add(new MenuItem_Control("Jack Daniel's", "$8.00", "", path + "jack_daniels.png"));

            wp_bourbon.Children.Add(new MenuItem_Control("Jack Daniel's \nHoney", "$8.00", "", path + "jack_daniels_honey.png"));

            wp_bourbon.Children.Add(new MenuItem_Control("Maker's Mark", "$9.00", "", path + "makers_mark.png"));

            //Init Gin
            wp_gin.Children.Add(new MenuItem_Control("Bombay Sapphire", "$8.00", "", path + "bombay_sapphire.jpg"));

            wp_gin.Children.Add(new MenuItem_Control("Tanqueray", "$8.00", "", path + "tanqueray.jpg"));

            //Init Rum
            wp_rum.Children.Add(new MenuItem_Control("Bacardi Gold", rumPrice, "", path + "bacardi_gold.jpg"));

            wp_rum.Children.Add(new MenuItem_Control("Bacardi White", rumPrice, "", path + "bacardi_white.jpg"));

            wp_rum.Children.Add(new MenuItem_Control("Captain Morgan \nBlack Spiced", rumPrice, "", path + "captain_morgan_black.jpg"));

            wp_rum.Children.Add(new MenuItem_Control("Captain Morgan \nPrivate Stock", rumPrice, "", path + "captain_morgan.jpg"));

            //Init Vodka
            wp_vodka.Children.Add(new MenuItem_Control("Grey Goose", "$9.00", "", path + "grey_goose.jpg"));

            wp_vodka.Children.Add(new MenuItem_Control("Smirnoff", "$8.00", "", path + "smirnoff.jpg"));

            wp_vodka.Children.Add(new MenuItem_Control("Smirnoff \nFlavored", "$8.00", "", path + "smirnoff_flavored.jpg"));

            //Init Non-Alcholic Beverages
            wp_nonAlc.Children.Add(new MenuItem_Control("Water", "$0.00", "H20", path + "water.png"));

            wp_nonAlc.Children.Add(new MenuItem_Control("Coca Cola", "$2.50", "Coca-Cola is the most popular and biggest-selling soft drink in history, as well as one of the most recognizable brands in the world.", path + "coke.png"));

            wp_nonAlc.Children.Add(new MenuItem_Control("Sprite", "$2.50", "Introduced in 1961, Sprite is the world's leading lemon-lime flavored soft drink. Sprite is sold in more than 190 countries and ranks as the No. 3 soft drink worldwide.", path + "sprite.png"));

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
            /*  Removed as we do not have the proper photos yet
             * else if (btn_cocktails.IsFocused)
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
            }*/

            else if (btn_nonAlc.IsFocused)
            {
                var point = header_nonAlc.TranslatePoint(new Point(0, 0), header_beer);
                sv_drinks.ScrollToVerticalOffset(point.Y);
            }
        }

        private void sv_drinks_ManipulationBoundaryFeedback(object sender, ManipulationBoundaryFeedbackEventArgs e)
        {
            e.Handled = true;
        }
    }
}
