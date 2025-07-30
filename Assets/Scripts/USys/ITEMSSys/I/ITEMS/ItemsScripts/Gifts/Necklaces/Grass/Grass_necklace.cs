using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Grass.Leaf_necklace;
using UnityEngine;

namespace project_pkdsim.USys.ITEMSSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Grass
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