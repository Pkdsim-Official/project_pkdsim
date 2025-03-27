using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.Fairy.Heart_necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.I.ITEMS.ItemsScripts.Gifts.Necklaces.Fairy
{
	public class Fairy_Necklace : MonoBehaviour
	{
		private Heart_NecklaceItem Heart_NecklaceItem;

		public void Get_HeartNecklace()
		{
			Heart_NecklaceItem.GetBuilder();
		}
	}
}