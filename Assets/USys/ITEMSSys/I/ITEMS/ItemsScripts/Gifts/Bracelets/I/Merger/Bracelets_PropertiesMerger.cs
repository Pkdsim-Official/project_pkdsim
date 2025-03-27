using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Bracelets.I.LoadJson;
using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Bracelets.I.Properties;
using UnityEngine;

namespace project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Bracelets.I.Merger
{
	public class Bracelets_PropertiesMerger : MonoBehaviour
	{
		private BraceletsPropertiesI BraceletsPropertiesI;

		private LoadBraceletsJson LoadBraceletsJsons;

		public void LoadProperties(string value)
		{
			BraceletsPropertiesI.Bracelets_LoadPropertiesBase(value);
		}
		public void Load_Bracelets_Jsons()
		{
			LoadBraceletsJsons.LoadBraceletsJsons();
		}
	}
}