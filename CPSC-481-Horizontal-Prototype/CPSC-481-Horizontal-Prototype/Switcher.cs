using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CPSC_481_Horizontal_Prototype
{
    class Switcher
    {
        public static MainScreen pageSwitcher;

        public static void Switch(UserControl newPage)
        {
            pageSwitcher.Navigate(newPage);
        }


    }
}
