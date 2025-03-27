using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Bracelets.I.Merger;

namespace project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Bracelets.I
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