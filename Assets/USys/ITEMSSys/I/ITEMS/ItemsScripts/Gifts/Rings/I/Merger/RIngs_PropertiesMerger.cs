using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Rings.I.Properties;
using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.RIngs.I.LoadJson;
using UnityEngine;

namespace project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Rings.I.Merger
{
	public class Rings_PropertiesMerger : MonoBehaviour
	{
		private RingsPropertiesI RingsPropertiesI;

		private LoadRIngsJson LoadRingsJsons;

		public void LoadProperties(string value)
		{
			RingsPropertiesI.Rings_LoadPropertiesBase(value);
		}
		public void Load_Rings_Jsons()
		{
			LoadRingsJsons.LoadRIngsJsons();
		}
	}
}