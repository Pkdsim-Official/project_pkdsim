using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.Fire.Sun_necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.I.ITEMS.ItemsScripts.Gifts.Necklaces.Fire
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