using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.Merger;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules
{
    public class NecklacesI : Necklaces_PropertiesMerger
    {
        public void Necklaces_LoadPropertiesManager(string value)
        {
            Load_Necklaces_Jsons();
            LoadProperties(value);
        }
    }
}