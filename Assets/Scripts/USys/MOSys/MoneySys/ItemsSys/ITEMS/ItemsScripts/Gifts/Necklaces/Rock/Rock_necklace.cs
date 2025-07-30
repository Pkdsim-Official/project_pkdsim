using project_pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Rock.Brick_necklace;
using UnityEngine;

namespace project_pkdsim.USysUnityItemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Rock
{
	public class Rock_necklace : MonoBehaviour
	{

		private Brick_NecklaceItem Brick_NecklaceItem;

		public void Get_BrickNecklace()
		{
			Brick_NecklaceItem.GetBuilder();
		}
	}
}