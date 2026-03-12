using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Bug.Butterfly_necklace;
using UnityEngine;

namespace Project_Pkdsim.USysUnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Bug
{
	public class Bug_Necklace : MonoBehaviour
	{
		private Butterfly_NecklaceItem Butterfly_NecklaceItem;

		public void Get_ButterflyNecklace()
		{
			Butterfly_NecklaceItem.GetBuilder();
		}
	}
}