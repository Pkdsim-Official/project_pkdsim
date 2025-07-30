using project_pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Flying.Wings_necklace;
using UnityEngine;

namespace project_pkdsim.USysUnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Flying
{
	public class Flying_Necklace : MonoBehaviour
	{
		private Wings_NecklaceItem Wings_NecklaceItem;

		public void Get_WingsNecklace()
		{
			Wings_NecklaceItem.GetBuilder();
		}
	}
}