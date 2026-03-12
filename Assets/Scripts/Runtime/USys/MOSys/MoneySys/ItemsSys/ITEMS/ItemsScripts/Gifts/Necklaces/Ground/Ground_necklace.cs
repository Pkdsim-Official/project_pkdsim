using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ground.Crust_necklace;
using UnityEngine;

namespace Project_Pkdsim.USysUnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ground
{
	public class Ground_Necklace : MonoBehaviour
	{
		private Crust_NecklaceItem Crust_NecklaceItem;

		public void Get_CrustNecklace()
		{
			Crust_NecklaceItem.GetBuilder();
		}
	}
}