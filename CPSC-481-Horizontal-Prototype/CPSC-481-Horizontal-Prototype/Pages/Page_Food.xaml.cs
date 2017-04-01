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
    /// Interaction logic for Page_Food.xaml
    /// </summary>
    public partial class Page_Food : UserControl
    {
        public Page_Food()
        {
            InitializeComponent();

            string starters_price = "$15.00";
            string desserts_price = "$8.50";

            string path = "../../Resources/Images/Food/";

            //init Starters
            wp_starters.Children.Add(new MenuItem_Control("Dynamite Spring Rolls", starters_price, "pan fried shrimp, cabbage, carrots, green onion, pickled ginger, wasabi honey soy, avocado crema", path + "spring_rolls.jpg"));
            wp_starters.Children.Add(new MenuItem_Control("Stuffed Yorkshires", starters_price, "four large house-made Yorkshire puddings, Certified Angus Beef, horseradish mayo, au jus", path + "stuffed_yorkshires.jpg"));
            wp_starters.Children.Add(new MenuItem_Control("Atlantic Mussels", starters_price, "1 pound of Atlantic mussels, garlic and white wine broth, grilled Italian filone", path + "mussels.jpg"));
            wp_starters.Children.Add(new MenuItem_Control("Chicken Quesadilla", "$15.50", "seasoned chicken breast, Cajun black beans, jalapeños, red & green peppers, red onion, banana peppers, mixed cheese blend, salsa, sour cream, tri - coloured tortilla chips", path + "quesadilla.png"));
            wp_starters.Children.Add(new MenuItem_Control("Chicken Tenders", starters_price, "breaded chicken breast strips, fresh cut fries, plum sauce, choice of signature rub or sauce", path + "chicken_tenders.jpg"));
            wp_starters.Children.Add(new MenuItem_Control("Little Pub Sliders", starters_price, "house-made patties, bacon, cheddar cheese, pan fried mushrooms, grilled onions, lettuce, tomato, red onion, pickle, signature burger sauce", path + "little_pub_sliders.jpg"));
            wp_starters.Children.Add(new MenuItem_Control("Truffle Fries", "$11.00", "house cut fries, truffle oil, green onion, Parmesan herb spice, fresh grated Parmesan\nDip choice: garlic aioli, greek yogurt ranch, chipotle mayo, sriracha balsamic ketchup", path + "truffle_fries.jpg"));
            wp_starters.Children.Add(new MenuItem_Control("Pickle Spears", "$14.50", "flash fried seasoned dill pickle quarters, Southwest chipotle dip", path + "pickle_spears.jpg"));
            wp_starters.Children.Add(new MenuItem_Control("Chicken Wings", starters_price, "1 pound of lightly floured Canadian chicken wings, crisp carrots & celery, house - made Greek yogurt ranch or creamy bleu cheese dip", path + "wings.jpg"));

            //init Nachos & Platters
            wp_nachos.Children.Add(new MenuItem_Control("Loaded Nachos", "$23.00", "tri-coloured tortilla chips, Monterey jack, mozzarella, Canadian cheddar cheese, tomato, black olives, red and green onion, chopped peppers, jalapeños, salsa, sour cream", path + "loaded_nachos.jpg"));
            wp_nachos.Children.Add(new MenuItem_Control("Irish Potato Nachos", "$14.50", "lattice cut potatoes, melted three cheese blend, ripe tomatoes, sliced jalapeños, green onion, salsa, sour cream", path + "irish_potato_nachos.jpg"));

            //init Soups
            wp_soups.Children.Add(new MenuItem_Control("Roasted Tomato Basil", "$8.75", "roasted tomatoes, chopped basil, fresh cream, house - made croutons", path + "roasted_tomato_basil.jpg"));
            wp_soups.Children.Add(new MenuItem_Control("Clam Chowder", "$11.00", "thick and creamy loaded with thick cut bacon, clams, potato, carrots, onion", path + "clam_chowder.jpg"));
            wp_soups.Children.Add(new MenuItem_Control("Broccoli & Cheddar", "$9.00", "fresh broccoli, heavy cream, mozzarella, Monterey jack and cheddar cheese", path + "broccoli_cheddar.jpg"));

            //init Salads
            wp_salads.Children.Add(new MenuItem_Control("Poached Pear & Beet", "$15.50", "red and golden beets, wine poached pears, bed of spinach, goat's cheese, honey balsamic dressing, flatbread wedges", path + "salad_pear_beet.jpg"));
            wp_salads.Children.Add(new MenuItem_Control("Original Cobb", "$16.50", "five lettuce mix, chopped bacon, chicken breast, bleu cheese, tomato, avocado, green onion, hardboiled egg, balsamic vinaigrette", path + "salad_cobb.jpg"));
            wp_salads.Children.Add(new MenuItem_Control("Caesar Salad", "$13.75", "house-made dressing with capers, anchovies & garlic, topped with rough chopped thick bacon, fresh croutons, Parmesan cheese, fried capers, flatbread wedges", path + "salad_caesar.jpg"));
            wp_salads.Children.Add(new MenuItem_Control("Quinoa & Kale", "$15.50", "tomato, onion, pepper, quinoa, red & curly kale, citrus dressing, goat's cheese, flatbread wedges", path + "salad_quinoa_kale.jpg"));

            //init Burgers
            wp_burgers.Children.Add(new MenuItem_Control("Big Pub Burger", "$15.50", "house-made beef patty, bacon, grilled onions, sautéed mushrooms, signature burger sauce, green leaf lettuce, tomato, red onion, pickle, Swiss, mozzarella or Canadian cheddar cheese, fresh brioche bun", path + "burger_big_pub.jpg"));
            wp_burgers.Children.Add(new MenuItem_Control("Jalapeño & Bacon", "$16.75", "house-made beef patty, double smoked thick cut bacon, spicy aioli, jalapeño rings, jalapeño jack cheddar cheese, lettuce, tomato, red onion, dill pickle, onion infused bun", path + "burger_jalapeno_bacon.jpg"));
            wp_burgers.Children.Add(new MenuItem_Control("Stuffed Bacon\nCheddar Burger", "$17.25", "6oz patty stuffed with bacon and cheddar, avocado aioli, back bacon, smoked cheddar, mango avocado salsa, red onion, sliced tomato, leaf lettuce, fried egg, fresh brioche bun", path + "burger_stuffed.jpg"));
            wp_burgers.Children.Add(new MenuItem_Control("Bison Burger", "$17.50", "Alberta free range bison patty, ripe avocado, bleu cheese BBQ sauce, tomato relish, green leaf lettuce, fresh brioche bun", path + "burger_bison.png"));
            wp_burgers.Children.Add(new MenuItem_Control("Lamb Burger", "$17.25", "house-made lamb burger, imported Guinness cheddar cheese, red onion marmalade, buttermilk beer battered onion ring, multi - grain bun", path + "burger_lamb.jpg"));
            wp_burgers.Children.Add(new MenuItem_Control("Malibu Garden Burger", "$15.00", "vegetarian burger with organic vegetables and grains, avocado aioli, lettuce, red onion, tomato, fresh mango avocado salsa, multi - grain bun", path + "burger_malibu.jpg"));

            //init Sandwiches
            wp_sandwiches.Children.Add(new MenuItem_Control("Montreal Reuben", "$17.00", "thick marble rye bread, sliced Montréal smoked meat, melted Swiss cheese, pickles, braised red cabbage, house - made beer mustard sauce", path + "sw_montreal_reuben.jpg"));
            wp_sandwiches.Children.Add(new MenuItem_Control("Brisket Dip", "$17.00", "slow cooked smoked brisket, grilled Italian filone, horseradish mayo, au jus", path + "sw_brisket_dip.jpg"));
            wp_sandwiches.Children.Add(new MenuItem_Control("Steak Sandwich", "$18.00", "marinated 28 day aged Certified Angus Beef sirloin, grilled Italian filone, buttermilk beer battered onion ring, Montreal steak spice infused compound butter ADD AN EXTRA 5oz STE", path + "sw_steak.jpg"));
            wp_sandwiches.Children.Add(new MenuItem_Control("Gourmet Grilled Cheese", "$16.00", "Canadian cheddar, Swiss cheese, smoked bacon, ripe avocado, sliced tomato, 1” thick sourdough, side of Sriracha balsamic ketchup", path + "sw_grilled_cheese.jpg"));

            //init Flatbreads
            wp_flatbreads.Children.Add(new MenuItem_Control("Spicy Carnivore", "$14.50", "Italian sausage, Montréal smoked meat, chopped bacon, Sriracha tomato sauce, mixed three cheese blend", path + "flatbread_spicy.jpg"));
            wp_flatbreads.Children.Add(new MenuItem_Control("Prociutto and Arugula", "$13.50", "thin sliced prosciutto, mixed three cheese blend, house-made tomato sauce, fresh arugula", path + "flatbread_prosciutto.jpg"));
            wp_flatbreads.Children.Add(new MenuItem_Control("Spinach and Feta", "$13.50", "fresh spinach, red onion, diced tomato, feta and mozzarella cheese, signature tomato sauce", path + "flatbread_spinach.jpg"));

            //init Desserts
            wp_desserts.Children.Add(new MenuItem_Control("Mud Pie", desserts_price, "oreo cookie crust, peanut butter, cappuccino ice cream, vanilla ice cream, chocolate sauce, whipped cream", path + "mud_pie.jpg"));
            wp_desserts.Children.Add(new MenuItem_Control("Apple Pie", desserts_price, "caramelized granny smith apples, cinnamon brown sugar, flakey puff pastry, vanilla ice cream \n\nThis fresh baked item can take up to 20 minutes to cook.", path + "apple_pie.jpg"));

        }


        //method allows header button on page to navigate to desired list position
        private void navButton_Click(object sender, RoutedEventArgs e)
        {
            if (btn_starters.IsFocused)
            {
                sv_food.ScrollToTop();
            }
            else if (btn_nachos.IsFocused)
            {
                var point = header_nachos.TranslatePoint(new Point(0, 0), header_starters);
                sv_food.ScrollToVerticalOffset(point.Y);
            }
            else if (btn_soups.IsFocused)
            {
                var point = header_soups.TranslatePoint(new Point(0, 0), header_starters);
                sv_food.ScrollToVerticalOffset(point.Y);
            }
            else if (btn_salads.IsFocused)
            {
                var point = header_salads.TranslatePoint(new Point(0, 0), header_starters);
                sv_food.ScrollToVerticalOffset(point.Y);
            }
            else if (btn_burgers.IsFocused)
            {
                var point = header_burgers.TranslatePoint(new Point(0, 0), header_starters);
                sv_food.ScrollToVerticalOffset(point.Y);
            }
            else if (btn_sandwiches.IsFocused)
            {
                var point = header_sandwiches.TranslatePoint(new Point(0, 0), header_starters);
                sv_food.ScrollToVerticalOffset(point.Y);
            }
            else if (btn_flatbreads.IsFocused)
            {
                var point = header_flatbreads.TranslatePoint(new Point(0, 0), header_starters);
                sv_food.ScrollToVerticalOffset(point.Y);
            }
            else if (btn_desserts.IsFocused)
            {
                var point = header_desserts.TranslatePoint(new Point(0, 0), header_starters);
                sv_food.ScrollToVerticalOffset(point.Y);
            }
        }
    }
}
