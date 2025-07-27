using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.Dark.Lunar_necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.I.ITEMS.ItemsScripts.Gifts.Necklaces.Dark
{
	public class Dark_Necklace : MonoBehaviour
	{
		private Lunar_NecklaceItem Lunar_NecklaceItem;

		public void Get_LunarNecklace()
		{
			Lunar_NecklaceItem.GetBuilder();
		}
	}
}