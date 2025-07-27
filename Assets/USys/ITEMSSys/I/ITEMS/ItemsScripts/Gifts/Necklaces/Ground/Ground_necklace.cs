using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.Ground.Crust_necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.I.ITEMS.ItemsScripts.Gifts.Necklaces.Ground
{
	public class Ground_Necklace : MonoBehaviour
	{
		private Crust_NecklaceItem Crust_NecklaceItem;

		public void Get_CrustNecklace()
		{
			Crust_NecklaceItem.GetBuilder();
		}
	}
}