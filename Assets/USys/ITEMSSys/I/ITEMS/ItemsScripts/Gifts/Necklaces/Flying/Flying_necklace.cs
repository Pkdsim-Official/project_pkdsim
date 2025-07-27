using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.Flying.Wings_necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.I.ITEMS.ItemsScripts.Gifts.Necklaces.Flying
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