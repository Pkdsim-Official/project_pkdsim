using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Earrings.I.Merger;

namespace project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Earrings.I
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