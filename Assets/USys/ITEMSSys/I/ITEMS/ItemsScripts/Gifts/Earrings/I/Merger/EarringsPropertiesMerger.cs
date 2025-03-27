using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Earrings.I.LoadJson;
using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Earrings.I.Properties;
using UnityEngine;

namespace project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Earrings.I.Merger
{
	public class Earrings_PropertiesMerger : MonoBehaviour
	{
		private EarringsPropertiesI EarringsPropertiesI;

		private LoadEarringsJson LoadEarringsJsons;

		public void LoadProperties(string value)
		{
			EarringsPropertiesI.Earrings_LoadPropertiesBase(value);
		}
		public void Load_Earrings_Jsons()
		{
			LoadEarringsJsons.LoadEarringsJsons();
		}
	}
}