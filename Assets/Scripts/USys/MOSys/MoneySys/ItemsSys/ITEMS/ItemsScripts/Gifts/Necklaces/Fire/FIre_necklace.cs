using project_pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Fire.Sun_necklace;
using UnityEngine;

namespace project_pkdsim.USysUnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Fire
{
	public class Fire_Necklace : MonoBehaviour
	{
		private Sun_NecklaceItem Sun_NecklaceItem;

		public void Get_SunNecklace()
		{
			Sun_NecklaceItem.GetBuilder();
		}
	}
}