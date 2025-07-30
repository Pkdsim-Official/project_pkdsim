using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Fighting.PunchingBag_necklace;
using UnityEngine;

namespace project_pkdsim.USys.ITEMSSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Fighting
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