using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.Fighting.PunchingBag_necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.I.ITEMS.ItemsScripts.Gifts.Necklaces.Fighting
{
	public class Fighting_Necklace : MonoBehaviour
	{
		private PunchingBag_NecklaceItem PunchingBag_NecklaceItem;

		public void Get_PunchingBagNecklace()
		{
			PunchingBag_NecklaceItem.GetBuilder();
		}
	}
}