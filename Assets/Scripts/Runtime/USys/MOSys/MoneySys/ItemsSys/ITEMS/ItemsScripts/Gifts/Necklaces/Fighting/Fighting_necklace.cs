using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Fighting.Punching_Bag_necklace;
using UnityEngine;

namespace Project_Pkdsim.USysUnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Fighting
{
	public class Fighting_Necklace : MonoBehaviour
	{
		private Punching_Bag_NecklaceItem Punching_Bag_NecklaceItem;

		public void Get_PunchingBagNecklace()
		{
			Punching_Bag_NecklaceItem.GetBuilder();
		}
	}
}