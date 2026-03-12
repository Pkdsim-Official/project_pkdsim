using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Bracelets.Modules.Merger;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Bracelets.Modules
{
    public class BraceletsI : Bracelets_PropertiesMerger
    {
        public void Bracelets_LoadPropertiesManager(string value)
        {
            Load_Bracelets_Jsons();
            LoadProperties(value);
        }
    }
}