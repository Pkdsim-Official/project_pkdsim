using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Bug.Butterfly_necklace;
using UnityEngine;

namespace project_pkdsim.USys.ITEMSSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Bug
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