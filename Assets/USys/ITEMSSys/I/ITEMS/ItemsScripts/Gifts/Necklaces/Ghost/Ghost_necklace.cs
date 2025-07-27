using project_pkdsim.Assets.USys.UItemsSystemSys.ITEMS.ItemsScripts.Gifts.Necklaces.Ghost.Soul_necklace;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.I.ITEMS.ItemsScripts.Gifts.Necklaces.Ghost
{
	public class Ghost_Necklace : MonoBehaviour
	{
		private Soul_NecklaceItem Soul_NecklaceItem;

		public void Get_SoulNecklace()
		{
			Soul_NecklaceItem.GetBuilder();
		}
	}
}