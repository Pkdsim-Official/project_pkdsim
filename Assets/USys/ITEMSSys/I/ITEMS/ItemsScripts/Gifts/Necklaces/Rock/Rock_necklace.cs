using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.Rock.Brick_necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.I.ITEMS.ItemsScripts.Gifts.Necklaces.Rock
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