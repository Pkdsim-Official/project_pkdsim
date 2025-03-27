using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Rings.I.Merger;

namespace project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Rings.I
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