using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Rings.Modules.Merger;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Rings.Modules
{
    public class RingsI : Rings_PropertiesMerger
    {
        public void Rings_LoadPropertiesManager(string value)
        {
            Load_Rings_Jsons();
            LoadProperties(value);
        }
    }
}