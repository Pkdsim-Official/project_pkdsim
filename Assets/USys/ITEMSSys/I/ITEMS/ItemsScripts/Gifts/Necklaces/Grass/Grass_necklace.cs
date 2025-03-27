using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.Grass.Leaf_necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.I.ITEMS.ItemsScripts.Gifts.Necklaces.Grass
{
	public class Grass_Necklace : MonoBehaviour
	{
		private Leaf_NecklaceItem Leaf_NecklaceItem;

		public void Get_LeafNecklace()
		{
			Leaf_NecklaceItem.GetBuilder();
		}
	}
}