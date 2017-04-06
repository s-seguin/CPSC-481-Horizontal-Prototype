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
    /// Interaction logic for Page_Specials.xaml
    /// </summary>
    public partial class Page_Specials : UserControl
    {
        string path = "../../Resources/Images/Drinks/";
        string foodPath = "../../Resources/Images/Food/";
        List<string> wingFlavors = new List<string> { "Mango Chipotle", "Salt & Vinegar", "Parmesan Herb", "Dill Pickle", "Salt & Pepper", "Ketchup", "Asian Sweet Ginger", "Hot Teriyaki", "Baja Chipotle", "Buffalo Bleu Cheese",
                "Sweet Chili", "Crown Royal Whiskey BBQ", "Spicy Parmesan", "Honey Garlic", "Teriyaki", "Red Cream Ale", "Poblano Chili and Lime", "Red Thai", "Sweet Szechwan", "Honey Hot", "Sri Lanken",
                "Philippine Adobo Pepper", "Buffalo Mild", "Buffalo Medium", "Buffalo Hot", "Buffalo Hotter" };

        public Page_Specials()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            string day = dt.DayOfWeek.ToString();
            //string day = "Saturday";
            wingFlavors.Sort();

            switch (day)
            {
                case "Tuesday":
                    tueSpecials();
                    break;
                case "Wednesday":
                    wedSpecials();
                    break;
                case "Thursday":
                    thurSpecials();
                    break;
                case "Friday":
                    friSpecials();
                    break;
                case "Saturday":
                    satSpecials();
                    break;
                case "Sunday":
                    sunSpecials();
                    break;
                default:
                    monSpecials();
                    break;
            }
        }

        private void navButton_Click(object sender, RoutedEventArgs e)
        {
            if (btn_drinks.IsFocused)
            {
                sv_specials.ScrollToTop();
            }
            else if (btn_food.IsFocused)
            {
                var point = header_food.TranslatePoint(new Point(0,0), header_drinks);
                sv_specials.ScrollToVerticalOffset(point.Y);
            }
        }

        private void monSpecials()
        {
            string gasLampPrice = "$6.50";

            wp_drinks.Children.Add(new MenuItem_Control("Gas Lamp \nPrairie Pale Ale", gasLampPrice, "A crisp copper coloured pale ale that perfectly balances a smooth and robust malt base with an aromatic hint of citrus hops.", path + "prairie_pale_ale.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Rustic Red", gasLampPrice, "We have recrafted our Rustic Red! This deep red ale is balanced with toasted malts, caramel toffee and a distinct hoppy finish.", path + "rustic_red.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Gas Lamp \nBlanc", gasLampPrice, "A refreshing golden wheat beer with fruity flavours of orange and tropical citrus. Perfect for enjoying on a sunny summer day.", path + "gaslamp_blanc.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("West Coast IPA", gasLampPrice, "A perfectly balanced West Coast IPA. Brewed with premium malts and cascade dry-hopping, West Coast IPA has an enticingly smooth and slightly sweet flavour. Bursts of citrus aromas make this one drinkable beer.", path + "west_coast_ipa.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Nut Brown Ale", gasLampPrice, "This is one full-bodied and refreshing premium dark ale! With a wealth of taste sensations roused by roasted malts, hints of chocolate and espresso flavours.", path + "nut_brown.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Maple Cream", gasLampPrice, "A smooth bold and rich amber ale with a hint of all natural Canadian maple. It is perfectly balanced with the hint of sweetness in the flavour and aroma", path + "maple_cream.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Gas Lamp \nLight", gasLampPrice, "This superior light lager is complimented by peppery hops and sweet malts. A performance beer with 4% alcohol by volume and less than 170 calories per pint.", path + "gaslamp_light.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Platinum Blonde", gasLampPrice, "A preservative free, golden lager with a thick head and a malty smoothness. An easy drinking beer that is great for watching the game, long nights on the patio or the perfect pairing for wing night.", path + "platinum_blonde.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Belgian White Mist", gasLampPrice, "This is a true Belgian style wit beer, brewed with Canadian wheat. It is unfiltered and finished with just a hint of grapefruit zest. Served in a traditional Belgian abby glass with a wedge of grapefruit", path + "belgian_white.jpeg"));

            wp_food.Children.Add(new MenuItem_Control("Chicken Wings", "$2.40", "1 pound of lightly floured Canadian chicken wings, crisp carrots & celery, house-made Greek yogurt ranch or creamy bleu cheese dip\n\nCome in orders of 10.", foodPath + "wings_special.jpg", wingFlavors));
        }

        private void tueSpecials()
        {
            string gasLampPrice = "$5.00";

            wp_drinks.Children.Add(new MenuItem_Control("Gas Lamp \nPrairie Pale Ale", gasLampPrice, "A crisp copper coloured pale ale that perfectly balances a smooth and robust malt base with an aromatic hint of citrus hops.", path + "prairie_pale_ale.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Rustic Red", gasLampPrice, "We have recrafted our Rustic Red! This deep red ale is balanced with toasted malts, caramel toffee and a distinct hoppy finish.", path + "rustic_red.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Gas Lamp \nBlanc", gasLampPrice, "A refreshing golden wheat beer with fruity flavours of orange and tropical citrus. Perfect for enjoying on a sunny summer day.", path + "gaslamp_blanc.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("West Coast IPA", gasLampPrice, "A perfectly balanced West Coast IPA. Brewed with premium malts and cascade dry-hopping, West Coast IPA has an enticingly smooth and slightly sweet flavour. Bursts of citrus aromas make this one drinkable beer.", path + "west_coast_ipa.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Nut Brown Ale", gasLampPrice, "This is one full-bodied and refreshing premium dark ale! With a wealth of taste sensations roused by roasted malts, hints of chocolate and espresso flavours.", path + "nut_brown.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Maple Cream", gasLampPrice, "A smooth bold and rich amber ale with a hint of all natural Canadian maple. It is perfectly balanced with the hint of sweetness in the flavour and aroma", path + "maple_cream.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Gas Lamp \nLight", gasLampPrice, "This superior light lager is complimented by peppery hops and sweet malts. A performance beer with 4% alcohol by volume and less than 170 calories per pint.", path + "gaslamp_light.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Platinum Blonde", gasLampPrice, "A preservative free, golden lager with a thick head and a malty smoothness. An easy drinking beer that is great for watching the game, long nights on the patio or the perfect pairing for wing night.", path + "platinum_blonde.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Belgian White Mist", gasLampPrice, "This is a true Belgian style wit beer, brewed with Canadian wheat. It is unfiltered and finished with just a hint of grapefruit zest. Served in a traditional Belgian abby glass with a wedge of grapefruit", path + "belgian_white.jpeg"));

            wp_food.Children.Add(new MenuItem_Control("Tacos", "$2.50", "Try our sabroso meat, chicken or fish tacos!\n\nMinimum order of 3.", foodPath + "tacos.jpg"));
        }

        private void wedSpecials()
        {
            // lbl_info.Content = "Half price happy hour on all drinks from 2pm - 6pm!!!";
            // lbl_info.Visibility = Visibility.Visible;

            string gasLampPrice = "$4.75";

            wp_drinks.Children.Add(new MenuItem_Control("Gas Lamp \nPrairie Pale Ale", gasLampPrice, "A crisp copper coloured pale ale that perfectly balances a smooth and robust malt base with an aromatic hint of citrus hops.", path + "prairie_pale_ale.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Rustic Red", gasLampPrice, "We have recrafted our Rustic Red! This deep red ale is balanced with toasted malts, caramel toffee and a distinct hoppy finish.", path + "rustic_red.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Gas Lamp \nBlanc", gasLampPrice, "A refreshing golden wheat beer with fruity flavours of orange and tropical citrus. Perfect for enjoying on a sunny summer day.", path + "gaslamp_blanc.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("West Coast IPA", gasLampPrice, "A perfectly balanced West Coast IPA. Brewed with premium malts and cascade dry-hopping, West Coast IPA has an enticingly smooth and slightly sweet flavour. Bursts of citrus aromas make this one drinkable beer.", path + "west_coast_ipa.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Nut Brown Ale", gasLampPrice, "This is one full-bodied and refreshing premium dark ale! With a wealth of taste sensations roused by roasted malts, hints of chocolate and espresso flavours.", path + "nut_brown.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Maple Cream", gasLampPrice, "A smooth bold and rich amber ale with a hint of all natural Canadian maple. It is perfectly balanced with the hint of sweetness in the flavour and aroma", path + "maple_cream.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Gas Lamp \nLight", gasLampPrice, "This superior light lager is complimented by peppery hops and sweet malts. A performance beer with 4% alcohol by volume and less than 170 calories per pint.", path + "gaslamp_light.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Platinum Blonde", gasLampPrice, "A preservative free, golden lager with a thick head and a malty smoothness. An easy drinking beer that is great for watching the game, long nights on the patio or the perfect pairing for wing night.", path + "platinum_blonde.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Belgian White Mist", gasLampPrice, "This is a true Belgian style wit beer, brewed with Canadian wheat. It is unfiltered and finished with just a hint of grapefruit zest. Served in a traditional Belgian abby glass with a wedge of grapefruit", path + "belgian_white.jpeg"));

            wp_food.Children.Add(new MenuItem_Control("Big Pub Burger", "$6.50", "house-made beef patty, bacon, grilled onions, sautéed mushrooms, signature burger sauce, green leaf lettuce, tomato, red onion, pickle, Swiss, mozzarella or Canadian cheddar cheese, fresh brioche bun", foodPath + "big_pub_special.png"));

            wp_food.Children.Add(new MenuItem_Control("Wings", "$6.50", "1 pound of lightly floured Canadian chicken wings, crisp carrots & celery, house-made Greek yogurt ranch or creamy bleu cheese dip.", foodPath + "wings.jpg", wingFlavors));
        }

        private void thurSpecials()
        {
            lbl_info.Content = "Bottles of wine - 51% off \nGlasses of wine 6 oz. - $7.50 | 9 oz. - $11";
            lbl_info.Visibility = Visibility.Visible;

            string winePrice = "51% off";

            wp_food.Children.Add(new MenuItem_Control("Steak Sandwich", "$8.99", "marinated 28 day aged Certified Angus Beef sirloin, grilled Italian filone, buttermilk beer battered onion ring, Montreal steak spice infused compound butter", foodPath + "steak_sandwich_special.png"));

        }

        private void friSpecials()
        {
            
            string gasLampPrice = "$6.99";

            wp_drinks.Children.Add(new MenuItem_Control("Fireball", "$5.00", "It'll probably burn you, but it'll taste fantastic while it does so.\n\nPrice is per shot.", path + "fireball.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Gas Lamp \nPrairie Pale Ale", gasLampPrice, "A crisp copper coloured pale ale that perfectly balances a smooth and robust malt base with an aromatic hint of citrus hops.", path + "prairie_pale_ale.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Rustic Red", gasLampPrice, "We have recrafted our Rustic Red! This deep red ale is balanced with toasted malts, caramel toffee and a distinct hoppy finish.", path + "rustic_red.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Gas Lamp \nBlanc", gasLampPrice, "A refreshing golden wheat beer with fruity flavours of orange and tropical citrus. Perfect for enjoying on a sunny summer day.", path + "gaslamp_blanc.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("West Coast IPA", gasLampPrice, "A perfectly balanced West Coast IPA. Brewed with premium malts and cascade dry-hopping, West Coast IPA has an enticingly smooth and slightly sweet flavour. Bursts of citrus aromas make this one drinkable beer.", path + "west_coast_ipa.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Nut Brown Ale", gasLampPrice, "This is one full-bodied and refreshing premium dark ale! With a wealth of taste sensations roused by roasted malts, hints of chocolate and espresso flavours.", path + "nut_brown.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Maple Cream", gasLampPrice, "A smooth bold and rich amber ale with a hint of all natural Canadian maple. It is perfectly balanced with the hint of sweetness in the flavour and aroma", path + "maple_cream.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Gas Lamp \nLight", gasLampPrice, "This superior light lager is complimented by peppery hops and sweet malts. A performance beer with 4% alcohol by volume and less than 170 calories per pint.", path + "gaslamp_light.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Platinum Blonde", gasLampPrice, "A preservative free, golden lager with a thick head and a malty smoothness. An easy drinking beer that is great for watching the game, long nights on the patio or the perfect pairing for wing night.", path + "platinum_blonde.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Belgian White Mist", gasLampPrice, "This is a true Belgian style wit beer, brewed with Canadian wheat. It is unfiltered and finished with just a hint of grapefruit zest. Served in a traditional Belgian abby glass with a wedge of grapefruit", path + "belgian_white.jpeg"));

            wp_food.Children.Add(new MenuItem_Control("Mussels", "$9.99", "1 pound of Atlantic mussels, garlic and white wine broth, grilled Italian filone", foodPath + "mussels.jpg"));
        }

        private void satSpecials()
        {

            wp_drinks.Children.Add(new MenuItem_Control("Jägermeister", "$5.00", "Sweet nectar of the gods", path + "jager.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Bulldog", "$8.00", "", path + "bulldog.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Jameson", "$4.00", "", path + "jameson.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Chivas Regal", "$4.50", "", path + "chivas_regal.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Crown Royal", "$4.00", "", path + "crown_royal.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Crown Royal \nBlack", "$4.50", "", path + "crown_royal_black.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Crown Royal \nMaple", "$4.00", "", path + "crown_royal_maple.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Gibsons \nFinest 12 Years", "$4.00", "", path + "gibsons.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Jack Daniel's", "$4.00", "", path + "jack_daniels.png"));

            wp_drinks.Children.Add(new MenuItem_Control("Jack Daniel's \nHoney", "$4.00", "", path + "jack_daniels_honey.png"));

            wp_drinks.Children.Add(new MenuItem_Control("Maker's Mark", "$4.50", "", path + "makers_mark.png"));

            wp_drinks.Children.Add(new MenuItem_Control("Grey Goose", "$9.00", "", path + "grey_goose.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Smirnoff", "$8.00", "", path + "smirnoff.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Smirnoff \nFlavored", "$8.00", "", path + "smirnoff_flavored.jpeg"));

            wp_food.Children.Add(new MenuItem_Control("Spicy Carnivore", "$9.00", "Italian sausage, Montréal smoked meat, chopped bacon, Sriracha tomato sauce, mixed three cheese blend", foodPath + "flatbread_spicy.jpg"));

            wp_food.Children.Add(new MenuItem_Control("Prociutto and Arugula", "$9.00", "thin sliced prosciutto, mixed three cheese blend, house-made tomato sauce, fresh arugula", foodPath + "flatbread_prosciutto.jpg"));

            wp_food.Children.Add(new MenuItem_Control("Spinach and Feta", "$9.00", "fresh spinach, red onion, diced tomato, feta and mozzarella cheese, signature tomato sauce", foodPath + "flatbread_spinach.jpg"));
        }

        private void sunSpecials()
        {
            string gasLampPrice = "$6.50";

            wp_drinks.Children.Add(new MenuItem_Control("Nut Brown Ale", "$6.50", "This is one full-bodied and refreshing premium dark ale! With a wealth of taste sensations roused by roasted malts, hints of chocolate and espresso flavours.", path + "nut_brown.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Platinum Blonde", gasLampPrice, "A preservative free, golden lager with a thick head and a malty smoothness. An easy drinking beer that is great for watching the game, long nights on the patio or the perfect pairing for wing night.", path + "platinum_blonde.jpeg"));

            wp_drinks.Children.Add(new MenuItem_Control("Gas Lamp \nPrairie Pale Ale", gasLampPrice, "A crisp copper coloured pale ale that perfectly balances a smooth and robust malt base with an aromatic hint of citrus hops.", path + "prairie_pale_ale.jpeg"));
        }
    }
}
