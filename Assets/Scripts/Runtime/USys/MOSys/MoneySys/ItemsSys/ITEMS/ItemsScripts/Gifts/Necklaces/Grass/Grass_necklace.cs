using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Grass.Leaf_necklace;
using UnityEngine;

namespace Project_Pkdsim.USysUnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Grass
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