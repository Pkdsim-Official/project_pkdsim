using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Bracelets.Modules.LoadJson;
using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Bracelets.Modules.Properties;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Bracelets.Modules.Merger
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