using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Earrings.Modules.Merger;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Earrings.Modules
{
    public class EarringsI : Earrings_PropertiesMerger
    {
        public void Earrings_LoadPropertiesManager(string value)
        {
            Load_Earrings_Jsons();
            LoadProperties(value);
        }
    }
}