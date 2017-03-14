using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC_481_Horizontal_Prototype.Classes
{

   
    /// <summary>
    /// This class holds all the current tabs that have been created
    /// </summary>
    /// 
    public class ActiveTabs
    {
        #region attributes
        private List<UserTab> allActiveTabs = new List<UserTab>();
        #endregion

        #region constructors
        public ActiveTabs(UserTab firstTab)
        {
            allActiveTabs.Add(firstTab);
        }
        #endregion

        public void AddTab(UserTab tab)
        {
            allActiveTabs.Add(tab);
        }

        public void RemoveTab(UserTab tab)
        {
            allActiveTabs.Remove(tab);
        }
        
        public List<UserTab> GetTabs()
        {
            return allActiveTabs;
        }

    }
}
