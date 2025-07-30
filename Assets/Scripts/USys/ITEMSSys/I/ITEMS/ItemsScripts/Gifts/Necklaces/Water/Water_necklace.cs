using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Water.WaterDroplet_necklace;
using UnityEngine;

namespace project_pkdsim.USys.ITEMSSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Water
{
	public class Water_necklace : MonoBehaviour
	{
		private WaterDroplet_NecklaceItem WaterDroplet_NecklaceItem;

		public void Get_WaterDropletNecklace()
		{
			WaterDroplet_NecklaceItem.GetBuilder();
		}
	}
}