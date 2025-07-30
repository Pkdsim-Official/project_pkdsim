using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Dark.Lunar_necklace;
using UnityEngine;

namespace project_pkdsim.USys.ITEMSSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Dark
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