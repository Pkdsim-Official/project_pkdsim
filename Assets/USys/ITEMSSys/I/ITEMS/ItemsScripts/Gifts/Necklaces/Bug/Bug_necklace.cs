using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.Bug.Butterfly_necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.I.ITEMS.ItemsScripts.Gifts.Necklaces.Bug
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