using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ghost.Soul_necklace;
using UnityEngine;

namespace project_pkdsim.USys.ITEMSSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ghost
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