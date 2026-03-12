using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Water.Water_Droplet_necklace;
using UnityEngine;

namespace Project_Pkdsim.USysUnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Water
{
	public class Water_necklace : MonoBehaviour
	{
		private Water_Droplet_NecklaceItem WaterDroplet_NecklaceItem;

		public void Get_WaterDropletNecklace()
		{
			WaterDroplet_NecklaceItem.GetBuilder();
		}
	}
}