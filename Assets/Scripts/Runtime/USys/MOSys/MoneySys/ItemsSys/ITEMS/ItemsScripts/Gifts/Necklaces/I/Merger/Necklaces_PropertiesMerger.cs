using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson;
using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.Properties;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.Merger
{
	public class Necklaces_PropertiesMerger : MonoBehaviour
	{
		private NecklacesPropertiesI necklacesPropertiesI;

		private LoadNecklacesJson LoadNecklacesJsons;

		public void LoadProperties(string value)
		{
			necklacesPropertiesI.Necklaces_LoadPropertiesBase(value);
		}
		public void Load_Necklaces_Jsons()
		{
			LoadNecklacesJsons.LoadNecklacesJsons();
		}
	}
}